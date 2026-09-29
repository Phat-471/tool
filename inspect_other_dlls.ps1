Add-Type -Path "e:\code\tol\tools\bin\dnlib.dll"

$dlls = @(
    "C:\kata_pro\kata_pro.dll",
    "C:\kata_pro\Kata_pro64.dll",
    "C:\kata_pro\Kata_Class_Lib.dll",
    "C:\kata_pro\Kata_pro64_Cad2025.dll"
)

foreach ($dll in $dlls) {
    Write-Host "=========================================="
    Write-Host "Assembly: $dll"
    try {
        $mod = [dnlib.DotNet.ModuleDefMD]::Load($dll)
        Write-Host "Target Framework: $($mod.RuntimeVersion)"
        Write-Host "Total Types: $($mod.Types.Count)"
        $nsList = $mod.Types | Select-Object -ExpandProperty Namespace -Unique
        Write-Host "Namespaces: $($nsList -join ', ')"
        
        # Check for licensing or web/api types
        $authTypes = $mod.Types | Where-Object { $_.FullName -match "License|Security|Auth|Register|Customer|Web|Api|Login" }
        Write-Host "License/Auth Types found: $($authTypes.Count)"
        foreach ($at in $authTypes | Select-Object -First 10) {
            Write-Host "  -> $($at.FullName)"
        }
    } catch {
        Write-Host "Error loading $dll : $_"
    }
}
