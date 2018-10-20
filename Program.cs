using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestingProcesses {
    class Program {

        static List<string> listBox1 = new List<string>();
        static void Main(string[] args) {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes) {
                if (!String.IsNullOrEmpty(p.MainWindowTitle)) {
                    try {
                        //Console.WriteLine("----------------------------");
                        Console.WriteLine("Title: " + p.MainWindowTitle);
                        /*
                        Console.WriteLine(p.HandleCount);
                        Console.WriteLine(p.Handle);
                        Console.WriteLine(p.MachineName);
                        Console.WriteLine(p.MainModule);
                        Console.WriteLine(p.Modules);
                        foreach (ProcessModule mod in p.Modules) {
                            //Console.WriteLine(mod.FileName);
                        }
                        Console.WriteLine(p.StandardInput);
                        Console.WriteLine(p.MainWindowHandle);
                        Console.WriteLine(p.Container);

                        Console.WriteLine("----------------------------");
                        Console.WriteLine("============================");
                        foreach (ProcessModule mod in p.Modules) {
                            Console.WriteLine(mod.FileName);
                        }
                        Console.WriteLine("============================");
                        */

                    } catch {

                    }
                    
                    listBox1.Add(p.MainWindowTitle);
                }
            }
            Console.ReadLine();
        }
    }
}
