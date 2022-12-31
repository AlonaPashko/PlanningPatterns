using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.CreationalPatterns.Singleton
{
    internal class LazySingleton
    {
        private static readonly Lazy<LazySingleton> lazy = 
            new Lazy<LazySingleton>(() => new LazySingleton());

        public string Name { get; private set; }

        private LazySingleton() 
        {
            System.Guid.NewGuid().ToString();
        }
        public static LazySingleton GetInstance()
        {
            return lazy.Value;
        }
    }
}
