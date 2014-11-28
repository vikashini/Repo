using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlinkedlist
{
    class Program
    {

        static void Main(string[] args)
        {

            Dlinkedlist list1 = new Dlinkedlist();

            Console.WriteLine("Enter total number of nodes");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Enter Node Item to Add: ");
            

            for (int i = 0; i < count; i++)
            {
                int x = int.Parse(Console.ReadLine());
                list1.AddNode(x);
            }
            Console.WriteLine("The Items in the list are");
            Console.WriteLine();
            list1.PrintList();

            Console.WriteLine("Inserting at begining of list");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\nEnter the node");
            int beg = int.Parse(Console.ReadLine());
            list1.Insertatbeg(beg);
            Console.WriteLine("The Items in the list are");
            list1.PrintList();

            Console.WriteLine("Inserting at position x of list");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Enter index (starting from 0) of the nodes to be inserted");
            int ins = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the node");
            int node = int.Parse(Console.ReadLine());
            list1.Insertatx(ins, node);
            Console.WriteLine("The Items in the list are");
            list1.PrintList();

            Console.WriteLine("Deleting at Pos x");
            Console.WriteLine("------------------");
            Console.WriteLine("Enter index(starting from 0) of the nodes to be deleted");
            int del = int.Parse(Console.ReadLine());
            list1.Removeatx(del);
            Console.WriteLine("The Items in the list are");
            list1.PrintList();

            Console.WriteLine("Searching the Element in the list");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Enter the element to be searched");
            int Search1 = int.Parse(Console.ReadLine());
            list1.SearchElement(Search1);

            Console.WriteLine("\nThe Length of the list is");
            Console.WriteLine();
            Console.WriteLine(list1.Count());


            Console.ReadLine();
        }
    }
     class Dlinkedlist
        {
       
        Node head;
        int count;
        public Dlinkedlist()
        {
            this.head = null;
            this.count = 0;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public int Count()
        {
            return this.count;
        }

        public int AddNode(int index,int item)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index:" + index);

            if (index > count)
                index = count;

            if (head == null)
                head = new Node(item, null, null);
            else
            {
                Node currentNode = head;
 
                while (currentNode.next != null)
                    currentNode = currentNode.next;
 
                currentNode.next = new Node(item, currentNode, null);
            }
            count++;
            return 0;
        }

        public int AddNode(int item)
        {
            return this.AddNode(count, item);
        }

        public int Removeatx( int index)
        {

            if (index < 0)
                throw new ArgumentOutOfRangeException("Index:" + index);

            if (isEmpty())
                return 0;

            Node current = this.head;
            Node temp;
            int result = 0;

            if (index == 0)
            {
                result = current.item;
                this.head = current.next;
                current.next.previous = null;
            }
            else if (index == this.count-1)
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.next;

                result = current.next.item;
                current.next = null;
                

            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.next;

                result = current.next.item;
                temp = current;
                current.next = current.next.next;
                current.next.previous = temp;
                 }
            count--;
            return result;

        }

        public int Insertatbeg(int index,int item)
        {
            if (index < 0 )
                throw new ArgumentOutOfRangeException("Index:" + index);

            if (isEmpty())
                return 0;

            Node current = this.head;
            Node temp;
            int result = 0;
            result = current.item;
            temp = new Node(item, null, null);

            current.previous = temp;
            temp.next = current;
            temp.previous = null;
            this.head = temp;

            count++;
            return 0;
        }

        public int Insertatbeg(int item)
        {
            return this.Insertatbeg(count, item);
        }

        public int Insertatx(int index, int item)
     {
         if (index < 0 )
             throw new ArgumentOutOfRangeException("Index:" + index);

         if (isEmpty())
             return 0;

         Node current = this.head;
         Node temp;
         int result = 0;

         if (index == 0)
         {
             result = current.item;
             temp = new Node(item, null, null);
             
             current.previous = temp;
             temp.next = current;
             temp.previous = null;
             this.head = temp;

         }
         else if (index == this.count - 1)
         {
             for (int i = 0; i < index; i++)
                 current = current.next;

             result = current.item;
             temp = new Node(item, current, null);
             current.next = temp;
             temp.next = null;


         }
         else
         {
             for (int i = 0; i < index; i++)
                 current = current.next;

             result = current.item;
             temp = new Node(item, current, null);
             temp.next = current;
             temp.previous = current.previous;
             current.previous.next = temp;
             current.previous = temp;

         } 
            count++;
            return 0;
     }

        public int SearchElement(int index, int item)
        {
            
            Node current = this.head;
                 int result = 0;


                 while (current != null)
                 {
                     if (current.item == item)
                     {
                         Console.WriteLine("The position of item is{0}", result);
                     }
                     current = current.next;
                     result++;
                }                  
           
            return result;
        }

        public int SearchElement(int item)
        {
            return this.SearchElement(count, item);
        }

        public void PrintList()
        {
            Node currentNode = head;
            Node prevNode = null;
 
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.item);
                prevNode = currentNode;
                currentNode = currentNode.next;
            }
         
            
        }
        }
    

    class Node
    {
        public int item;
        public Node previous;
        public Node next;

        public Node(int item, Node previous, Node next)
        {
            this.item = item;
            this.previous = previous;
            this.next = next;
        }
    }
}
