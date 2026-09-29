Add-Type -Path "e:\code\tol\tools\bin\dnlib.dll"
$mod = [dnlib.DotNet.ModuleDefMD]::Load("e:\code\tol\dumps\acad_13008\Kata_pro64_Cad2013_de4dot.dll")

$globalTypes = $mod.GetTypes() | Where-Object { [string]::IsNullOrEmpty($_.Namespace) }
Write-Host "Total global types:" $globalTypes.Count

$realGlobals = @()
foreach ($t in $globalTypes) {
    $real = 0
    foreach ($m in $t.Methods) {
        if ($m.HasBody -and $m.Body.Instructions.Count -gt 3) {
            $real++
        }
    }
    if ($real -gt 0) {
        $realGlobals += [PSCustomObject]@{
            Name = $t.Name
            Real = $real
            Methods = $t.Methods.Count
        }
    }
}

Write-Host "Global types with real methods:" $realGlobals.Count
Write-Host "`nTop 30 Global types by real methods:"
$realGlobals | Sort-Object Real -Descending | Select-Object -First 30 | ForEach-Object {
    Write-Host ("{0,-30} | Real: {1,4} / {2,4}" -f $_.Name, $_.Real, $_.Methods)
}
