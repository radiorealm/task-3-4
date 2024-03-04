using System;

namespace task_3_4
{

    class Program
    {
        static void Main()
        {
            IParent[] arr = new IParent[2];

            Console.WriteLine("Выберите способ ввода для всех массивов (false, если случайно, true, если вручную)");
            bool entry = bool.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите n для одномерного массива:");
            int n1 = int.Parse(Console.ReadLine());
            OneDim onedim = new(n1, entry);

            Console.WriteLine();

            Console.WriteLine("Введите n для двумерного массива:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите m для двумерного массива:");
            int m = int.Parse(Console.ReadLine());
            TwoDim twodim = new(n2, m, entry);

            Console.WriteLine();

            arr[0] = onedim;
            arr[1] = twodim;

            IPrinter[] printer_array = new IPrinter[2];

            printer_array[0] = onedim;
            printer_array[1] = twodim;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Массив {arr[i].GetType()}:");
                arr[i].Print();
                Console.WriteLine();

                printer_array[i].Print();
                Console.WriteLine();
            }



        }
    }
}