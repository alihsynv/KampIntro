using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<X, Y>
    {
        X[] items1;
        Y[] items2;
        private object tempItems1;

        public MyDictionary()
        {
            items1 = new X[0];
            items2 = new Y[0];
        }

        public int Length { get; internal set; }

        public void Add(X item1, Y item2)
        {
            X[] tempArray1 = items1;
            Y[] tempArray2 = items2;
            items1 = new X[items1.Length + 1];
            items2 = new Y[items2.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                items1[i] = tempArray1[i];

            }
            
            items1[items1.Length - 1] = item1;
            
            for (int i = 0; i < tempArray2.Length; i++)
            {
                items2[i] = tempArray2[i];
            }
            
            items2[items2.Length - 1] = item2;
        }
    }
}