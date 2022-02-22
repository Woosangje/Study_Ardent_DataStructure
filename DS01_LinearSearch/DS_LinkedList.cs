using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
namespace DS_LinkedList {
    //열혈106p

    class Node {
        public int data;
        public Node next;
    }

    class CList {
        Node tail = null;
        Node cur = null;
        Node before = null;
        int numOfData = 0;

        public void InsertFront(int data) {

            Node newNode = new Node();
            newNode.data = data;

            if (tail == null) {
                tail = newNode;
                newNode.next = newNode;
            }
            else {
                newNode.next = tail.next;
                tail.next = newNode;
            }
            numOfData++;
        }

        public void Insert(int data) {
            Node newNode = new Node();
            newNode.data = data;

            if (tail == null) {
                tail = newNode;
                newNode.next = newNode;
            }
            else {
                newNode.next = tail.next;
                tail.next = newNode;
                tail = newNode;//LInsertFront 함수와의 유일한 차이점
            }
            numOfData++;
        }

        public bool First(int data) {
            if (tail == null)
                return false;

            before = tail;
            cur = tail.next;

            data = cur.data;
            return true;
        }
        public bool Next(int data) {

            if (tail == null)
                return false;

            before = cur;
            cur = cur.next;

            data = cur.data;
            return true;

        }

        public int Remove( ) {
            Node rpos = cur;
            int rdata = rpos.data;

            if (rpos == tail) {

                if (tail == tail.next)
                    tail = null;
                else
                    tail = before;
            }

            before.next = cur.next;
            cur = before;

            numOfData--;
            return rdata;
        }
        public int Count() {
            return numOfData;
        }

    }


}

       


      
    



