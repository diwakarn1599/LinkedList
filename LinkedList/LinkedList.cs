using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class UserLinkedList
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
        public void DeleteBeginning()
        {
            if(this.head != null)
            {
                Console.WriteLine("\nAfter Deletion:");
                this.head = this.head.next;
            }
            else
            {
                Console.WriteLine("No elements in the linked list");
            }
        }

        public void DeleteLast()
        {
            if(this.head !=null)
            {
                Node temp = this.head;

                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.WriteLine("\nAfter deletion:");
            }
            else
            {
                Console.WriteLine("No elements in the linked list");
            }
            
        }

        public int Search(int val)
        {
            Node temp = this.head;
            int count = 0, FlagsAttribute = 0;
            while (temp != null)
            {
                count++;
                if (temp.data == val)
                {
                    FlagsAttribute = 1;
                    break;
                }
                temp = temp.next;
            }
            if (FlagsAttribute == 1)
            {
                return count;
            }
            else
            {
                return 0;
            }
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
