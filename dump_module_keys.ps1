$origPath = "C:\kata_pro\Kata_pro64_Cad2013.dll"
$bytes = [System.IO.File]::ReadAllBytes($origPath)
$asm = [System.Reflection.Assembly]::Load($bytes)

$types = @()
try {
    $types = $asm.GetTypes()
} catch [System.Reflection.ReflectionTypeLoadException] {
    $types = $_.Exception.Types | Where-Object { $_ -ne $null }
}

$modType = $null
foreach ($t in $types) {
    if ($t.Name -like "*b635f249*") {
        $modType = $t
        break
    }
}

if ($modType) {
    Write-Host "Found module type: $($modType.FullName)"
    [System.Runtime.CompilerServices.RuntimeHelpers]::RunClassConstructor($modType.TypeHandle)
    $field = $modType.GetField("m_912cff3b240844bd9c28972bf0084a9b", [System.Reflection.BindingFlags]"Public,NonPublic,Static")
    if ($field) {
        $inst = $field.GetValue($null)
        Write-Host "Instance is: $inst"
        if ($inst) {
            $dict = @{}
            foreach ($f in $modType.GetFields([System.Reflection.BindingFlags]"Public,NonPublic,Instance")) {
                $val = $f.GetValue($inst)
                $dict[$f.Name] = $val
            }
            Write-Host "Total fields extracted: $($dict.Count)"
            $json = $dict | ConvertTo-Json
            [System.IO.File]::WriteAllText("output/module_fields_key.json", $json)
            Write-Host "Saved to output/module_fields_key.json"
        }
    }
}
