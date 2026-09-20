"""
core/obfuscator_detector.py
Nhan dien chinh xac loai Obfuscator tu binary signature va metadata patterns.
Tra ve profile voi tham so de4dot toi uu cho tung truong hop.
"""
import re
import struct
import zipfile
from dataclasses import dataclass, field
from pathlib import Path
from typing import Any, Dict, List, Optional


# Chu ky nhan dien tung Obfuscator
_SIGNATURES = [
    {
        "name": "ConfuserEx",
        "patterns": [b"ConfuserEx", b"Confuser.Core", b"ConfusedBy", b"module cctor"],
        "level_hints": {b"Maximum": "maximum", b"Ultra": "ultra", b"Normal": "normal"},
        "features": ["string_encrypt", "control_flow", "anti_dump", "anti_debug"],
        "de4dot_strategies": [
            ["--strtyp", "delegate"],
            ["--strtyp", "delegate", "--strarg", ""],
            ["--strtyp", "emptyclass"],
            [],
        ],
    },
    {
        "name": "Eazfuscator.NET",
        "patterns": [b"EazfuscatorNet", b"Eazfuscator", b"eaz_"],
        "level_hints": {},
        "features": ["string_encrypt", "control_flow", "resource_encrypt"],
        "de4dot_strategies": [["--detect", "eaz"], []],
    },
    {
        "name": "SmartAssembly",
        "patterns": [b"SmartAssembly.Attributes", b"Obfuscated by SA", b"SmartAssembly"],
        "level_hints": {},
        "features": ["string_encrypt", "control_flow", "anti_decompile"],
        "de4dot_strategies": [["--detect", "sa"], []],
    },
    {
        "name": ".NET Reactor",
        "patterns": [b"CliSecure", b"CR_", b"Reactor", b"rpx"],
        "level_hints": {},
        "features": ["native_stub", "string_encrypt", "anti_debug"],
        "de4dot_strategies": [["--detect", "cr"], ["--strtyp", "delegate"], []],
    },
    {
        "name": "Dotfuscator",
        "patterns": [b"Dotfuscator", b"Preemptive", b"DotfuscatorAttribute"],
        "level_hints": {},
        "features": ["renaming", "control_flow", "string_encrypt"],
        "de4dot_strategies": [["--detect", "df"], []],
    },
    {
        "name": "Babel .NET Obfuscator",
        "patterns": [b"BabelObfuscator", b"Babel.Runtime"],
        "level_hints": {},
        "features": ["string_encrypt", "control_flow"],
        "de4dot_strategies": [["--detect", "bl"], []],
    },
    {
        "name": "Agile.NET (Xenocode)",
        "patterns": [b"Xenocode", b"SecureTeam", b"AgileDotNetRT"],
        "level_hints": {},
        "features": ["virtualization", "string_encrypt"],
        "de4dot_strategies": [["--detect", "an"], []],
    },
    {
        "name": "MaxToCode",
        "patterns": [b"MaxToCode", b"NetGuard", b"NETGuard"],
        "level_hints": {},
        "features": ["native_code_conversion", "string_encrypt"],
        "de4dot_strategies": [["--detect", "mc"], []],
    },
    {
        "name": "Crypto Obfuscator",
        "patterns": [b"CryptoObfuscator", b"LogicNP.CryptoObfuscator"],
        "level_hints": {},
        "features": ["string_encrypt", "control_flow", "anti_debug"],
        "de4dot_strategies": [["--detect", "co"], []],
    },
    {
        "name": "Obfuscar",
        "patterns": [b"Obfuscar"],
        "level_hints": {},
        "features": ["renaming", "string_encrypt"],
        "de4dot_strategies": [["--detect", "oc"], []],
    },
    {
        "name": "UPX Packer",
        "patterns": [b"UPX0", b"UPX1", b"UPX!"],
        "level_hints": {},
        "features": ["packing", "compression"],
        "de4dot_strategies": [],
    },
]

_ANTI_PATTERNS = [
    b"CheckRemoteDebuggerPresent",
    b"IsDebuggerPresent",
    b"NtQueryInformationProcess",
    b"anti_dump",
    b"AntiDebug",
]

_CUSTOM_STRING_ENC_PATTERNS = [
    b"decrypt", b"Decrypt", b"DecryptString", b"GetString",
]


@dataclass
class ObfuscatorProfile:
    """Ket qua nhan dien Obfuscator voi chien luoc xu ly toi uu."""

    name: str = "Unknown"
    confidence: float = 0.0
    level: str = "normal"
    features: List[str] = field(default_factory=list)
    has_anti_debug: bool = False
    has_custom_string_enc: bool = False
    has_virtualization: bool = False
    de4dot_strategies: List[List[str]] = field(default_factory=list)
    raw_notes: List[str] = field(default_factory=list)

    @property
    def is_detected(self) -> bool:
        return self.confidence > 0.2

    @property
    def is_multi_layer(self) -> bool:
        return (
            len(self.features) >= 3
            or self.has_virtualization
            or self.level in ("maximum", "ultra")
        )

    def to_dict(self):
        return {
            "name": self.name,
            "confidence": round(self.confidence, 2),
            "level": self.level,
            "features": self.features,
            "is_multi_layer": self.is_multi_layer,
            "has_anti_debug": self.has_anti_debug,
            "has_custom_string_enc": self.has_custom_string_enc,
            "has_virtualization": self.has_virtualization,
        }


class ObfuscatorDetector:
    """Phan tich binary de nhan dien Obfuscator va de xuat chien luoc xu ly."""

    _SCAN_LIMIT = 4 * 1024 * 1024

    @classmethod
    def detect(cls, file_path: str) -> "ObfuscatorProfile":
        try:
            data = cls._read_sample(file_path)
        except Exception as exc:
            p = ObfuscatorProfile()
            p.raw_notes.append(f"Khong doc duoc file: {exc}")
            return p

        best = ObfuscatorProfile()
        best_score = 0

        for sig in _SIGNATURES:
            score = 0
            hits = []

            for pat in sig["patterns"]:
                if pat in data:
                    score += 1
                    hits.append(pat.decode("utf-8", errors="replace").strip("\x00"))

            if score == 0:
                continue

            confidence = min(score / len(sig["patterns"]) + 0.1, 1.0)

            level = "normal"
            for lvl_pat, lvl_name in sig.get("level_hints", {}).items():
                if lvl_pat in data:
                    level = lvl_name
                    if lvl_name in ("maximum", "ultra"):
                        confidence = min(confidence + 0.2, 1.0)

            if score > best_score:
                best_score = score
                best = ObfuscatorProfile(
                    name=sig["name"],
                    confidence=confidence,
                    level=level,
                    features=list(sig.get("features", [])),
                    de4dot_strategies=list(sig.get("de4dot_strategies", [])),
                    raw_notes=[f"Matched: {', '.join(hits)}"],
                )

        for pat in _ANTI_PATTERNS:
            if pat in data:
                best.has_anti_debug = True
                break

        enc_hits = sum(1 for pat in _CUSTOM_STRING_ENC_PATTERNS if pat in data)
        best.has_custom_string_enc = enc_hits >= 2

        if b"virtualize" in data or b"virt_" in data or b"Virtualization" in data:
            best.has_virtualization = True
            if "virtualization" not in best.features:
                best.features.append("virtualization")

        if not best.is_detected:
            best.name = "Generic Obfuscator"
            best.confidence = 0.1
            best.de4dot_strategies = [
                ["--strtyp", "delegate"],
                ["--strtyp", "emptyclass"],
                ["--strtyp", "static"],
                [],
            ]
            best.raw_notes.append("Khong nhan dien duoc obfuscator cu the - dung generic.")

        return best

    @classmethod
    def _read_sample(cls, file_path: str) -> bytes:
        with open(file_path, "rb") as f:
            return f.read(cls._SCAN_LIMIT)

    @classmethod
    def is_dotnet(cls, file_path: str) -> bool:
        try:
            data = cls._read_sample(file_path)
            if not data.startswith(b"MZ"):
                return False
            e_lfanew = struct.unpack_from("<I", data, 0x3C)[0]
            if e_lfanew + 4 > len(data):
                return False
            if data[e_lfanew:e_lfanew + 4] != b"PE\x00\x00":
                return False
            opt_offset = e_lfanew + 24
            if opt_offset + 2 > len(data):
                return False
            magic = struct.unpack_from("<H", data, opt_offset)[0]
            clr_offset = opt_offset + (112 if magic == 0x10B else 128)
            if clr_offset + 8 > len(data):
                return False
            clr_rva, clr_size = struct.unpack_from("<II", data, clr_offset)
            return clr_rva > 0 and clr_size > 0
        except Exception:
            return False
