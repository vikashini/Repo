using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLinkedList node1 = new DLinkedList();
            node1.add(1);
            node1.add(2);
            node1.add(3);
            node1.add(4);
            node1.printallnode();
            Console.ReadLine();


            //DLinkedList node3 = node1.InsertNext(3);
            //DLinkedList node2 = node3.InsertPrev(2);
            //DLinkedList node5 = node3.InsertNext(5);
            //DLinkedList node4 = node5.InsertPrev(4);

            //node1.TraverseFront();
            //node5.TraverseBack();
            //DLinkedList list = new DLinkedList();
            //Console.Write("Enter the total No of nodes in list 1:");
            //int tot1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the items in list1 in sorted order");
            //for (int i = 0; i < tot1; i++)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    list.InsertNext(num);

            //}
            //list.printallnode();
            //Console.ReadLine();
        }
    }

    class DLinkedList
    {
        private int data;

        private DLinkedList next;
        private DLinkedList prev;

        public DLinkedList()
        {
            data = 0;
            next = null;
            prev = null;
        }

        public DLinkedList(int value)
        {
            data = value;
            next = null;
            prev = null;
        }

        public DLinkedList add(int value)
        {
            DLinkedList node ;
            if (this.next == null)
            {
                DLinkedList node = new DLinkedList(value);

                node.next = null; 
                node.prev = null;
                this.prev = node;
            }
            else
            {

               DLinkedList temp = this.prev;
                  node.prev = temp;
                  node.next = this;
                  this.prev = node;
                  temp.next = node;
                
            }
            
            return node;
        }

        public void printallnode()
        {
            printallnode(this);
        }

        public void printallnode(DLinkedList node)
        {
            System.Console.WriteLine("The nodes in the list are:");

            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }

        }

    }
}