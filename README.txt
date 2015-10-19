HOW TO USE THIS MODULE IN UNREAL ENGINE 

1. Add this module's root directory (should be called GENERIC_MODULE) to your project's Source directory (should be Project_Name/Source).
	- if you can't find the Source directory, it could be that you did not generate this project as a C++ Unreal project. If you can, generate a new project and, in Unreal's create new project page, switch to the C++ tab. Then create your project normally. 

2. Open up your GENERIC_MODULE.Build.cs file within this directory and follow the todo list steps at the top of the file

3. Open up your GENERIC_MODULE.h file within the Public subdirectory of this directory, and follow the todo list steps at the top of the file

4. Open up your GENERIC_MODULE.cpp file within the Public subdirectory of this directory, and follow the todo list steps at the top of the file

5. Modify Project_Name.Target.cs located in the project's Source directory. You'll see a snippet of code that looks like this:
	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "Project_Name" } );
	}

	You want to add YOUR_MODULE_NAME to the OutExtraModuleNames argument. When you're done it should look something like this:
		public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "Project_Name", "YOUR_MODULE_NAME" } );
	}


6. Repeat step 5 but for the file Project_NameEditor.Target.cs. The files should look exactly the same, and the modification you perform is also exactly the same. 


7. Lastly, open up Project_name.uproject with a text editor and change it to something like this:
{
	"FileVersion": 3,
	"EngineAssociation": "4.9",
	"Category": "",
	"Description": "",
	"Modules": [
		{
			"Name": "Project_Name",
			"Type": "Runtime",
			"LoadingPhase": "Default"
		},
        {
            "Name": "YOUR_MODULE_NAME",
            "Type": "Runtime",
            "LoadingPhase": "Default"
        }
	]
}

Your goal is to tell unreal that a Runtime module exists called YOUR_MODULE_NAME, and it should be loaded in the Default manner. 


8. Compile the project and run unreal engine. 

9. Each time you want to add code to your project, you can do so manually, or within Unreal you can do File > New C++ Class. I reccommend you go the Unreal route if you want your class to depend on any of Unreal Engine's default classes (such as AActor of BlueprintFunctionLibrary). Otherwise, if you're building a standalone class that doesn't depend on anything, either method works (to add manually, simply add the .h file to your module's Public subdirectory, add the .cpp file to your module's Private subdirectory, and within your new .h file include YOUR_MODULE_NAME.h).