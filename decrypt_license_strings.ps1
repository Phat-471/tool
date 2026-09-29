$asmPath = "e:\code\tol\output\dumped_acad.exe_13008\Kata_pro64_Cad2013_de4dot.dll"
$asm = [System.Reflection.Assembly]::LoadFrom($asmPath)
$type = $asm.GetType("kqfxbuDbydgG49beRnPM.b8ZYB8DbaTOhwfvx6YUN")
$m = $type.GetMethod("QqFDbr6RL7F", [System.Reflection.BindingFlags]"Public,NonPublic,Static")

# Let's find the XOR key from <Module>
$modType = $asm.GetType("<Module>")
$fields = $modType.GetFields([System.Reflection.BindingFlags]"Public,NonPublic,Static")
Write-Host "Fields in <Module>: $($fields.Count)"

# Let's test calling QqFDbr6RL7F with some known IDs or brute forcing the range [0..2000]
$foundStrings = @{}
for ($i = 0; $i -lt 1500; $i++) {
    try {
        $str = $m.Invoke($null, @([int]$i))
        if (-not [string]::IsNullOrEmpty($str) -and $str.Length -gt 1) {
            $foundStrings[$i] = $str
            if ($str -match "http|kata|license|api|key|seat|boot|cad|programdata" -or $str.Length -gt 15) {
                Write-Host "ID $i => $str"
            }
        }
    } catch {
        # ignore invalid id
    }
}

Write-Host "Total strings decrypted: $($foundStrings.Count)"
