// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class SteamAS : ModuleRules
{
	public SteamAS(ReadOnlyTargetRules Target) : base(Target)
	{
        // in the video he removes this because "he doesn't want shared headers" and says you can leave it in, but he removes it because
        // he had issues in the past with "it" randomly not finding includes anymore
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        // he replaces it with bFasterWithoutUnity = true; which, according his comment, speeds up build times by telling Unreal Build
        // Tools to not combine Source Files
        // https://answers.unrealengine.com/questions/3647/how-to-improve-compile-times-for-a-c-project.html?sort=oldest
        // this post explains it a bit better, and it does sound like a good idea to have it enabled
        bFasterWithoutUnity = true;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "OnlineSubsystem", "OnlineSubsystemUtils", "Steamworks" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
