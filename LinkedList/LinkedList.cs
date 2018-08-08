using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //Non-Generic LinkedList
    class LinkedList
    {
        public LinkedList()
        {
            Head = new Node();
            Current = Head;
        }

        public Node Head;
        public Node Current;
        public int Count = 0;
        

        public void AddAtStart(object value)
        {
            var newNode = new Node()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            --Count;
        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value); //If using a reference type (any class/interface), you will need to override ToString for this to work.
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }
        /////////    LAB 18 METHODS   /////////////
        public void RemoveAt(int index)
        {
            if (Count <= 0)
            {
                //throw new Exception("There are no elements to remove");
            }
            Node current = Head;
            for(int i = 0; i < index - 1; i++)
            {
                current = current.Next;
                
            }
            current.Next = current.Next.Next;
            Count--;
        }

        public void PrintReverse()
        {
            Node previous = null;
            Node current = Head;

            while (current != null)
            {
                Node temp = current.Next;
                current.Next = previous;
                previous = current;
                current = temp;
            }
            Head = previous;
        }

        public bool InsertAt(int index, Object o)
        {
            Node current = Head;
            var newNode = new Node()
            {
                Value = o
            };
            if (Count <= 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                    newNode.Next = current.Next;
                }
                current.Next = newNode;
            }
            Count++;
            return true;
        }
        //////////////// END LAB 18 METHODS /////////////////

    }

    //Linked List using Generics
    class LinkedList<T> where T : class
    {
        public LinkedList()
        {
            Head = new Node<T>();
            Current = Head;
        }
        public Node<T> Head;
        public Node<T> Current;
        public int Count = 0;

        public void AddAtStart(T value)
        {
            var newNode = new Node<T>()
            {
                Value = value
            };
            newNode.Next = Head.Next;
            Head.Next = newNode;
            ++Count;
        }

        public void RemoveFromStart()
        {
            if (Count <= 0)
            {
                throw new Exception("There are no elements to remove");
            }

            Head.Next = Head.Next.Next;
            --Count;
        }

        public void PrintAllNodes()
        {
            Console.Write("Head -> ");
            Node<T> curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write(" -> ");
            }
            Console.Write("NULL");
            Console.WriteLine();
        }
    }

    
    
}
