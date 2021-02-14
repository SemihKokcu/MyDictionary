using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class List<A, T>
    {
        A[] keys;
        T[] items;
        public List()
        {
            keys = new A[0];
            items = new T[0];
        }
        public void Add(A key, T item)
        {
            A[] tempArrayKeys = keys;
            T[] tempArrayItems = items;
            keys = new A[keys.Length + 1];
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArrayItems.Length; i++)
            {
                keys[i] = tempArrayKeys[i];
                items[i] = tempArrayItems[i];
            }

            keys[keys.Length - 1] = key;
            items[items.Length - 1] = item;


        }

        public T[] Items
        {
            get { return items; }
        }
        public A[] Keys
        {
            get { return keys; }
        }

        public int Lenght
        {
            get { return items.Length; }
        }

        public void Show()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(keys[i] + ": " + items[i]);
            }

        }






    }
}
