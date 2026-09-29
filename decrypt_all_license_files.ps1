Add-Type -AssemblyName System.Security

$entropyStr = "KataPro|LicenseV2|LocalMachine|2026"
$entropyUtf8 = [System.Text.Encoding]::UTF8.GetBytes($entropyStr)
$entropyUni = [System.Text.Encoding]::Unicode.GetBytes($entropyStr)

$files = @(
    "legacy-serial.dat",
    "legacy-identity.dat",
    "entitlement.dat",
    "device-key.dat",
    "usage-queue.dat"
)

foreach ($fn in $files) {
    $path = "C:\ProgramData\KataPro\SecurityV2\$fn"
    if (-not (Test-Path $path)) { continue }
    $b64 = [System.IO.File]::ReadAllText($path).Trim()
    $cipherBytes = [System.Convert]::FromBase64String($b64)
    
    $decrypted = $null
    foreach ($scope in @([System.Security.Cryptography.DataProtectionScope]::LocalMachine, [System.Security.Cryptography.DataProtectionScope]::CurrentUser)) {
        foreach ($ent in @($entropyUtf8, $entropyUni, $null)) {
            try {
                $dec = [System.Security.Cryptography.ProtectedData]::Unprotect($cipherBytes, $ent, $scope)
                $decrypted = [System.Text.Encoding]::UTF8.GetString($dec)
                Write-Host "✅ DECRYPTED $fn (Scope=$scope):"
                Write-Host $decrypted
                Write-Host "--------------------------------------------------"
                break
            } catch {}
        }
        if ($decrypted) { break }
    }
    if (-not $decrypted) {
        Write-Host "❌ Failed to decrypt $fn"
    }
}
