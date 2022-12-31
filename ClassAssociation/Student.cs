using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.ClassAssociation
{
    internal class Student
    {
        public string Name { get; set; }
        public List<Teacher> teachers { get; set; }

        public void SetAssociatedTeachers(List<Teacher> listTeachers)
        {
            teachers = listTeachers;
        }
    }
}
