import re
from PyQt6.QtCore import Qt, QRegularExpression
from PyQt6.QtGui import QColor, QFont, QSyntaxHighlighter, QTextCharFormat
from PyQt6.QtWidgets import QPlainTextEdit, QWidget, QVBoxLayout

class SimpleSyntaxHighlighter(QSyntaxHighlighter):
    """Bộ tô màu cú pháp nhẹ cho C#, Java, Python, C/C++ và Assembly x86/x64."""

    def __init__(self, parent=None, language="csharp"):
        super().__init__(parent)
        self.language = language.lower()
        self.highlighting_rules = []

        # Định dạng từ khóa (Keywords)
        keyword_format = QTextCharFormat()
        keyword_format.setForeground(QColor("#0066CC"))
        keyword_format.setFontWeight(QFont.Weight.Bold)

        # Định dạng thanh ghi / kiểu dữ liệu
        type_format = QTextCharFormat()
        type_format.setForeground(QColor("#0891B2"))
        type_format.setFontWeight(QFont.Weight.Medium)

        keywords_csharp = [
            r"\bclass\b", r"\bpublic\b", r"\bprivate\b", r"\bprotected\b", r"\binternal\b",
            r"\bstatic\b", r"\bvoid\b", r"\bstring\b", r"\bint\b", r"\bbool\b", r"\bvar\b",
            r"\breturn\b", r"\bif\b", r"\belse\b", r"\bfor\b", r"\bforeach\b", r"\bwhile\b",
            r"\bnew\b", r"\bnamespace\b", r"\busing\b", r"\btry\b", r"\bcatch\b", r"\bfinally\b"
        ]

        keywords_python = [
            r"\bdef\b", r"\bclass\b", r"\bimport\b", r"\bfrom\b", r"\bas\b", r"\breturn\b",
            r"\bif\b", r"\belif\b", r"\belse\b", r"\bfor\b", r"\bwhile\b", r"\btry\b",
            r"\bexcept\b", r"\bfinally\b", r"\bwith\b", r"\bTrue\b", r"\bFalse\b", r"\bNone\b"
        ]

        keywords_c = [
            r"\b#include\b", r"\b#define\b", r"\b#ifdef\b", r"\b#ifndef\b", r"\b#endif\b",
            r"\bextern\b", r"\b__declspec\b", r"\bdllexport\b", r"\bdllimport\b", r"\btypedef\b",
            r"\bstruct\b", r"\bvoid\b", r"\bint\b", r"\bchar\b", r"\bconst\b", r"\bunsigned\b",
            r"\breturn\b", r"\bif\b", r"\belse\b", r"\bfor\b", r"\bwhile\b", r"\bsizeof\b"
        ]

        keywords_asm = [
            r"\bmov\b", r"\bpush\b", r"\bpop\b", r"\bsub\b", r"\badd\b", r"\bxor\b",
            r"\bcall\b", r"\bjmp\b", r"\bje\b", r"\bjne\b", r"\bjz\b", r"\bjnz\b",
            r"\bret\b", r"\bcmp\b", r"\btest\b", r"\blea\b", r"\bnop\b", r"\bint3\b",
            r"\bsection\b", r"\bextern\b", r"\bglobal\b"
        ]

        keywords_lisp = [
            r"\bdefun\b", r"\bdefun-q\b", r"\bsetq\b", r"\bset\b", r"\bgetvar\b", r"\bsetvar\b",
            r"\bcommand\b", r"\bvl-load-com\b", r"\bvla-[a-zA-Z0-9-]+\b", r"\bvlr-[a-zA-Z0-9-]+\b",
            r"\bvlax-[a-zA-Z0-9-]+\b", r"\bprinc\b", r"\bprint\b", r"\bprompt\b", r"\balert\b",
            r"\bcond\b", r"\bif\b", r"\bprogn\b", r"\bwhile\b", r"\brepeat\b", r"\bforeach\b",
            r"\band\b", r"\bor\b", r"\bnot\b", r"\bload\b", r"\bc:[a-zA-Z0-9_-]+\b"
        ]

        keywords_xml = [
            r"</?[a-zA-Z0-9_:-]+", r"/?>", r"\b[a-zA-Z0-9_:-]+(?==)"
        ]

        asm_regs = [
            r"\brax\b", r"\brbx\b", r"\brcx\b", r"\brdx\b", r"\brsi\b", r"\brdi\b", r"\brbp\b", r"\brsp\b",
            r"\br8\b", r"\br9\b", r"\br10\b", r"\br11\b", r"\br12\b", r"\br13\b", r"\br14\b", r"\br15\b",
            r"\beax\b", r"\bebx\b", r"\becx\b", r"\bedx\b", r"\besi\b", r"\bedi\b", r"\bebp\b", r"\besp\b",
            r"\bqword\b", r"\bdword\b", r"\bword\b", r"\bbyte\b", r"\bptr\b"
        ]

        if self.language == "asm":
            for pattern in keywords_asm:
                self.highlighting_rules.append((QRegularExpression(pattern), keyword_format))
            for pattern in asm_regs:
                self.highlighting_rules.append((QRegularExpression(pattern), type_format))
        elif self.language in ["c", "cpp"]:
            for pattern in keywords_c:
                self.highlighting_rules.append((QRegularExpression(pattern), keyword_format))
        elif self.language == "python":
            for pattern in keywords_python:
                self.highlighting_rules.append((QRegularExpression(pattern), keyword_format))
        elif self.language in ["lisp", "lsp"]:
            for pattern in keywords_lisp:
                self.highlighting_rules.append((QRegularExpression(pattern), keyword_format))
        elif self.language in ["xml", "cui", "cuix"]:
            for pattern in keywords_xml:
                self.highlighting_rules.append((QRegularExpression(pattern), keyword_format))
        else:
            for pattern in keywords_csharp:
                self.highlighting_rules.append((QRegularExpression(pattern), keyword_format))

        # Chuỗi (Strings)
        string_format = QTextCharFormat()
        string_format.setForeground(QColor("#A31515"))
        self.highlighting_rules.append((QRegularExpression(r'".*?"'), string_format))
        self.highlighting_rules.append((QRegularExpression(r"'.*?'"), string_format))

        # Số Hex (0x...)
        num_format = QTextCharFormat()
        num_format.setForeground(QColor("#7C3AED"))
        self.highlighting_rules.append((QRegularExpression(r"\b0x[0-9a-fA-F]+\b"), num_format))

        # Chú thích (Comments)
        comment_format = QTextCharFormat()
        comment_format.setForeground(QColor("#008000"))
        self.highlighting_rules.append((QRegularExpression(r"//[^\n]*"), comment_format))
        self.highlighting_rules.append((QRegularExpression(r"#[^\n]*"), comment_format))
        self.highlighting_rules.append((QRegularExpression(r";[^\n]*"), comment_format))

    def highlightBlock(self, text):
        for pattern, fmt in self.highlighting_rules:
            match_iterator = pattern.globalMatch(text)
            while match_iterator.hasNext():
                match = match_iterator.next()
                self.setFormat(match.capturedStart(), match.capturedLength(), fmt)


class CodeViewerWidget(QWidget):
    """Widget hiển thị mã nguồn với font monospace và tô màu cú pháp."""

    def __init__(self, parent=None):
        super().__init__(parent)
        layout = QVBoxLayout(self)
        layout.setContentsMargins(0, 0, 0, 0)

        self.editor = QPlainTextEdit()
        self.editor.setReadOnly(True)
        self.editor.setFont(QFont("Consolas", 10))
        self.editor.setStyleSheet(
            """
            QPlainTextEdit {
                background-color: #FFFFFF;
                color: #1E293B;
                border: 1px solid #E2E8F0;
                border-radius: 4px;
                padding: 8px;
            }
            """
        )

        layout.addWidget(self.editor)
        self.highlighter = SimpleSyntaxHighlighter(self.editor.document(), "csharp")

    def set_code(self, code_text: str, language: str = "csharp"):
        self.editor.setPlainText(code_text)
        self.highlighter = SimpleSyntaxHighlighter(self.editor.document(), language)
        self.highlighter.rehighlight()

    def go_to_line(self, line_number: int):
        """Di chuyển con trỏ và cuộn tới dòng chỉ định (1-indexed)."""
        doc = self.editor.document()
        if line_number < 1 or line_number > doc.blockCount():
            return

        block = doc.findBlockByLineNumber(line_number - 1)
        cursor = self.editor.textCursor()
        cursor.setPosition(block.position())
        self.editor.setTextCursor(cursor)
        self.editor.centerCursor()

    def clear(self):
        self.editor.clear()
