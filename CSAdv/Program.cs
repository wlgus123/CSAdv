﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAdv
{
    class Wanted<T>
    {
        public T Value;
        public Wanted(T value) {
            this.Value = value; 
        }
    }
    
    class WantedTest<T, U>
        where T : IComparable
        where U : IComparable, IDisposable
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("string");
            Wanted<int> wantedInt = new Wanted<int>(52273);
            Wanted<double> wantedDouble = new Wanted<double>(52.273);

            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);
        }
    }
}
