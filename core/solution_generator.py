import os
import uuid
from pathlib import Path
from typing import Optional

class SolutionGenerator:
    """Tự động tạo file Visual Studio Solution (.sln) cho các project .csproj."""

    CSHARP_PROJECT_TYPE_GUID = "{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}"

    @classmethod
    def generate_solution_for_directory(cls, directory_path: str) -> Optional[str]:
        """
        Tìm kiếm tất cả file .csproj trong thư mục và tạo file .sln tương ứng.
        
        Trả về:
            str: Đường dẫn file .sln đã tạo, hoặc None nếu không có file .csproj.
        """
        dir_p = Path(directory_path)
        if not dir_p.exists():
            return None

        csproj_files = list(dir_p.glob("*.csproj"))
        if not csproj_files:
            return None

        primary_csproj = csproj_files[0]
        project_name = primary_csproj.stem
        sln_path = dir_p / f"{project_name}.sln"

        project_guid = f"{{{str(uuid.uuid4()).upper()}}}"

        sln_content = f"""Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.0.31903.59
MinimumVisualStudioVersion = 10.0.40219.1
Project("{cls.CSHARP_PROJECT_TYPE_GUID}") = "{project_name}", "{primary_csproj.name}", "{project_guid}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{project_guid}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{project_guid}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{project_guid}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{project_guid}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal
"""
        with open(sln_path, "w", encoding="utf-8") as f:
            f.write(sln_content)

        return str(sln_path.resolve())
