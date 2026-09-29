$asmPath = "e:\code\tol\output\dumped_acad.exe_13008\Kata_pro64_Cad2013_de4dot.dll"
$asm = [System.Reflection.Assembly]::LoadFrom($asmPath)

$types = @()
try {
    $types = $asm.GetTypes()
} catch [System.Reflection.ReflectionTypeLoadException] {
    $types = $_.Exception.Types | Where-Object { $_ -ne $null }
}

$modStructType = $null
foreach ($t in $types) {
    if ($t.Name -like "*b635f249*") {
        $modStructType = $t
        break
    }
}

if ($modStructType) {
    Write-Host "Found module type: $($modStructType.FullName)"
    [System.Runtime.CompilerServices.RuntimeHelpers]::RunClassConstructor($modStructType.TypeHandle)
    
    $field = $modStructType.GetField("m_912cff3b240844bd9c28972bf0084a9b", [System.Reflection.BindingFlags]"Public,NonPublic,Static")
    if ($field) {
        $inst = $field.GetValue($null)
        if ($inst) {
            Write-Host "Instance is initialized! Dumping first 20 fields:"
            $modStructType.GetFields([System.Reflection.BindingFlags]"Public,NonPublic,Instance") | Select-Object -First 20 | ForEach-Object {
                Write-Host "$($_.Name) = $($_.GetValue($inst))"
            }
        } else {
            Write-Host "Instance is null, trying d21c10d83a88d42bd94dfc3ea1e521440..."
            $initM = $modStructType.GetMethod("d21c10d83a88d42bd94dfc3ea1e521440", [System.Reflection.BindingFlags]"Public,NonPublic,Static")
            if ($initM) {
                try {
                    $initM.Invoke($null, @())
                    $inst = $field.GetValue($null)
                    Write-Host "After init, instance: $inst"
                    if ($inst) {
                        $modStructType.GetFields([System.Reflection.BindingFlags]"Public,NonPublic,Instance") | Select-Object -First 20 | ForEach-Object {
                            Write-Host "$($_.Name) = $($_.GetValue($inst))"
                        }
                    }
                } catch {
                    Write-Host "Init error: $($_.Exception.ToString())"
                }
            }
        }
    }
}
