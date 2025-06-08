using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class ArrayStack : IStack
    {
        private int[] items;
        private int top = -1;

        public ArrayStack(int capacity)
        {
            items = new int[capacity];
        }

        public void Push(int value)
        {
            if (Count >= items.Length)
                throw new InvalidOperationException("Stack is full");

            items[++top] = value;
        }

        public int Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            return items[top--];
        }

        public bool Contains(int value)
        {
            for (int i = 0; i <= top; i++)
            {
                if (items[i] == value)
                    return true;
            }
            return false;
        }

        public int Count => top + 1;

        public bool IsEmpty => Count == 0;
    }
}
