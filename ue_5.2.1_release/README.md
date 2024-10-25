# Unreal Engine Packaging Fix for System.Drawing.Common Version Issue

## Issue Description
When packaging an Unreal Engine project, you may encounter a packaging failure related to the `System.Drawing.Common` dependency. 
This issue is due to an incompatible version specified in the Unreal Engine source code. This fix requires updating 
the `System.Drawing.Common` version from `4.7.0` to `4.7.2`.

## Steps to Fix

### 1. Locate and Modify Files
Navigate to the root directory of your Unreal Engine source code, typically located at:
```
Epic Games/UE_*version*/
```
The files listed below contain version references for `System.Drawing.Common`. You will need to search for the following line:

```xml
<PackageReference Include="System.Drawing.Common" Version="4.7.0" />
```

Update this line to:
```xml
<PackageReference Include="System.Drawing.Common" Version="4.7.2" />
```

### 2. Files to Modify

#### Mandatory Files
The following files **must** be modified:
- `/Engine/Source/Programs/AutomationTool/BuildGraph/BuildGraph.Automation.csproj`
- `/Engine/Source/Programs/AutomationTool/Scripts/AutomationScripts.Automation.csproj`
- `/Engine/Source/Programs/AutomationTool/AutomationUtils/AutomationUtils.Automation.csproj`

#### Platform-Specific Files
Depending on your target platform, modify only the files relevant to your project. This may not require modifying all of these files.
- `/Engine/Source/Programs/AutomationTool/IOS/IOS.Automation.csproj`
- `/Engine/Source/Programs/AutomationTool/Linux/Linux.Automation.csproj`
- `/Engine/Source/Programs/AutomationTool/Mac/Mac.Automation.csproj`
- `/Engine/Source/Programs/AutomationTool/SteamDeck/SteamDeck.Automation.csproj`
- `/Engine/Source/Programs/AutomationTool/TurnKey/TurnKey.Automation.csproj`
- `/Engine/Source/Programs/AutomationTool/TVOS/TVOS.Automation.csproj`
- `/Engine/Source/Programs/AutomationTool/Win/Win.Automation.csproj`

### 3. Recompile the Project
After modifying the files, recompile the project by opening the `.uproject` file in the Unreal Engine editor or by 
running the `RunUAT` file.

## Conclusion
After recompiling, the packaging process should complete successfully. This resolves the versioning issue with 
`System.Drawing.Common`.

# Fixing Vulnerability in MongoDB.Driver Dependency

## Issue Overview

A vulnerability has been identified in specific versions of `MongoDB.Driver`, as outlined in [GitHub Security Advisory GHSA-7j9m-j397-g4wx](https://github.com/advisories/GHSA-7j9m-j397-g4wx). This vulnerability may expose your application to security risks and should be addressed promptly.

## Fixing the Issue

The recommended fix involves updating the `MongoDB.Driver` dependency to version `2.19.0`. Follow the steps below to locate and modify the affected version in your project.

### Step 1: Update the Version

1. Open your project file (`.csproj` or equivalent configuration file where dependencies are specified).
2. Search for the following line or similar lines specifying `MongoDB.Driver`:
3. Replace the existing version number with `2.19.0` to secure your project from this vulnerability. Update the line as follows:
```xml
<PackageReference Include="MongoDB.Driver" Version="2.19.0" />
```

### Step 2: Save

After modifying the dependency version:
1. Save the changes to your project file.

---

**Note:** Always ensure to back up files before making any modifications to the Unreal Engine source code.
