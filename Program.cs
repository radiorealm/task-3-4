using System;

namespace task_3_4
{

    class Program
    {
        static void Main()
        {
            IPrinter[] printer_array = new IPrinter[8];

            IntValueGiver ints = new();
            StringValueGiver strings = new();
            BoolValueGiver bools = new();
            DoubleValueGiver doubles = new();

            Console.WriteLine("Выберите способ ввода для всех массивов (false, если случайно, true, если вручную)");
            bool entry = bool.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Порядок массивов: int, string, double, bool");

            OneDim<int> intonedim = new(ints, entry);
            printer_array[0] = intonedim;
            OneDim<string> stringonedim = new(strings, entry);
            printer_array[1] = stringonedim;
            OneDim<double> doubleonedim = new(doubles, entry);
            printer_array[2] = doubleonedim;
            OneDim<bool> boolonedim = new(bools, entry);
            printer_array[3] = boolonedim;

            Console.WriteLine();

            TwoDim<int> inttwodim = new(ints, entry);
            printer_array[4] = inttwodim;
            TwoDim<string> stringtwodim = new(strings, entry);
            printer_array[5] = stringtwodim;
            TwoDim<double> doubletwodim = new(doubles, entry);
            printer_array[6] = doubletwodim;
            TwoDim<bool> booltwodim = new(bools, entry);
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