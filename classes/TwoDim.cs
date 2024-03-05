using System;


namespace task_3_4
{
    sealed class TwoDim<T> : Parent<T>
    {
        private int m;
        private int n;

        private T[,] array;

        public TwoDim(bool entry = false) : base(entry) { }

        public override void RndEntry()
        {
            n = rnd.Next(11);
            m = rnd.Next(11);

            array = new T[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = 
                }
            }
        }
        public override void UserEntry()
        {
            Console.WriteLine("Введите длину строки");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину столбца");
            m = int.Parse(Console.ReadLine());

            array = new T[n, m];

            Console.WriteLine($"Введите значения вручную. Тип массива: {array[0, 0].GetType()}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = 
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