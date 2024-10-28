using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class GameLiftServerTarget : TargetRules
{
    public GameLiftServerTarget(TargetInfo Target) : base(Target)
    {
   	 Type = TargetType.Server;
   	 DefaultBuildSettings = BuildSettingsVersion.V2;
   	 IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
   	 ExtraModuleNames.Add("GameLift");
    }
}
