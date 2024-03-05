using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_4
{
    class BoolValueGiver : IValueGiver<bool>
    {
        Random rnd = new Random();
        public bool GetRandomValue()
        {
            bool[] bools = { true, false };
            return bools[rnd.Next(bools.Length)];
        }

        public bool GetUserValue()
        {
            Console.WriteLine("Введите логическое значение для элемента списка");
            return bool.Parse(Console.ReadLine());
        }
    }
}
