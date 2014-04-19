HaxeDx
======

A Haxe engine for building DirectX apps

Introduction
============

HaxeDx uses generated HaxeCS code to create DirectX applications, using the SharpDX library. This project is meant to be a proof of concept for possible integration into to LIME.

Requirements:
=============


* Haxe 3.1
* hxcs
* haxedx (should be available on haxelib shortly)
* Windows 8 Environment
* SharpDX which can be downloaded [here](http://sharpdx.org/download/). USE THE FULL INSTALLER
* Visual Studio for windows 2012+ or Visual Studio Ultimate 2012+


Usage:
======

* install using haxelib install haxedx
* create a project using haxelib run haxedx create this will create a project in the current working directory with a Main.hx app.xml and hxproj
* haxedx build app.xml winstore (currently only supports Windows Store target)
This will create a Windows Store Project with the available 

Current Capabilities:
=====================
* Compiles Haxe to C# and adds it to Visual Studio Project
 
Future Features:
================
* Externs for the complete SharpDX api
* Desktop target
* Mobile target
* Project Options in app.xml (Currently Does nothing)

