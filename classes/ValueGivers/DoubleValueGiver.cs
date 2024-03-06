using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_4
{
    class DoubleValueGiver : IValueGiver<double>
    {
        Random rnd = new Random();
        public double GetRandomValue()
        {
            return rnd.NextDouble();
        }

        public double GetUserValue()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
