using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternateelement_three
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.Write("Enter the total No of nodes:");
            int tot = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the nodes in the list");
            for (int i = 0; i < tot; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                list.add(num);
            }
            Console.WriteLine("==================");
            Console.WriteLine("Item in the list");
            Console.WriteLine("==================");
            list.printallnode();
            list.splitthree();
           
            Console.ReadLine();
        }

        public class LinkedList
        {
            private Node head;
            private int count;
            private Node head1 = null;
            private Node head2 = null;

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

            public void splitthree()
            {
                int len = 0;
              
                Node current = this.head;

                LinkedList l1 = new LinkedList();
                LinkedList l2 = new LinkedList();
                LinkedList l3 = new LinkedList();
                while (current != null)
                {
                    for(int i=0;i<count;i++)
                    {
                    if (len == 0)
                    {
                        l1.add(current.Data);
                        current = current.next;
                        this.head = current;
                        len++;
                    }
                    else if (len ==1)
                    {
                        l2.add(current.Data);
                        current = current.next;
                        this.head = current;
                        len++;
                    }
                    else if (len == 2)
                    {
                        l3.add(current.Data);
                        current = current.next;
                        this.head = current;
                        len=0;
                    }
                    }

                }

                Console.WriteLine("The elements in list 1");
                l1.printallnode();
                Console.WriteLine("The elements in list 2");
                l2.printallnode();
                Console.WriteLine("The elements in list 3");
                l3.printallnode();                                      
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
}