using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities1 = new List<string>();
            cities1.Add("Baku");
            cities1.Add("Baku");
            cities1.Add("Baku");
            cities1.Add("Baku");
            Console.WriteLine(cities1.Count);


            MyList<string> cities2 = new MyList<string>();
            cities2.Add("Shusha");
            cities2.Add("Shusha");
            cities2.Add("Shusha");
            cities2.Add("Shusha");
            Console.WriteLine(cities2.Count);

            
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _array[i];
            }
        }


        public int Count
        {
            get { return _array.Length; }
        }

    }
}
