$origPath = "C:\kata_pro\Kata_pro64_Cad2013.dll"
$bytes = [System.IO.File]::ReadAllBytes($origPath)
$asm = [System.Reflection.Assembly]::Load($bytes)
$t = $asm.GetType("kqfxbuDbydgG49beRnPM.b8ZYB8DbaTOhwfvx6YUN")
[System.Runtime.CompilerServices.RuntimeHelpers]::RunClassConstructor($t.TypeHandle)
$m = $t.GetMethod("QqFDbr6RL7F", [System.Reflection.BindingFlags]"Public,NonPublic,Static")

# Trigger decryption of the string resource
$null = $m.Invoke($null, @([int]0))

# Get the decrypted byte array OaqDVNb9oCk
$f = $t.GetField("OaqDVNb9oCk", [System.Reflection.BindingFlags]"Public,NonPublic,Static")
$arr = $f.GetValue($null)
Write-Host "Decrypted string pool byte length: $($arr.Length)"

# Dump decrypted bytes to file for offline reuse!
[System.IO.File]::WriteAllBytes("output/decrypted_string_pool.bin", $arr)
Write-Host "Saved to output/decrypted_string_pool.bin"
