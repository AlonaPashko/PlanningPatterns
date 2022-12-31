using PlanningPatterns.AggregationExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.CompositionExample
{
    internal class University
    {
        public string Name { get; set; }
        public List<Department> departments { get; set; }

        public void GetDepartments()
        {
            Department department1 = new Department { Name = "Department1" };
            Department department2 = new Department { Name = "Department2" };

            departments.Add(department1);
            departments.Add(department2);
        }
    }
}
