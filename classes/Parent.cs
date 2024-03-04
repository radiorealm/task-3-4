using System;

namespace task_3_4
{
    abstract class Parent<T> : IParent, IPrinter
    {
        protected ValueGiver value = new ValueGiver();

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
    }
}