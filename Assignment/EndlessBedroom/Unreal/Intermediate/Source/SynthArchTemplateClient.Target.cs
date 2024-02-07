using UnrealBuildTool;

public class SynthArchTemplateClientTarget : TargetRules
{
	public SynthArchTemplateClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SynthArchTemplate");
	}
}
