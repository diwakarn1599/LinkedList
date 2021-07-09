using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        Node head;

        //method for insert at last
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
        public void InsertBeginning(int val)
        {
            Node temp = new Node(val);
            if (head == null)
            {
                this.head = temp;
            }
            else
            {

                temp.next = this.head;
                this.head = temp;
            }

        }
        public void InsertMiddle(int val,int pos)
        {
            Node addNode = new Node(val);
            Node temp = this.head;
            Node prev = null;
            for(int i = 1; i < pos && temp!=null; i++)
            {
                prev = temp;
                temp = temp.next;
            }
            prev.next = addNode;
            addNode.next = temp;


        }
        //method to display linkedlist
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
