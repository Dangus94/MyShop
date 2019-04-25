using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopLibrary
{
    class DoubleLinkedList
    {
        Node header;
        Node tail;

        public DoubleLinkedList()
        {
            header = null;
            tail = null;
        }

        public void Add(ItemReceiptInstance v)
        {
            Node n = new Node(v);
            if (header == null)
            {
                header = n;
                tail = n;
            }
            else
            {
                n.next = header;
                header.previous = n;
                header = n;
            }
        }

        public void RemoveLastAdded(ItemReceiptInstance v)
        {
            Node p = header;
            if (header != null)
            {
                if (header.Equals(tail))
                {
                    header = tail = null;
                }
                else
                {
                    p.next.previous = null;
                    header = p.next;
                }
            }
        }

        public void RemoveNthItem(int n)
        {
            Node p = tail;

           for (int i = 0; i < n; i++)
            {
                if (p == null)
                {
                    break;
                }
                else
                {
                    p = p.previous;
                }
            }
           if (p != null)
            {
                if (p.next != null) { 
                    p.next.previous = p.previous;
                }

                if (p.previous != null)
                {
                    p.previous.next = p.next;
                }
            }

        }

        public string PrintInReverse(ItemReceiptInstance v)
        {
            StringBuilder s = new StringBuilder();
            Node p = tail;

            while (p != null) {
                s.Append(p.value.ToString());
                p = p.previous;
            }
            return s.ToString();
        }
    }

    class Node
    {
        public ItemReceiptInstance value;
        public Node previous;
        public Node next;

        public Node()
        {
            previous = null;
            next = null;
            value = null;
        }

        public Node(ItemReceiptInstance v)
        {
            previous = null;
            next = null;
            value = v;
        }

    }
}
