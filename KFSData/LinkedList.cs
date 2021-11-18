using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace KFSData
{
    public class LinkedList : Node
    {
        //this not double linked list
        Node Head;
        Node Tile;
        public LinkedList() { }
        public LinkedList(int data)
        {
            Head = new Node(data);
            Tile = Head;
        }
        public void Add(int Next)
        {
            //i keep thinking in access modifers and i don't anyone to use Node only liskedlist outside lib

            if (Head == null)
            {
                this.Head = new Node(Next);
                Tile = Head;
            }
            else
            {
                //3 steps to add node

                //The Node i want to insert now
                Node Current = new Node(Next);
                //1-Make the perivous of this node is the last node which is the tile
                Current._Perivous = Tile;
                //2-after the last node add the node ( make the next of last node is the current)
                Tile._next = Current;//add(Current); //if you don't want to use add in node Tile.next=current
                //3-make the current is the Tile
                Tile = Current;
            }

        }

        public int Count()
        {
            int count = 0;
            Node Current = Head;
            if (Head != null)
            {
                count += 1; //Count the head
                //current is the head i count the next element till i meet the next is null which is the tile
                while (Current._next != null)
                {
                    count++;
                    Current = Current._next;

                }
            }
            return count;
        }

        public Node Find(int data)
        {
            //first check the head if not go the next and use finds
            if (Head._data == data)
            {
                return Head;
            }
            return Head.Find(data, Head._next);

        }
        public void Delete(int Data)
        {
            Node Current = Find(Data);
            //if it the head
            if (Current._data == Head._data)
            {
                //if it the head just make the head the next node after the head
                Head = Current._next;

            }
            else if (Current == null)
            {
                Console.WriteLine("You Trying to remove something does not exist");
            }
            else
            {
                //temp is the node 1 and i want to remove 2 and next is 3
                Node Temp = Current._Perivous;
                //1.next(2.next which is 3)
                Temp._next = Current._next;
                //for connect the pervious 
                //3.pervoius now make it 1 not 2 
                Current._next._Perivous = Temp;

                //class point to nothing the garbge collector will remove it from memory.
                Current = null;
            }

        }
        //Try to Write function to make the insert

        //don't worry about this i just make it to print
        public override string ToString()
        {

            string Numbers = "";
            Node Head = this.Head;
            if (Head == null)
            {
                return Numbers;
            }
            else
            {
                Numbers += $" {Head._data }";

            }
            while (Head._next != null)
            {
                Head = Head._next;
                Numbers += $" {Head._data}";


            }

            return Numbers;
        }
    }
}
