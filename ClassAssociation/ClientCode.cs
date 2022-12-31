using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.ClassAssociation
{
    internal class ClientCode
    {
        public void CallingCode()
        {
            Student student1= new Student();
            student1.Name = "Student1";

            List<Teacher> teachers = new List<Teacher>();

            Teacher teacher1 = new Teacher { Name = "Teacher1"};
            Teacher teacher2 = new Teacher { Name = "Teacher2" };

            teachers.Add(teacher1);
            teachers.Add(teacher2);

            student1.SetAssociatedTeachers(teachers);
        }
    }
}
