using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverselist_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node();
            Node head = root;
            root =root.next =  new Node(1);
            root = root.next = new Node(2);
            root = root.next = new Node(3);
            root = root.next = new Node(4);
            Console.WriteLine("Before Reversal");
            printallnode(head);
            Console.WriteLine("After Reversing:");
            head = Reverse(head);
            printallnode(head);           
            Console.ReadLine();
            
           
        }
        private static Node Reverse(Node head)
        {
            if (head == null) return null;
            Node CurrentNode = head.next;
            head.next = null;
            Node r = Reverse(CurrentNode);
            if (r == null)
            {
                return head;
            }
            CurrentNode.next = head;
            return r;

           }

        private static void printallnode(Node head)
        {
            Node current=head;
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

