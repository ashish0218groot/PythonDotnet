﻿using System;
using System.IO;
using Python.Runtime;

class Program
{
    static void Main()
    {
        Runscript("mypythonscripttwo");
    }

    static void Runscript(string moduleName)
    {
        Runtime.PythonDLL = @"C:\Program Files\Python312\python312.dll";
        PythonEngine.Initialize();

        using (Py.GIL())
        {
            dynamic sys = Py.Import("sys");
            string scriptDirectory = @"D:\Ashish\POC\PythonDotNetCore\PythonDotnet";
            sys.path.append(scriptDirectory);

            dynamic pythonModule = Py.Import(moduleName);

            dynamic result = pythonModule.say_hello();
            dynamic GetDirectory = pythonModule.test(result);
            Console.WriteLine(result);
            Console.WriteLine(GetDirectory);
             

        }

     }
}
