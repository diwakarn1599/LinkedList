using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list");
            LinkedList list = new LinkedList();
            list.InsertAtLast(56);
            list.InsertAtLast(30);
            list.InsertAtLast(70);
            list.Display();
        }
    }
}
