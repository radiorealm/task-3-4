using System;

namespace task_3_4
{

    class Program
    {
        static void Main()
        {
            IPrinter[] printer_array = new IPrinter[8];

            Console.WriteLine("Выберите способ ввода для всех массивов (false, если случайно, true, если вручную)");
            bool entry = bool.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Одномерные массивы");
            OneDim<int> intonedim = new(entry);
            printer_array[0] = intonedim;
            OneDim<string> stringonedim = new(entry);
            printer_array[1] = stringonedim;
            OneDim<double> doubleonedim = new(entry);
            printer_array[2] = doubleonedim;
            OneDim<bool> boolonedim = new(entry);
            printer_array[3] = boolonedim;

            Console.WriteLine();

            Console.WriteLine("Двумерные массивы");
            TwoDim<int> inttwodim = new(entry);
            printer_array[4] = inttwodim;
            TwoDim<string> stringtwodim = new(entry);
            printer_array[5] = stringtwodim;
            TwoDim<double> doubletwodim = new(entry);
            printer_array[6] = doubletwodim;
            TwoDim<bool> booltwodim = new(entry);
            printer_array[7] = booltwodim;

            Console.WriteLine();


            for (int i = 0; i < printer_array.Length; i++)
            {
                Console.WriteLine($"Массив {printer_array[i].GetType()}:");

                printer_array[i].Print();
                Console.WriteLine();
            }
        }
    }
}