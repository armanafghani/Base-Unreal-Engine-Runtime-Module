// Fill out your copyright notice in the Description page of Project Settings.



//TODO FOR THIS FILE
// * rename this file to YOUR_MODULE_NAME.Build.cs
// * change line 19 to be public class YOUR_MODULE_NAME : ModuleRules
    // * this class that you just declared tells Unreal all of the build rules for your modules
// * change line 21 to be public YOUR_MODULE_NAME(TargetInfo Target)
    // * this function is your module rules initializer
// * change lines 24 and 25 to match the correct directory structure (so "YOUR_MODULE_NAME/Public and /Private")
//  * POSSIBLE AREA FOR FUCK UP: make sure you change the directory names in your computer's file system as well, or else the build tool will not be able to find those directories




using UnrealBuildTool;

public class GENERIC_MODULE : ModuleRules
{
    public GENERIC_MODULE(TargetInfo Target)
	{

        PublicIncludePaths.AddRange(new string[] { "GENERIC_MODULE/Public" });
        PrivateIncludePaths.AddRange(new string[] { "GENERIC_MODULE/Private" });

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");
		// if ((Target.Platform == UnrealTargetPlatform.Win32) || (Target.Platform == UnrealTargetPlatform.Win64))
		// {
		//		if (UEBuildConfiguration.bCompileSteamOSS == true)
		//		{
		//			DynamicallyLoadedModuleNames.Add("OnlineSubsystemSteam");
		//		}
		// }
	}
}


		// }
