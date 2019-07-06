using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating LinkedList of 5");


            LinkedListClass linkedList = new LinkedListClass();

            LinkedListClass.Node newNodeToadd = new LinkedListClass.Node(10);
            linkedList.AddNode(newNodeToadd);

            LinkedListClass.Node newNodeToadd2 = new LinkedListClass.Node(20);
            linkedList.AddNode(newNodeToadd2);

            LinkedListClass.Node newNodeToadd3 = new LinkedListClass.Node(-30);
            linkedList.AddNode(newNodeToadd3);

            LinkedListClass.Node newNodeToadd4 = new LinkedListClass.Node(40);
            linkedList.AddNode(newNodeToadd4);

            LinkedListClass.Node newNodeToadd5 = new LinkedListClass.Node(50);
            linkedList.AddNode(newNodeToadd5);

            Console.WriteLine("Total number of items in the list: "+ linkedList.count);

            linkedList.PrintList();

            Console.WriteLine("deleting last item");

            linkedList.DeleteLastNode();
            
            Console.WriteLine("Total number of items in the list after deleting: " + linkedList.count);
            
            linkedList.AddAfterValue(30, new LinkedListClass.Node(35));

            linkedList.DeleteNode(35);




        }
    }
}