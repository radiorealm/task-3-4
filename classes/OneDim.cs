using System;

namespace task_3_4
{
    sealed class OneDim<T> : Parent<T>
    {
        private int n;
        private T[] array;

        public OneDim(bool entry = false) : base(entry) { }

        public override void RndEntry()
        {
            n = rnd.Next(11);

            array = new T[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = 
            }
        }
        public override void UserEntry()
        {
            Console.WriteLine("Введите длину массива");
            n = int.Parse(Console.ReadLine());

            array = new T[n];

            Console.WriteLine($"Введите значения вручную. Тип массива: {array[0].GetType()}");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 
            }

            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine(String.Join(" ", array));
        }
    }
}