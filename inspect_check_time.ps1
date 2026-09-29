Add-Type -Path "e:\code\tol\tools\bin\dnlib.dll"
$mod = [dnlib.DotNet.ModuleDefMD]::Load("e:\code\tol\output\dumped_acad.exe_13008\Kata_pro64_Cad2013.dll")
$t = $mod.Find("Kata_pro64_Cad2013.Check_time_run", $true)
Write-Host "Methods of Check_time_run:"
foreach ($m in $t.Methods) {
    $cnt = if ($m.HasBody) { $m.Body.Instructions.Count } else { 0 }
    Write-Host "$($m.Name) | Instructions=$cnt"
    if ($cnt -gt 3 -and $cnt -lt 30) {
        foreach ($i in $m.Body.Instructions) {
            Write-Host "   $($i.OpCode) $($i.Operand)"
        }
    }
}

$t2 = $mod.Find("Kata_pro64_Cad2013.Customer", $true)
Write-Host "`nSample methods of Customer:"
$count = 0
foreach ($m in $t2.Methods) {
    $cnt = if ($m.HasBody) { $m.Body.Instructions.Count } else { 0 }
    if ($cnt -gt 3) {
        Write-Host "$($m.Name) | Instructions=$cnt"
        $count++
        if ($count -ge 5) { break }
    }
}
