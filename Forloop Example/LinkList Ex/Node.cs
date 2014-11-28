using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList_Ex
{
    public class Node
    {
        private int data;
        private Node next;

        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }

         public int Data
         {
             get
             {
                 return this.data;
             }
             set
             {
                 this.data = value;
             }
         }
         public Node Next
         {
             get { return this.next; }
             set { this.next = value; }
         }
    }
}
