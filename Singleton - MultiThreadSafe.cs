using System;
using System.Collections.Generic;
using System.Text;

namespace Chocolate_Lazy
{
    class SingletonEager
    {
        private static SingletonEager instance; // Static variable to hold the single instance of the class
        private static readonly object lockObject = new object(); // Object used for locking to ensure thread safety
        private int nextId = 1; // Variable to hold the next id

        private SingletonEager()
        {
            // Private constructor to prevent instantiation
        }

        public static SingletonEager GetInstance()
        {
            if (instance == null) // Check if the instance is null
            {
                lock (lockObject) // Acquire a lock on the lockObject to ensure thread safety
                {
                    if (instance == null) // Double-check if the instance is still null
                    {
                        instance = new SingletonEager(); // Create a new instance of the class
                    }
                }
            }
            return instance; // Return the single instance of the class
        }

        internal string GetNextId()
        {
            string id = $"ID-{nextId}"; // Generate the next id
            nextId++; // Increment the next id for the next call
            return id; // Return the generated id
        }
    }
}
