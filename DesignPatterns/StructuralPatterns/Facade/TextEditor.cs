using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.StructuralPatterns.Facade
{
    internal class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Code Generation");
        }
        public void Save()
        {
            Console.WriteLine("Saving Code");
        }
    }
}
