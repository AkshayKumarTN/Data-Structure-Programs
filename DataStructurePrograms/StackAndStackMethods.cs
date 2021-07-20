using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    public class Node<T>
    {
        public T value;
        public Node<T> Next;
        public Node(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }

    class StackAndStackMethods<T>
    {
        public Node<T> top;

        public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
        }

        public int pop()
        {
            if (top == null)
            {
                Console.WriteLine("Unbalanced");
                return 0;

            }
            else
            {
                top = top.Next;
                return 1;
            }
        }

        public int CheckTop()
        {
            if (top == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
