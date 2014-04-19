package ;


import neko.Lib;
import sys.io.Process;
import xa.File;
import xa.filters.ExtensionFilter;
import xa.System;

import sys.FileSystem;
import xa.Filter;
import xa.Folder;
import xa.Search;
/**
 * ...
 * @author VentroyRolle
 */

class Main 
{
	static var version:String = "0.1.0";
	static var execPath:String;
	static function main() 
	{
		//Parse Parameters
		var args:Array<String> = Sys.args();
		if (args.length < 1) {
			showOptions();
			
		}else {
			execPath = Sys.getCwd();
			Sys.setCwd(args[args.length - 1]);
		}
		
		for (i in 0... args.length) {
			
			var arg:String = args[i].toLowerCase();
			switch(arg) {
				case "help":
					showOptions();
				case "create":
					createProject();
				case "build":
					buildProject(args[i + 1], args[i+2]);
					
				
			}
			
		}
		
		
	}
	// Menu
	static function showOptions():Void {
		Lib.println("O))     O))                             O)))))             
O))     O))                             O))   O))          
O))     O))   O))    O))   O))   O))    O))    O))O))   O))
O)))))) O)) O))  O))   O) O))  O)   O)) O))    O))  O) O)) 
O))     O))O))   O))    O)    O))))) O))O))    O))   O)    
O))     O))O))   O))  O)  O)) O)        O))   O))  O)  O)) 
O))     O))  O)) O)))O))   O))  O))))   O)))))    O))   O))
                                                           ");
		Lib.println("Ver " + version);
		Lib.println("Commandline tools createing and building DirectX apps in haxe\n");
		Lib.println("Commands");
		Lib.println("     create: creates a HaxeDx project complete with template files");
		Lib.println("     build: build a HaxeDx project given a valid app.xml file, and a target");
	}
	//Copies the project template to the given folder
	static function createProject():Void 
	{
		Folder.copy(execPath + "templates\\hxproj", Sys.getCwd());
	}
	/*
	 * Builds the project.... kind of 
	 * */
	static function buildProject(projectXmlPath:String, target:String):Void {
		//Checks for a project.xml file
		//Doesnt read it yet though 
		if (projectXmlPath == null || !FileSystem.exists(projectXmlPath)) {
			Lib.println("Please provide a valid app.xml file");
			return;
		}
		if (target == null) {
			Lib.println("Please Enter A given target");
			return;
		}else {
			switch(target) {
				case "winstore":
					buildWinStore();
				case "desktop":
					Lib.println("unimplemented Target");
					return;
				case "mobile":
					Lib.println("unimplemented Target");
				default:
					Lib.println("Unknown Target");
					return;	
			}	
		}
	}
	static function buildWinStore():Void {
		
		if (!Folder.isFolder(Sys.getCwd() + "bin\\winstore")) {
			Folder.copy(execPath + "templates\\winstore", Sys.getCwd() + "bin\\winstore");
		}
		// Compile Main.hx and place the cs classes in the app source folder
		Sys.command("haxe -main Main.hx -cs bin\\winstore\\AppSource -D no-compilation -D no-root");
		
		
		//Add all the generated cs classes to the .csproj file
		var csprojData = File.read(Sys.getCwd() + "bin\\winstore\\AppSource\\AppSource.csproj");
		
		csprojData = StringTools.replace(csprojData, "<!--HXCSCLASSES-->", getIncludeCSTags());
		
		File.write(Sys.getCwd() + "bin\\winstore\\AppSource\\AppSource.csproj", csprojData);
		
		//Replace required files from cs_template to AppSource (modern UI runtime not 100% compatible with the .NET ones)
		rewriteFile(Sys.getCwd() + "bin\\winstore\\AppSource\\src\\Type.cs", File.read(execPath + "templates\\cs_templates\\Type.cs")); 
		rewriteFile(Sys.getCwd() + "bin\\winstore\\AppSource\\src\\cs\\Lib.cs", File.read(execPath + "templates\\cs_templates\\cs\\Lib.cs")); 
		rewriteFile(Sys.getCwd() + "bin\\winstore\\AppSource\\src\\cs\\internal\\Exception.cs", File.read(execPath + "templates\\cs_templates\\internal\\Exception.cs")); 
		
	}
	static function getIncludeCSTags():String {
		var tags:String = "";
		var csPaths:Array<String> = Search.search(Sys.getCwd() + "bin\\winstore\\AppSource", new ExtensionFilter(["cs"],true));
		
		
		for (path in csPaths) {
			var relativePath:String = StringTools.replace(path,Sys.getCwd() + "bin\\winstore\\AppSource\\","");
			if (relativePath.indexOf(".cs") < 0 || relativePath.indexOf("Properties\\AssemblyInfo") > 0) {
				continue;
			}
			tags += "<Compile Include = \"" + relativePath + "\" />\n\t"; 
			
		}
		return tags;
	}
	static function rewriteFile(filePath:String, content:String):Void {
		if (FileSystem.exists(filePath)) {
			File.write(filePath, content);
		}else {
			File.append(filePath, content);
		}
	}
	
	
}