using System;

namespace GenericsExample
{
    class Program
    {
        public LinkedList<int> IntLinkedList;
        public LinkedList<string> StringLinkedList;
        static void Main()
        {
            var prog = new Program();
            Console.WriteLine("Integer linked list:");
            prog.IntLinkedList.PrintLinkedList();
            Console.WriteLine("String linked list:");
            prog.StringLinkedList.PrintLinkedList();
        }

        public Program()
        {
            IntLinkedList = new LinkedList<int>(1);
            InitIntLinkedList();

            StringLinkedList = new LinkedList<string>("a");
            InitStringLinkedList();
        }

        void InitIntLinkedList()
        {
            var curElement = IntLinkedList;
            for (int i = 2; i < 10; i++)
            {
                curElement.NextElement = new LinkedList<int>(i);
                curElement = curElement.NextElement;
            }
        }

        void InitStringLinkedList()
        {
            var curElement = StringLinkedList;
            var chr = curElement.Value.ToCharArray()[0];
            for (int i = 1; i < 10; i++)
            {
                curElement.NextElement = new LinkedList<string>($"{curElement.Value}{++chr}");
                curElement = curElement.NextElement;
            }
        }
    }
}
