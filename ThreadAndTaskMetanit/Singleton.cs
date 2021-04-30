﻿using System;

namespace ThreadAndTaskMetanit
{
    public class Singleton
    {
        private static Singleton instance;
        private static object syncRoot = new Object();
        private Singleton()
        {

        }
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }

            }
            return instance;
        }
    }
}
