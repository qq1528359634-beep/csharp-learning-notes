using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Part_2_Dependency_Injection
{
    internal class how_foreach_work
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList() { 1, 2, 3, 4, 5 };
            var nums3 = new ReadOnlyCollection(nums1);
            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Sum(nums2));
            Console.WriteLine(Sum(nums3));
        }
        static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum += (int)i;
            }
            return sum;
            /*  IEnumerator e = nums.GetEnumerator();

              while (e.MoveNext())
              {
                  int i = (int)e.Current;
              }*/
        }
    }
    class ReadOnlyCollection : IEnumerable
    {
        private int[] _array;
        public ReadOnlyCollection(int[] array)
        {
            _array = array;
        }
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
        public class Enumerator : IEnumerator
        {
            private ReadOnlyCollection _collection;
            private int _head;
            public Enumerator(ReadOnlyCollection collection)
            {
                _collection = collection;
                _head = -1;
            }
            public object Current
            {
                get
                {
                    object o = _collection._array[_head];
                    return o;
                }
            }

            public bool MoveNext()
            {
                if (++_head < _collection._array.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                _head = -1;
            }
        }
    }
}
