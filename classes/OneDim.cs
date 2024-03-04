using System;

namespace task_3_4
{
    sealed class OneDim<T> : Parent<T>
    {
        private int n;
        private T[] array;

        public OneDim(int n, bool entry = false) : base(n, entry)
        {

            this.n = n;
            array = new T[n];
            Fill();
        }

        public override void RndEntry()
        {
            n = rnd.Next(11);
            for (int i = 0; i < n; i++)
            {
                array[i] = value.Give<T>(array[0].GetType());
            }
        }
        public override void UserEntry()
        {
            Console.WriteLine("Введите значения массива вручную");

            for (int i = 0; i < array.Length; i++)
            {
                //array[i] = Parse(Console.ReadLine());
            }

            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine(String.Join(" ", array));
        }
    }
}