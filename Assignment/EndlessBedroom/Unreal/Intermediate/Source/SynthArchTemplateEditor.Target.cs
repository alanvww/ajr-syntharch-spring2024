using UnrealBuildTool;

public class SynthArchTemplateEditorTarget : TargetRules
{
	public SynthArchTemplateEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SynthArchTemplate");
	}
}
