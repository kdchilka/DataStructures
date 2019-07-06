using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedListClass
    {

        public class Node
        {
            public int value;
            public Node next;
            public Node(int val)
            {
                this.value = val;
                this.next = null;
            }
        }

        public int count = 0;
        private Node Head { get; set; }
        private Node CurrNode { get; set; }

        public void AddNode(Node newNode)
        {
            //if this is the first node
            if (Head == null)
            {
                Head = newNode;
                CurrNode = Head;

            }
            else
            {
                CurrNode.next = newNode;
                CurrNode = newNode;
            }

            count++;
        }


        public void DeleteLastNode()
        {
            Node tempNode = Head;

            while (tempNode.next != CurrNode)
            {
                tempNode = tempNode.next;
            }

            //now tempNode.Next = CurrentNode
            CurrNode = tempNode;
            CurrNode.next = null;
            count--;

            Console.WriteLine("item Deleted");
            PrintList();
        }


        public void AddAfterValue(int afterVal, Node nodeToAdd)
        {
            if (Head == null)
            {
                Console.WriteLine("Invalid operation!");
            }
            else
            {
                Node tempNode = Head;
                while (tempNode.value != afterVal)
                {
                    tempNode = tempNode.next;
                }

                Node nextNode = tempNode.next;
                tempNode.next = nodeToAdd;
                nodeToAdd.next = nextNode;
            }

            PrintList();
        }


        public void DeleteNode(int val)
        {
            Node tempNode = Head;
            Node prevNode = Head;

            while (tempNode.value != val)
            {
                prevNode = tempNode;
                tempNode = tempNode.next;
            }

            Node nextNode = tempNode.next;
            prevNode.next = nextNode;

            Console.WriteLine("After deleting value: " + val);
            PrintList();
        }
        
        public void PrintList()
        {
            Node tempNode = Head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.value);
                tempNode = tempNode.next;
            }
        }

        public void DeleteWhoseSumIsZero()
        {


        }



    }
}
