// WinForm Markup Generator
// Created by: LITTOMA
// Usage: wmgen.exe [input file].dll [output file].cs
// Description: This program generates a C# source file that creates a WinForm
//              window with all the controls and properties set to the values
//              specified in the input file. The input file is a .NET assembly
//              that contains a class with the [Markup] attribute. The class
//              must have a public static method called Generate that returns
//              a Form object. The output file is a C# source file that contains
//              the generated code.

using System;
using System.IO;
using System.Reflection;

using WinFormsMarkupGenerator;

if (args.Length != 2)
{
    Console.WriteLine("Usage: wmgen.exe [input file].dll [output file].cs");
    return;
}

string inputFile = args[0];
string outputDir = args[1];

if (!File.Exists(inputFile))
{
    Console.WriteLine("Input file not found: " + inputFile);
    return;
}

string inputFileName = Path.GetFileNameWithoutExtension(inputFile);

Assembly assembly = Assembly.LoadFrom(inputFile);
var codes = MarkupExtensionGenerator.GenerateExtensions(assembly);

foreach (var code in codes)
{
    string fileName = Path.Combine(outputDir, $"GeneratedMarkupExtensions_{code.Key}.cs");
    string dirName = Path.GetDirectoryName(fileName);
    if (!Directory.Exists(dirName))
    {
        Directory.CreateDirectory(dirName);
    }
    File.WriteAllText(fileName, code.Value);
    Console.WriteLine($"Generated extensions for {code.Key} saved to {fileName}");
}