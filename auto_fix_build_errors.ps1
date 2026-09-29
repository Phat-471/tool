// AutoFixBuildErrors.ps1 - tự động sửa các lỗi biên dịch phổ biến trong dự án Kata_pro64_Cad2013_clean_source

$sourceRoot = "e:/code/tol/output/Kata_pro64_Cad2013_clean_source/Kata_pro64_Cad2013"

# 1. Sửa CommandMethodAttribute thiếu tham số – chèn tên phương thức vào attribute
Get-ChildItem -Path $sourceRoot -Recurse -Filter "*.cs" | ForEach-Object {
    $path = $_.FullName
    $content = Get-Content $path -Raw
    # Replace pattern: [CommandMethod]\n    public void MethodName ...
    $pattern = "(?ms)\[CommandMethod\]\s*\r?\n\s*public\s+void\s+(\w+)"
    $newContent = [regex]::Replace($content, $pattern, { param($m) "[CommandMethod(`"$($m.Groups[1].Value)`")]`n    public void $($m.Groups[1].Value)" })
    if ($newContent -ne $content) {
        Set-Content -Path $path -Value $newContent -Encoding UTF8
        Write-Host "Fixed CommandMethod in $($_.Name)"
    }
}

# 2. Đổi private virtual -> public virtual cho các thành viên bị lỗi CS0621
Get-ChildItem -Path $sourceRoot -Recurse -Filter "*.cs" | ForEach-Object {
    $path = $_.FullName
    $content = Get-Content $path -Raw
    $newContent = $content -replace "private virtual", "public virtual"
    if ($newContent -ne $content) {
        Set-Content -Path $path -Value $newContent -Encoding UTF8
        Write-Host "Made virtual members public in $($_.Name)"
    }
}

# 3. Giải quyết xung đột Polyline (chỉ giữ DatabaseServices)
Get-ChildItem -Path $sourceRoot -Recurse -Filter "*.cs" | ForEach-Object {
    $path = $_.FullName
    $content = Get-Content $path -Raw
    $newContent = $content -replace "\bPolyline\b", "Autodesk.AutoCAD.DatabaseServices.Polyline"
    if ($newContent -ne $content) {
        Set-Content -Path $path -Value $newContent -Encoding UTF8
        Write-Host "Disambiguated Polyline in $($_.Name)"
    }
}

# 4. Đổi default value của tham số kiểu object thành null
Get-ChildItem -Path $sourceRoot -Recurse -Filter "*.cs" | ForEach-Object {
    $path = $_.FullName
    $content = Get-Content $path -Raw
    $newContent = $content -replace "(object\s+\w+\s*=)\s*[^,\)]+", "`$1 null"
    if ($newContent -ne $content) {
        Set-Content -Path $path -Value $newContent -Encoding UTF8
        Write-Host "Set object defaults to null in $($_.Name)"
    }
}

# 5. Sửa lớp HDDSerial trùng tên thành HDDSerialHelper
Get-ChildItem -Path $sourceRoot -Recurse -Filter "HDDSerial.cs" | ForEach-Object {
    $path = $_.FullName
    $content = Get-Content $path -Raw
    $newContent = $content -replace "class HDDSerial", "class HDDSerialHelper"
    # Update any internal references to the class name within the same file
    $newContent = $newContent -replace "\bHDDSerial\b", "HDDSerialHelper"
    Set-Content -Path $path -Value $newContent -Encoding UTF8
    Write-Host "Renamed HDDSerial class to HDDSerialHelper in $($_.Name)"
}

Write-Host "Auto-fix completed."
