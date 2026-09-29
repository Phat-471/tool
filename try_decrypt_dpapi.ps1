Add-Type -AssemblyName System.Security

$path = "C:\ProgramData\KataPro\SecurityV2\legacy-serial.dat"
$b64 = [System.IO.File]::ReadAllText($path).Trim()
$cipherBytes = [System.Convert]::FromBase64String($b64)

$candidates = @(
    "KATA_PRO@19870819",
    "KATA_PRO",
    "19870819",
    "kata_cad",
    "10ba798875de4fd08b3ff2f2ef190c94",
    "kata-cad",
    "ZeroCool",
    "KataPro_2026",
    "KataLicenseV2"
)

$scopes = @(
    [System.Security.Cryptography.DataProtectionScope]::CurrentUser,
    [System.Security.Cryptography.DataProtectionScope]::LocalMachine
)

foreach ($scope in $scopes) {
    foreach ($cand in $candidates) {
        $entropyUtf8 = [System.Text.Encoding]::UTF8.GetBytes($cand)
        $entropyUni = [System.Text.Encoding]::Unicode.GetBytes($cand)
        
        try {
            $dec = [System.Security.Cryptography.ProtectedData]::Unprotect($cipherBytes, $entropyUtf8, $scope)
            Write-Host "FOUND MATCH with UTF8: '$cand' (Scope: $scope)"
            Write-Host "Decrypted: $([System.Text.Encoding]::UTF8.GetString($dec))"
            exit 0
        } catch {}

        try {
            $dec = [System.Security.Cryptography.ProtectedData]::Unprotect($cipherBytes, $entropyUni, $scope)
            Write-Host "FOUND MATCH with Unicode: '$cand' (Scope: $scope)"
            Write-Host "Decrypted: $([System.Text.Encoding]::UTF8.GetString($dec))"
            exit 0
        } catch {}
    }
}

Write-Host "No match found among tested candidates."
