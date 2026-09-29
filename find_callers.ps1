Add-Type -Path "e:\code\tol\tools\bin\dnlib.dll"
$mod = [dnlib.DotNet.ModuleDefMD]::Load("e:\code\tol\output\dumped_acad.exe_13008\Kata_pro64_Cad2013_de4dot.dll")

Write-Host "Searching for callers of HcsT2GGo4ZG42Fo8iscq::wjxFYLRMFLK:"
foreach ($t in $mod.GetTypes()) {
    foreach ($m in $t.Methods) {
        if (-not $m.HasBody) { continue }
        foreach ($i in $m.Body.Instructions) {
            if ($i.Operand -ne $null -and $i.Operand.ToString() -like "*HcsT2GGo4ZG42Fo8iscq*") {
                Write-Host " -> $($t.FullName)::$($m.Name) at $($i.Offset): $($i.OpCode) $($i.Operand)"
            }
        }
    }
}
