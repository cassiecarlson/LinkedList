/*
 * Kyle Riedemann
 * This program is an example of a linked list imlemented in C#
 * 
 * The program consists of Nodes which holds content and point to the next node in the list
 * There are methods to add and remove data from the list, and a class to test the implementation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class List
    {
        public class Node
        {
            public object NodeContent;
            public Node NextNode;

        }

        private int size;

        public int Count
        {
            get { return size; }
        }

        // head of the list
        private Node headNode;

        // the current node
        private Node currentNode;

        // initialize the list with a size of zero and no headNode
        public List()
        {
            size = 0;
            headNode = null;
        }

        // method to add a Node to the list
        public void Add(object content)
        {
            size++;

            var newNode = new Node()
            {
                NodeContent = content
            };

            // make sure to set the head node if null at the time of the Add call
            if (headNode == null)
            {
                headNode = newNode;
            }
            // if the head is present, just add the node to the list
            else
            {
                currentNode.NextNode = newNode;
            }

            // set the new node to the current node
            // this is to keep our place in the list
            currentNode = newNode;
        }

        // method to add new node as the head of the current list
        // removes need to check is headNode is null and adds to beginning of list
        public void HeadAdd(object content)
        {
            headNode = new Node()
            {
                NextNode = headNode,
                NodeContent = content
            };
        }

        // method to print all nodes out to console
        // to test and help me understand how the system works
        public void printNodes()
        {
            Node tempNode = headNode;

            while (tempNode != null)
            {
                System.Console.WriteLine(tempNode.NodeContent);
                System.Console.ReadLine();
                tempNode = tempNode.NextNode;
            }
        }

        // retrival method to get the node in the specified position
        // will return null if no node exists at that location
        
    }
}
