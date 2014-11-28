using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_Ex
{
    class BST
    {
         class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int value)
            {
                this.data = value;
                left = null;
                right = null;
            }
        }
        class BinarySearchTree
        {
            public Node root;
            static int count;
            public BinarySearchTree()
            {
                root = null;
            }

            
            public Node addNode(int data)
            {
                Node temp = new Node(data);
                if (root == null)
                    root = temp;
                count++;
                return temp;
            }

           
            public void insert(Node root, Node newNode)
            {
                while (root != null)
                {
                    if (newNode.data > root.data)
                    {
                        if (root.right == null)
                        {
                            root.right = newNode;
                            break;
                        }
                        root = root.right;
                    }
                    else
                    {
                        if (root.left == null)
                        {
                            root.left = newNode;
                            break;
                        }
                        root = root.left;
                    }
                }
            }
            //Inorder Traversal
            public void inorder(Node root)
            {
                if (root != null)
                {
                    inorder(root.left);
                    Console.Write(root.data + " ");
                    inorder(root.right);
                }
            }
            //Pre Order Traversal
            public void preorder(Node root)
            {
                if (root != null)
                {
                    Console.Write(root.data + " ");
                    preorder(root.left);
                    preorder(root.right);
                    
                }
            }

            //Post Order Traversal
            public void postorder(Node root)
            {
                if (root != null)
                {
                    postorder(root.left);
                    postorder(root.right);
                    Console.Write(root.data + " ");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                BinarySearchTree bst = new BinarySearchTree();
               
                bst.insert(bst.root, bst.addNode(21));
                bst.insert(bst.root, bst.addNode(19));
                bst.insert(bst.root, bst.addNode(7));
                bst.insert(bst.root, bst.addNode(19));
                bst.insert(bst.root, bst.addNode(16));
                bst.insert(bst.root, bst.addNode(13));
                bst.insert(bst.root, bst.addNode(8));
                bst.insert(bst.root, bst.addNode(22));

                Console.WriteLine("Inorder Traversal");
                bst.inorder(bst.root);
                               
                Console.WriteLine("\n \nPreorder Traversal");
                bst.preorder(bst.root);

                Console.WriteLine("\n \nPostorder Traversal");
                bst.postorder(bst.root);

                Console.ReadLine();
            }
        }

    }
  }
