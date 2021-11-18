using System;
using System.Collections.Generic;
using System.Text;

namespace KFSData
{
    public class Node
    {
        public int _data;
        public Node _next;
        public Node _Perivous;
        public Node()
        {

        }
        public Node(int data)
        {
            this._data = data;
        }

        public void add(Node Next)
        {
            this._next = Next;
        }
        protected internal Node Find(int data,Node Next)
        {
            if (Next == null)
            {
                Console.WriteLine("The Node Do not Exsist");
                return null;
            }
            else
            {
                Node Current = Next;
                if (Current._data == data)
                {
                    return Current;
                }
                return Find(data, Current._next); //recurisves
            }
            
            
        }

    }
}
