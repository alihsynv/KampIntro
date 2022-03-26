using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> persons = new MyDictionary<int, string>();
            persons.Add(17, "Ali");
        }
    }
}

