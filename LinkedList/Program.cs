using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Make Sure you use those namespaces
using System.Collections.Generic;
using KFSData;
using System.Collections;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ////C# build in Linkedlist  (it kinda not work as our implementation)
            //// Sunday monday tuesday  wednesday thursday friday saturday 

            ////=============Uncomment this section after finishing the uncommented examples for excercises solutions==========
            
            ////Excercise 1sol
            //LinkedList<string> KamelLinkedList = new LinkedList<string>();
            //var node1 = KamelLinkedList.AddFirst("Avatar");
            //LinkedListNode<string> titanic = new LinkedListNode<string>("Titanic");

            ////titanic.Value = "Titanic";
            //KamelLinkedList.AddLast(titanic);
            //KamelLinkedList.AddAfter(titanic, "Star Wars: The Force Awakens");
            //var VenomNode = KamelLinkedList.AddFirst("venom");
            ////KamelLinkedList.AddBefore(node1, "Pursuit of happiness");
            //KamelLinkedList.AddAfter(VenomNode,"Pursuit of happiness");
            //KamelLinkedList.AddLast("black mirror");
            //var ElLembyNode = KamelLinkedList.AddAfter(node1, "El Lemby 8 Giga");
            ////KamelLinkedList.Remove("El Lemby 8 Giga");
            //KamelLinkedList.Remove(ElLembyNode);


            ////Excercise 2 sol
            //LinkedList<string> droids = new LinkedList<string>();

            //droids.AddLast("C-3PO");
            //droids.AddLast("AZI-3");
            //droids.AddLast("R2-D2");
            //droids.AddLast("IG-88");
            //droids.AddLast("2-1B");
            //Console.WriteLine("The Linked List Before Deletion:");
            //foreach (var item in droids)
            //{
            //    //Console.WriteLine(item);
            //    Console.Write("{0} \t", item);
            //}
            //Console.WriteLine();

            //droids.RemoveFirst();
            //droids.Remove("R2-D2");
            //droids.RemoveLast();
            //Console.WriteLine("The Linked List After Deletion:");
            //foreach (var item in droids)
            //{
            //    //Console.WriteLine(item);
            //    Console.Write("{0} \t", item);
            //}
            ////===============================================================================

            ////Example 1
            LinkedList<string> month = new LinkedList<string>();
            LinkedList<string> names = new LinkedList<string>();
            var one = month.AddFirst("sunday");
            
            var last = month.AddLast("saturday");

            var second = month.AddAfter(one, "monday");
            var third = month.AddAfter(second, "tuesday");
            month.AddBefore(last, "friday");

            LinkedListNode<string> wednesday = new LinkedListNode<string>("wednesday");
            month.AddAfter(third, wednesday); //second overloading

            foreach (var item in month)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------Like insert --------------");
            month.AddFirst("Feto");
            foreach (var item in month)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------");
            //Example 2  Searching
            var namesss= new LinkedList<string>();
            namesss.AddFirst("Mohamed");
            namesss.AddLast("Fathallah");
            var node = namesss.Find("Mohamed"); //if mohamed not exist  case sensitive null reference error will be throw
            Console.WriteLine(node.Value);

            //Example 3
            if (namesss.Remove("Mohamed"))//return  bool so you can test if mohamed found and removed, false if not found
            {
                Console.WriteLine("Mohamed Has been Removed Sucessfully");
            }
            LinkedlistvsListTester_MF_KFS.RunTestOnLinkedlist();
            Console.WriteLine("===============================================");
            LinkedlistvsListTester_MF_KFS.RunTestOnList();
            

            Console.ReadKey();

            //=================================Disregard this section========================================

            // KFSData.LinkedList KFS = new KFSData.LinkedList(6);
            // KFS.Add(7);
            // KFS.Add(8);
            // //KFS.Add(10);
            // //KFS.Add(9);
            // // KFS.Count();
            // //Node q=KFS.Find(7);
            // Console.WriteLine(KFS.Count());
            // // KFS.Delete(10);
            // Console.WriteLine(KFS.Find(6));
            //// KFS.Count();
            // var Result=KFS.ToString();
            // Console.WriteLine(Result);
            // Console.ReadKey();


        }
    }
}
