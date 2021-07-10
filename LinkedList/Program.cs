using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list");
            LinkedList list = new LinkedList();
            //Adding Elements to linked list
            list.InsertBeginning(70);
            list.InsertBeginning(30);
            list.InsertBeginning(10);
            list.InsertBeginning(40);
            list.Display();
            list.DeleteLast();
            list.Display();
        }
    }
}
