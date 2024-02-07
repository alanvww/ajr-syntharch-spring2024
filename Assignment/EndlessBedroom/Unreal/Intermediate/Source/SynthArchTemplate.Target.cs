using UnrealBuildTool;

public class SynthArchTemplateTarget : TargetRules
{
	public SynthArchTemplateTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SynthArchTemplate");
	}
}
