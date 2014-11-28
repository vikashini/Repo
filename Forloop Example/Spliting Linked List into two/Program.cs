using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spliting_Linked_List_into_two
{
   

    
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

        public void split()
        {
            int lenght;
            lenght = count/2;
            Node current = this.head;
           
            LinkedList l2 = new LinkedList();
            for (int i = 0; i < lenght; i++)
            {
                l2.add(current.Data);
                current = current.next;
            }

            LinkedList l3 = new LinkedList();
            for (int i = count; i > lenght; i--)
            {
                l3.add(current.Data);
                current = current.next;
            }
                   Console.WriteLine("The items in list two is:");
                   l2.printallnode();
                   Console.WriteLine("The items in list three is:");
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
          list.split();
          Console.ReadLine();

      }
  }
}
