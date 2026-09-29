Add-Type -Path "e:\code\tol\tools\bin\dnlib.dll"
$mod = [dnlib.DotNet.ModuleDefMD]::Load("e:\code\tol\dumps\acad_13008\Kata_pro64_Cad2013_de4dot.dll")

$typeStats = @{}

foreach ($t in $mod.GetTypes()) {
    $real = 0
    $stub = 0
    foreach ($m in $t.Methods) {
        if ($m.HasBody) {
            if ($m.Body.Instructions.Count -gt 3) {
                $real++
            } else {
                $stub++
            }
        }
    }
    if ($real -gt 0) {
        $ns = if ($t.Namespace) { $t.Namespace } else { "<global>" }
        if (-not $typeStats.ContainsKey($ns)) {
            $typeStats[$ns] = @{ Real = 0; Stub = 0; Types = 0 }
        }
        $typeStats[$ns].Real += $real
        $typeStats[$ns].Stub += $stub
        $typeStats[$ns].Types += 1
    }
}

Write-Host "Namespaces with Real Logic Methods:"
$typeStats.GetEnumerator() | Sort-Object { $_.Value.Real } -Descending | ForEach-Object {
    Write-Host ("{0,-35} | Types: {1,4} | Real: {2,5} | Stub: {3,5}" -f $_.Key, $_.Value.Types, $_.Value.Real, $_.Value.Stub)
}
