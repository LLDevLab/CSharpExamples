using System;

namespace GenericsExample
{
    class LinkedList<T>
    {
        public LinkedList<T> NextElement { get; set; }
        public T Value { get; set; }

        public LinkedList(T val)
        {
            NextElement = null;
            Value = val;
        }

        public void PrintLinkedList()
        {
            var curElement = this;

            while (curElement != null)
            {
                Console.WriteLine($"Element {curElement.Value}");
                curElement = curElement.NextElement;
            }
        }
    }
}
