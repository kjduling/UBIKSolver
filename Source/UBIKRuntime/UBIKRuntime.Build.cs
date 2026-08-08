// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UBIKRuntime : ModuleRules
{
	public UBIKRuntime(ReadOnlyTargetRules target) : base(target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			[
				// ... add public include paths required here ...
			]
		);
				
		
		PrivateIncludePaths.AddRange(
			[
				// ... add other private include paths required here ...
			]
		);


        PublicDependencyModuleNames.AddRange(["Core", "CoreUObject", "Engine", "InputCore", "AnimGraphRuntime", "AnimationCore"
        ]);

        PrivateDependencyModuleNames.AddRange(["Slate", "SlateCore", "Projects", "XRBase", "HeadMountedDisplay"]);

        DynamicallyLoadedModuleNames.AddRange(
	        [
		        // ... add any modules that your module loads dynamically here ...
	        ]
        );
	}
}
