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

        public Parent(bool entry)
        {
            Fill();
        }

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