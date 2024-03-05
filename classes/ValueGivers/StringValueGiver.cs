using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_4
{
    class StringValueGiver: IValueGiver<string>
    {
        Random rnd = new();
        public string GetRandomValue()
        {
            string alphabet = "qwertyuiopasdfghjklzxcvbnm1234567890";
            string a = "";
            for (int i = 0; i < rnd.Next(10); i++)
            {
                a += alphabet[rnd.Next(alphabet.Length)];
            }
            return a;
        }

        public string GetUserValue()
        {
            Console.WriteLine("Введите строку для элемента списка");
            return Console.ReadLine();
        }
    }
}
