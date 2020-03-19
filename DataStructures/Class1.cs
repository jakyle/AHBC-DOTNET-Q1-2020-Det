using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Vector<T>
    {
        private int _length = 8;
        private T[] _array;

        public Vector()
        {
            _array = new T[8];
        }

        public int Count { get; set; }

        public void Add(T item)
        {
            if (Count == _length)
            {
                var replacingArray = new T[_length * 2];
                _length *= 2;

                for (int i = 0; i < _array.Length; i++)
                {
                    replacingArray[i] = _array[i];
                }

                _array = replacingArray;
            }

            _array[Count] = item;
            Count++;
        }

        // Count = 5, index being passed in = 7
        public T IndexAt(int index)
        {
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            return _array[index];
        }

        public void Clear()
        {
            Count = 0;
        }

        public void LookAtMe()
        {


            LookAtMe();
        }
    }
}
