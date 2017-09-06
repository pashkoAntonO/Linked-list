using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList
{
    class LinkedList<T> : IEnumerable<T>
    {

        public Node<T> Tail { get; private set; }
        public Node<T> Head { get; private set; }
        public int Count { get; private set; } = 0;


        public void AddToTail(T item)
        {
            Node<T> node = new Node<T>(item);

            if (Head != null)
            {
                Tail.Next = node;
            }
            else
            {
                Head = node;
            }

            Tail = node;
            Count++;

        }

        public void AddToHead(T item)
        {
            Node<T> first = new Node<T>(item);
            first.Next = Head;
            Head = first;

            if (Count == 0)
                Tail = Head;

            Count++;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }


        public bool Remove(T item)
        {
            Node<T> current = Head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    Count--;
                    // Если узел в начале
                    if (current.Equals(Head))
                    {
                        Head = Head.Next;
                        if (Head == null)
                        {
                            Tail = null;
                        }
                        return true;
                    }
                    // Если узел в конце
                    if (current.Next == null)
                    {
                        previous.Next = null;
                        Tail = previous;
                        return true;
                    }
                    //Если в середине
                    previous.Next = current.Next;
                    return true;
                }

                current = current.Next;
                previous = current;

            }


            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }


    }
}
