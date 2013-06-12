using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class ListNode
    {
        private object data;
        private ListNode next;
        private object insertItem;

        //Constructor   
        //El constructor debe de ser 
        //constructor, cuidado public, private!!

        public ListNode(object dataValue)
            : this(dataValue, null)
        {
        }

        public ListNode(object dataValue, ListNode nextNode)
        {
            data = dataValue;
            next = nextNode;
        }



        //Public <tipo> <nombre_propiedad>

        public ListNode Next
        {
            get { return next; }

            set { next = value; }

        }

        public object Data
        {
            get
            { return data; }

        }

    }

    class List
    {

        private ListNode firstNode;
        private ListNode lastNode;
        private string name;


        public List(string Listname)
        {
            name = Listname;
            firstNode = lastNode = null;

        }

        public List() : this("list") { }


        public void InsertAtFront(object insertItem)
        {

            // Si es vacio, inicio = final
            //Sino es el primerio en insertarse
            if (isEmpty())
            {
                firstNode = lastNode = new ListNode(insertItem);

            }

            else
            {

                firstNode = new ListNode(insertItem, firstNode);

            }

        }

        public void InsertAtBack(object insertItem)
        {

            lock (this) {

                if (isEmpty())
                {
                    firstNode = lastNode = new ListNode(insertItem);
                }
                else
                    lastNode = lastNode.Next = new ListNode(insertItem);
            }


        }


        public bool isEmpty()
        {
            return firstNode == null;
        }


    }
}

        