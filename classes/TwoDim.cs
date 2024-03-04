using System;


namespace task_3_4
{
    sealed class TwoDim<T> : Parent<T>
    {
        private int m;
        private int n;

        private T[,] array;

        public TwoDim(int n, int m, bool entry = false) : base(n, entry)
        {
            array = new T[n, m];

            this.m = m;
            this.n = n;

            if (!entry)
            {
                RndEntry();
            }
            else
            {
                UserEntry();
            }
        }

        public override void RndEntry()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = value.Give<T>(array[0, 0].GetType());
                }
            }
        }
        public override void UserEntry()
        {
            Console.WriteLine("Введите значения массива вручную");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
        }

        public override void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void Snake_Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int j1 = i % 2 == 0
                        ? j
                        : array.GetLength(1) - 1 - j;

                    Console.Write(array[i, j1]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}