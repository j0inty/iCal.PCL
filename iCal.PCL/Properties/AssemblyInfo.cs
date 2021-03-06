﻿using System.Reflection;
using System.Resources;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("iCal.PCL")]
[assembly: AssemblyDescription("Light weight and very simple iCal parser. Parses only VEVENT objects.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Gordon Watts")]
[assembly: AssemblyProduct("iCal.PCL")]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.4.0")]
[assembly: AssemblyFileVersion("1.0.4.0")]

// Allow testing of some internals, which
// just makes tests and authoring easier.
#if DEBUG
[assembly: InternalsVisibleTo("iCal.PCL.Test")]
#endif