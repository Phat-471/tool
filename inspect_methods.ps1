Add-Type -Path "e:\code\tol\tools\bin\dnlib.dll"
$mod = [dnlib.DotNet.ModuleDefMD]::Load("e:\code\tol\output\dumped_acad.exe_13008\Kata_pro64_Cad2013_de4dot.dll")
$t = $mod.Find("Kata_pro64_Cad2013.KataLicenseV2", $true)
$m = $t.FindMethod("CheckForCommand")
Write-Host "Instructions for CheckForCommand in de4dot.dll:"
foreach ($instr in $m.Body.Instructions) {
    Write-Host "$($instr.OpCode) $($instr.Operand)"
}

$origMod = [dnlib.DotNet.ModuleDefMD]::Load("e:\code\tol\output\dumped_acad.exe_13008\Kata_pro64_Cad2013.dll")
$origT = $origMod.Find("Kata_pro64_Cad2013.KataLicenseV2", $true)
$origM = $origT.FindMethod("CheckForCommand")
Write-Host "Instructions for CheckForCommand in dumped original dll:"
foreach ($instr in $origM.Body.Instructions) {
    Write-Host "$($instr.OpCode) $($instr.Operand)"
}
