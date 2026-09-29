$asmPath = "e:\code\tol\output\dumped_acad.exe_13008\Kata_pro64_Cad2013_de4dot.dll"
try {
    $asm = [System.Reflection.Assembly]::LoadFrom($asmPath)
    Write-Host "Assembly loaded: $($asm.FullName)"
    $type = $asm.GetType("kqfxbuDbydgG49beRnPM.b8ZYB8DbaTOhwfvx6YUN")
    if ($type) {
        Write-Host "Found string decrypter type: $($type.FullName)"
        $method = $type.GetMethod("QqFDbr6RL7F", [System.Reflection.BindingFlags]"Public,NonPublic,Static")
        if ($method) {
            Write-Host "Found QqFDbr6RL7F method!"
        }
    } else {
        Write-Host "Type not found by name, searching all types..."
        foreach ($t in $asm.GetTypes()) {
            foreach ($m in $t.GetMethods([System.Reflection.BindingFlags]"Public,NonPublic,Static")) {
                if ($m.Name -eq "QqFDbr6RL7F") {
                    Write-Host "Found in $($t.FullName)"
                }
            }
        }
    }
} catch {
    Write-Host "Error loading assembly: $($_.Exception.ToString())"
}
