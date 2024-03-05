using System;

namespace task_3_4
{
    abstract class Parent<T> : IParent, IPrinter
    {
        protected StringValueGiver strings = new();
        protected BoolValueGiver bools = new();
        protected DoubleValueGiver doubles = new();

        protected static Random rnd = new Random();

        protected bool entry = false;

        public Parent(int n, bool entry) { }

        public abstract void RndEntry();

        public abstract void UserEntry();

        public abstract void Print();

        public void Fill()
        {
            if (!entry)
            {
                RndEntry();
            }
            else
            {
                UserEntry();
            }
        }

        public void GetType(T[] array)
        {
            string _type = (array[0].GetType()).ToString();
            switch (_type)
            {
                case "int":
                    IntValueGiver values = new();
                    break;

                case "string":
                    StringValueGiver values = new();
                    break;

                case "double":
                    break;

                case "bool":
                    break;
            }
        }
    }
}