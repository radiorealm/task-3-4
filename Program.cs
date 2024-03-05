using System;

namespace task_3_4
{

    class Program
    {
        static void Main()
        {
            IPrinter[] printer_array = new IPrinter[2];

            Console.WriteLine("Выберите способ ввода для всех массивов (false, если случайно, true, если вручную)");
            bool entry = bool.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Одномерные массивы");
            OneDim<int> intonedim = new(entry);

            Console.WriteLine();

            TwoDim<int> inttwodim = new(entry);

            Console.WriteLine();


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Массив {printer_array[i].GetType()}:");

                printer_array[i].Print();
                Console.WriteLine();
            }
        }
    }
}