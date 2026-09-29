Add-Type -Path "e:\code\tol\tools\bin\dnlib.dll"
$mod = [dnlib.DotNet.ModuleDefMD]::Load("e:\code\tol\dumps\acad_13008\Kata_pro64_Cad2013.dll")
Write-Host "Resources in module:"
foreach ($r in $mod.Resources) {
    $len = if ($r -is [dnlib.DotNet.EmbeddedResource]) { $r.Data.Length } else { -1 }
    Write-Host (" - {0,-50} | Size: {1,10} bytes" -f $r.Name, $len)
}
