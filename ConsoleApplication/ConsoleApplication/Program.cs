﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
        }
    }

    internal class User
    {
        public string Name { get; set; }
    }
}
