using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList_Ex
{
    public class LinkedList
    {
        private Node head;
        private int count;
        
        private Node tail;
   

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
        public int add(int index,int o)
        {
            if (index < 0)
            throw new ArgumentOutOfRangeException("Index:" + index);
           
            if (index > count)
            index = count;

            Node current = this.head;

            if (isEmpty() || index == 0)
            {
                this.head = new Node(o,this.head);
        

            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                current = current.Next;

                current.Next = new Node(o, current.Next);
            }
        
            count++;
            return 0;
        }

        public int add(int o)
        {
            return this.add(count, o);
        }

//Removing Node

        public int remove(int index)
        {
            if (index < 0 || index >= this.count)
                throw new ArgumentOutOfRangeException("Index:" + index);

            if (isEmpty())
               return 0;

            //setting last values as index if greater
           // if (index >= this.count)
              //  index = count-1;

            Node current = this.head;
            int result = 0;

            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }

           else
            {
               
                    for (int i = 0; i < index - 1; i++)
                        current = current.Next;

                        result = current.Next.Data;
                        current.Next = current.Next.Next;
                   
             }
            count--;
            return result;

        }

 //Adding node in front of the list
      public int addfront(int index, int o)
        {

            Node current = this.head;

            this.head = new Node(o, this.head);
            current = current.Next;

            count++;
            return 0;


        }

        public int addfront(int o)
        {
            return this.addfront(count, o);
        }

//Adding Node at the End
        public int addend(int index, int o)
        {
            Node current = this.head;

            if (this.head == null)
                addfront(index, o);
            else
            {
                current = this.head;
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                current.Next = new Node(o, current.Next);
                
            }
            count++;
            return 0;
        }

        public int addend(int o)
        {
            return this.addend(count, o);
        }

 //Reversing List loop
    
    public void Reverseloop()
       
    {
        Node prev = null;
        Node temp = null;
        Node current = this.head;

        while (current != null)
        {
            temp = prev;
            prev = current;
            current = current.Next;
            prev.Next = temp;
        }
        head = prev;
       
    }

  
  

               
 //Printing      
        public void printallnode()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
