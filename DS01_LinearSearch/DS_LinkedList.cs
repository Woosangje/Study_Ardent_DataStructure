using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace DS_LinkedList {
    //열혈106p

    class Node {
        public int data;
        public Node next;
    }

     class LinkedList {
        Node head;
        Node cur;
        Node before;
        int numOfData;
        void ListInite() {
            head = new Node();
            head.next = null;
            numOfData = 0;
        }

    }

}

       


      
    



