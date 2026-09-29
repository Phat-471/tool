Add-Type -Path "e:\code\tol\tools\bin\dnlib.dll"
$mod = [dnlib.DotNet.ModuleDefMD]::Load("e:\code\tol\output\dumped_acad.exe_13008\Kata_pro64_Cad2013_de4dot.dll")

Write-Host "Searching for fields of type HcsT2GGo4ZG42Fo8iscq (WebRequest.Create):"
foreach ($t in $mod.GetTypes()) {
    foreach ($f in $t.Fields) {
        if ($f.FieldType.FullName -like "*HcsT2GGo4ZG42Fo8iscq*") {
            Write-Host " -> Field in $($t.FullName): $($f.Name)"
        }
    }
}

Write-Host "`nSearching for types referencing System.Net or WebRequest:"
foreach ($t in $mod.GetTypes()) {
    foreach ($m in $t.Methods) {
        if (-not $m.HasBody) { continue }
        foreach ($i in $m.Body.Instructions) {
            if ($i.Operand -ne $null -and $i.Operand.ToString() -like "*WebRequest*") {
                Write-Host " -> Instruction in $($t.FullName)::$($m.Name): $($i.OpCode) $($i.Operand)"
            }
        }
    }
}
