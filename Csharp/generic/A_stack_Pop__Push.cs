using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.generic
{
    class MyStack<T>
    {
        T[] _array;
        private int _pointer = 0;
        const int MaxStack = 100;

        public MyStack()
        {
            this._array = new T[MaxStack];
        }
        bool IsStackEmpty { get { return _pointer <= 0; } }
        bool IsStackFull { get { return _pointer >= MaxStack; } }
        public void Push(T t)
        {
            if (!IsStackFull)
                _array[_pointer++] = t;
        }
        public T Pop()
        {
            return (!IsStackEmpty) ? _array[--_pointer] : _array[0];

            /* if (!IsStackEmpty)
            return _array[--_pointer];
            else
            {
                return _array[0];
            }*/
        }
        public void PrintValue()
        {
            if (_pointer > 0)
            {
                for (int i = _pointer - 1; i >= 0; i--)
                {
                    Console.WriteLine($"Valuse:{_array[i]}");
                }

            }
            else
            {
                Console.WriteLine($"No any Values");
            }
        }


    }
    internal class A_stack_Pop__Push
    {
        static void Main(string[] args)
        {
            MyStack<string> strStack = new MyStack<string>();
            strStack.Push("bird");
            strStack.Push("cat");
            strStack.PrintValue();//_Pointer will no change

            Console.WriteLine($"{strStack.Pop()}");//--_Pointer
            Console.WriteLine($"{strStack.Pop()}");
            strStack.Push("dog");
            strStack.PrintValue();

            Console.WriteLine($"{strStack.Pop()}");
            strStack.PrintValue();
            Console.WriteLine("*****************");
            MyStack<int> intStack = new MyStack<int>();
            intStack.Push(0);
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            intStack.PrintValue();

        }
    }
}
