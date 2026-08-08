// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UBIKEditor : ModuleRules
{
	public UBIKEditor(ReadOnlyTargetRules target) : base(target)
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

        PublicDependencyModuleNames.AddRange(["UBIKRuntime", "Core", "CoreUObject", "Engine", "InputCore"]);

        PrivateDependencyModuleNames.AddRange(["UnrealEd", "EditorStyle", "AnimGraph", "AnimGraphRuntime", "BlueprintGraph", "PropertyEditor", "Slate", "SlateCore"
        ]);
		
		DynamicallyLoadedModuleNames.AddRange(
			[
				// ... add any modules that your module loads dynamically here ...
			]
		);
	}
}
