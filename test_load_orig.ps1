$origPath = "C:\kata_pro\Kata_pro64_Cad2013.dll"
try {
    $bytes = [System.IO.File]::ReadAllBytes($origPath)
    $asm = [System.Reflection.Assembly]::Load($bytes)
    Write-Host "Loaded assembly: $($asm.FullName)"
    
    $t = $asm.GetType("kqfxbuDbydgG49beRnPM.b8ZYB8DbaTOhwfvx6YUN")
    if ($t) {
        Write-Host "Found decrypter type: $($t.FullName)"
        # Run .cctor
        [System.Runtime.CompilerServices.RuntimeHelpers]::RunClassConstructor($t.TypeHandle)
        Write-Host "Class constructor completed successfully!"
        
        $m = $t.GetMethod("QqFDbr6RL7F", [System.Reflection.BindingFlags]"Public,NonPublic,Static")
        if ($m) {
            Write-Host "Calling QqFDbr6RL7F(0)..."
            $res = $m.Invoke($null, @([int]0))
            Write-Host "Result for 0: '$res'"
        }
    }
} catch {
    Write-Host "Error: $($_.Exception.ToString())"
    if ($_.Exception.InnerException) {
        Write-Host "Inner: $($_.Exception.InnerException.ToString())"
    }
}
