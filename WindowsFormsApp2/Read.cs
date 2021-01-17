using ConsoleApp19;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Read
    {
        public static string[] read()
        {
            try
            {
                string[] lines = File.ReadAllLines("todos.tds");
                return lines;
            }
            catch
            {
                File.Create("todos.tds");
                Environment.Exit(0);
                return null;
            }
        }
    }
}
