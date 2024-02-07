using UnrealBuildTool;

public class SynthArchTemplateServerTarget : TargetRules
{
	public SynthArchTemplateServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SynthArchTemplate");
	}
}
