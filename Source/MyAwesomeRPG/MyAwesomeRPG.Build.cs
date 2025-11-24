// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MyAwesomeRPG : ModuleRules
{
	public MyAwesomeRPG(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MyAwesomeRPG",
			"MyAwesomeRPG/Variant_Platforming",
			"MyAwesomeRPG/Variant_Platforming/Animation",
			"MyAwesomeRPG/Variant_Combat",
			"MyAwesomeRPG/Variant_Combat/AI",
			"MyAwesomeRPG/Variant_Combat/Animation",
			"MyAwesomeRPG/Variant_Combat/Gameplay",
			"MyAwesomeRPG/Variant_Combat/Interfaces",
			"MyAwesomeRPG/Variant_Combat/UI",
			"MyAwesomeRPG/Variant_SideScrolling",
			"MyAwesomeRPG/Variant_SideScrolling/AI",
			"MyAwesomeRPG/Variant_SideScrolling/Gameplay",
			"MyAwesomeRPG/Variant_SideScrolling/Interfaces",
			"MyAwesomeRPG/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
