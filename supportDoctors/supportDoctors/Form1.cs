using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IronPython.Runtime;
using IronPython;
using IronPython.Hosting;
using Microsoft.Build.BuildEngine;

namespace supportDoctors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // full path of python interpreter 
            //string python = @"C:\Users\Łukasz\AppData\Local\Programs\Python\Python38-32\python.exe";
            /*
            // python app to call 
            string myPythonApp = @"C:\Users\Łukasz\Desktop\supportDoctors\supportDoctors\connect.py";
            // Create new process start info 
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);

            // make sure we can read the output from stdout 
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;

            myProcessStartInfo.Arguments = myPythonApp;
            Process myProcess = new Process();
            myProcess.StartInfo = myProcessStartInfo;
            myProcess.Start();
            StreamReader myStreamReader = myProcess.StandardOutput;
            string myString = myStreamReader.ReadLine();
            myProcess.WaitForExit();
            myProcess.Close();
            Console.WriteLine("Value received from script: " + myString);
            
             
             
            var engine = Python.CreateEngine();
            var script = @"C:\Users\Łukasz\Desktop\supportDoctors\supportDoctors\connect.py";
            var source = engine.CreateScriptSourceFromFile(script);
            */

            dynamic builtin = engine.GetBuiltinModule();
            // you can store variables if you want
            dynamic list = builtin.list;
            dynamic itertools = engine.ImportModule("itertools");
            var numbers = new[] { 1, 1, 2, 3, 6, 2, 2 };
            Console.WriteLine(builtin.str(list(itertools.chain(numbers, "foobar"))));
            // prints `[1, 1, 2, 3, 6, 2, 2, 'f', 'o', 'o', 'b', 'a', 'r']`

            // to add to the search paths
            var searchPaths = engine.GetSearchPaths();
            searchPaths.Add(@"C:\path\to\modules");
            engine.SetSearchPaths(searchPaths);

            // import the module
            dynamic myModule = engine.ImportModule("mymodule");


        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
