Add-Type -Path "e:\code\tol\tools\bin\dnlib.dll"
$mod = [dnlib.DotNet.ModuleDefMD]::Load("e:\code\tol\output\dumped_acad.exe_13008\Kata_pro64_Cad2013.dll")

$largeMethods = @()
$nopMethods = 0

foreach ($type in $mod.GetTypes()) {
    foreach ($m in $type.Methods) {
        if (-not $m.HasBody) { continue }
        $cnt = $m.Body.Instructions.Count
        # Check if it's just nop nop ret
        $isNopOnly = $true
        foreach ($i in $m.Body.Instructions) {
            if ($i.OpCode -notin @([dnlib.DotNet.Emit.OpCodes]::Nop, [dnlib.DotNet.Emit.OpCodes]::Ret, [dnlib.DotNet.Emit.OpCodes]::Ldnull, [dnlib.DotNet.Emit.OpCodes]::Ldc_I4_1, [dnlib.DotNet.Emit.OpCodes]::Ldc_I4_0, [dnlib.DotNet.Emit.OpCodes]::Unbox_Any)) {
                $isNopOnly = $false
                break
            }
        }
        if ($isNopOnly) {
            $nopMethods++
        } else {
            $largeMethods += [PSCustomObject]@{
                Type = $type.FullName
                Method = $m.Name
                Count = $cnt
            }
        }
    }
}

Write-Host "Nop/Stub methods: $nopMethods"
Write-Host "Real logic methods: $($largeMethods.Count)"
Write-Host "`nTop 20 largest real methods:"
$largeMethods | Sort-Object Count -Descending | Select-Object -First 20 | ForEach-Object {
    Write-Host "$($_.Count) instrs: $($_.Type)::$($_.Method)"
}
