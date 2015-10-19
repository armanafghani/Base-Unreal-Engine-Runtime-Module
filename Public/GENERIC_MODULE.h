// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "Engine.h"

/* 
 
 TODO FOR THIS FILE
    * rename this file to YOUR_MODULE_NAME.h
    * change the name of class FGenericModule to class FYourModuleName
        * IMPORTANT: Unreal is dumb and requres you to start the module's class name with the letter F. It literally will not compile otherwise.
        * IMPORTANT: do not remove the ' : public IModuleInterface'
            * Unreal uses this to generate your source code as an Unreal Module. If you remove it, your module will not compile.
    * If you want to implement C++ code in this module (which obviously I'm guessing you do), add each C++ class as additional .h and .cpp files in this module's directory. Add all .h files in the Public folder, and add all .cpp files in the Private folder. 
        * EASY TO FUCK UP AREA: make sure you stick a #include "YOUR_MODULE_NAME.h" at the top of all of the .h files you create. 
         * EASY TO FUCK UP AREA: If C++ code you add depends on another module, make sure you 1. add that module as a public dependency in line 13 of YOUR_MODULE_NAME.Build.cs, located in this module's root directory, and 2. add the proper #includes in the .h file of the class that uses those outside modules. 
            * NOTE: notice how you didn't have to include the primary module for this project (should be the module called YOUR_PROJECT_NAME). This is because as of right now, this module doesn't depend on any code within that module. If you end up writing code in that module that needs to be used in this one, then you'll have to include that module at the top of this .h file, and you'll have to add YOUR_PROJECT_NAME as a public dependency in line 13 of YOUR_MODULE_NAME.Build.cs.
 
 */

class FGenericModule : public IModuleInterface {

};

