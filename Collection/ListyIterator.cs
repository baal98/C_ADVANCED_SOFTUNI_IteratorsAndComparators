using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        public int index;

        public ListyIterator(List<T> list)
        {
            this.list = list;
            index = 0;
        }

        public bool Move()
        {
            if (index + 1 < list.Count)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext() => index + 1 < list.Count;

        public void Print()
        {
            if (list.Count <= 0)
            {
                throw new Exception("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
