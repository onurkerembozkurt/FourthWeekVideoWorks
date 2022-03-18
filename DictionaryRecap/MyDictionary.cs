using System;
using System.Collections.Generic;
using System.Text;
namespace DictionaryRecap
{
    class MyDictionary<A,B>
    {
        A[] items1;
        B[] items2;
        public MyDictionary()
        {
            items1 =new A[0];
            items2 = new B[0];

        }
        public void Add(A item1,B item2)
        {
           A[] tempItems1 = items1;
            B[] tempItems2 = items2;
            items1 = new A[items1.Length + 1];
            items2 = new B[items2.Length + 1];
            for (int i = 0; i < tempItems1.Length; i++)
            {
                items1[i] = tempItems1[i];
               
            }
            for (int i = 0; i < tempItems2.Length; i++)
            {
                items2[i] = tempItems2[i];
            }
            items1[items1.Length - 1] = item1;
            items2[items2.Length - 1] = item2;
           


        }
    }
}
