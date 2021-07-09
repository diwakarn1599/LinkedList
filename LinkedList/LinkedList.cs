using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        Node head;
        public void InsertAtLast(int val)
        {
            Node temp = new Node(val);
            if (head == null)
            { 
                this.head = temp;
            }
            else
            {
                Node traverse = this.head;
                while(traverse.next != null)
                {
                    traverse = traverse.next;
                }
                traverse.next = temp;
             }

        }
        public void Display()
        {
            Node temp = this.head;
            while(temp != null)
            {
                if(temp.next != null)
                {
                    Console.Write($"{temp.data}-->");
                }
                else
                {
                    Console.Write(temp.data);
                }
                
                temp = temp.next;
            }
        }
    }
}
