using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitinglist_into_n
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.splitn();
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

            public void splitn()
            {
                int len = 0;
                int temp = 0;
                LinkedList list1 = new LinkedList();
                
                Console.Write("Enter the total No of nodes in list 1:");
                int tot1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the nodes");

                for (int i = 0; i < tot1; i++)
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    list1.add(num);
                }
                Console.WriteLine("Enter the number you want to split");
                int splitnum = Convert.ToInt32(Console.ReadLine());
               
                while(temp >splitnum)
                {
                    LinkedList list2 = new LinkedList();
                     temp++;
                }

                Node current = this.head;

               /* while (current != null)
                {
                    list2.add(current.Data);

                }*/
                
             /*  while (current != null)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (len == 0)
                        {
                            list2[i].add(current.Data);
                            current = current.next;
                            this.head = current;
                            len++;
                        }
                        else if (len == 1)
                        {
                            list2[i].add(current.Data);
                            current = current.next;
                            this.head = current;
                            len++;
                        }
                        else if (len == 2)
                        {
                            list2[i].add(current.Data);
                            current = current.next;
                            this.head = current;
                            len = 0;
                        }
                    }

                }*/
              
              
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
