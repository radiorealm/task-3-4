using System;

namespace task_3_4
{
    sealed class OneDim<T> : Parent<T>
    {
        private int n;
        private T[] array;

        public OneDim(IValueGiver<T> valuegiver, bool entry = false) : base(valuegiver, entry) { }

        public override void RndEntry()
        {
            n = rnd.Next(1, 11);

            array = new T[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = valuegiver.GetRandomValue();
            }
        }
        public override void UserEntry()
        {
            Console.WriteLine("Введите длину массива");
            n = int.Parse(Console.ReadLine());

            array = new T[n];

            Console.WriteLine("Введите значения вручную.");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = valuegiver.GetUserValue();
            }

            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine(String.Join(" ", array));
        }
    }
}