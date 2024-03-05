using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_4
{
    class IntValueGiver : IValueGiver<int>
    {
        Random rnd = new Random();
        public int GetRandomValue()
        {
            return rnd.Next(100);
        }

        public int GetUserValue()
        {
            Console.WriteLine("Введите число для элемента списка");
            return int.Parse(Console.ReadLine());
        }
    }
}
