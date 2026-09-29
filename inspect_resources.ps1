Add-Type -Path "e:\code\tol\tools\bin\dnlib.dll"
$mod = [dnlib.DotNet.ModuleDefMD]::Load("e:\code\tol\output\dumped_acad.exe_13008\Kata_pro64_Cad2013.dll")
Write-Host "Resources in module:"
foreach ($r in $mod.Resources) {
    Write-Host " - $($r.Name) ($($r.ResourceType), Size=$($r.CreateStream().Length))"
    if ($r.Name -like "*WVdniYZV8e41O0qAYCZD*" -or $r.Name -like "*YBCSDyZVRqGQhBtF4YFw*") {
        $stream = $r.CreateStream()
        $buf = New-Object byte[] ($stream.Length)
        $stream.Read($buf, 0, $buf.Length) | Out-Null
        [System.IO.File]::WriteAllBytes("e:\code\tol\output\$($r.Name).bin", $buf)
        Write-Host "   Dumped to e:\code\tol\output\$($r.Name).bin"
    }
}
