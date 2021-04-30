﻿using System;

namespace ThreadAndTaskMetanit
{
    public class OS
    {
        private static OS instance;
        public string Name { get; private set; }
        private static object syncRoot = new Object();

        protected OS(string name)
        {
            this.Name = name;
        }

        public static OS GetInstance(string name)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new OS(name);
                    }
                }
            }
            return instance;
        }
    }
}