using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_4
{
    class ValueGiver
    {
        private Random random = new Random();
        public T Give<T>(Type type)
        {
            string alphabet = "qwertyuiopasdfghjklzxcvbnm1234567890";
            bool[] bools = { true, false };
            string _type = type.ToString();
            switch (_type)
            {
                case "int":
                    T a = (T)random.Next(100);
                    return a
                case "string":
                    return alphabet[random.Next(alphabet.Length)];
                case "bool":
                    return bools[random.Next(bools.Length)];
                case "double":
                    return random.NextDouble();
            }
            //способ преобразование в универсальный тип - ?
        }
    }
}
