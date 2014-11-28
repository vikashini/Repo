using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_sortlist
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.mergelist();
          
        }

    }
    public class LinkedList
    {
        private Node head;
        private int count;
       
        public LinkedList()
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


        //Adding Node

        public int add(int index, int o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index:" + index);

            if (index > count)
                index = count;

            Node current = this.head;

            if (isEmpty() || index == 0)
            {
                this.head = new Node(o);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.next;
                current.next = new Node(o);
            }

            count++;

            return 0;
        }

        public int add(int o)
        {
            return this.add(count, o);
        }

        public void mergelist()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 =new LinkedList();
            LinkedList list3 = new LinkedList();
            
            Console.Write("Enter the total No of nodes in list 1:");
            int tot1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the items in list1 in sorted order");
            for (int i = 0; i < tot1; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                list1.add(num);
            }
          
            
            Console.Write("Enter the total No of nodes in list 2:");
            int tot2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the items in list2 in sorted order");
            for (int i = 0; i < tot2; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                list2.add(num);
            }
          

            Console.WriteLine("Item in the list 1");
            list1.printallnode();
            Console.WriteLine("Item in the list 2");
            list2.printallnode();
        
           
            Node current1 = list1.head;
            Node current2 = list2.head;

            for (int i = 0; i < list1.count; i++)
            {
                for (int j =0 ;j< list2.count;j++)
                {
                    while (current1 != null && current2!=null)
                    {
                        if (current1.Data < current2.Data)
                        {
                            list3.add(current1.Data);
                            current1 = current1.next;
                        }
                        else
                        {
                            list3.add(current2.Data);
                            current2 = current2.next;
                        }
                    }
                    if (current1 != null)
                    {
                        list3.add(current1.Data);
                        current1 = current1.next;
                    }
                    else if(current2!=null)
                    {
                        list3.add(current2.Data);
                        current2 = current2.next;
                    }
                }
            }

            Console.WriteLine("The Merged list is:");
            list3.printallnode();
            Console.ReadLine();
        }

        public void printallnode()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.next;
            }

        }
    }
    public class Node
    {
        public Node next;
        private int data;

        public Node()
        {
            next = null;
            data = 0;
        }
        public Node(int data)
        {
            next = null;
            this.data = data;

        }
        public int Data
        {
            get { { return data; } }

        }
    }
}
