using System;
using System.Collections.Generic;
using System.Text;

namespace Chocolate_Lazy
{
    class Singleton
    {
        private Singleton() { }

        private static Singleton uniqueInstance;
        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }

        private int currentId = 0;
        internal string GetNextId()
        {
            currentId++;
            return currentId.ToString();
        }
    }
}
