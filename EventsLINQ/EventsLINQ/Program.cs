﻿using System;

namespace EventsLINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var task1 = new Task1();

            task1.Run(() => Console.WriteLine(task1.Res()));
        }
    }
}
