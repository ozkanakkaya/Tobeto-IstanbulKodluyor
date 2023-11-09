using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//mevcut items'ı tutar
            items = new T[items.Length + 1];//yeni bir referas oluşur ve eski items uçar. yani items'deki değerler boşalır.

            for (int i = 0; i < tempArray.Length; i++)//items eksi değerlerine yeniden kavuşur.
            {

                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; // items'ın son elemanına metoddan gelen item eklenir.
        }

        public int Length
        {
            get { return items.Length; }

        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
