using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.AggregationExample
{
    internal class ClientCode
    {
        public void CallingCode()
        {
            Department department1 = new Department();
            department1.Name = "Department1";

            Teacher teacher1 = new Teacher();
            teacher1.Name = "Teacher1";

            Teacher teacher2 = new Teacher();
            teacher2.Name = "Teacher2";

            department1.teachers.Add(teacher1);
            department1.teachers.Add(teacher2);
        }
    }
}
