using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
namespace DS05_LinkedList {
    //열혈106p

    class Node{
        public int data;
        public Node next;


        Node tail;
        Node cur;
        Node before;
        int numOfData;

        void ListInit() {
            tail = null;
            cur = null;
            before = null;
            numOfData = 0;
        }

        void Insert(int data) {
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
        void InsertFront() {

        }


        int First() {
            return 0;
        }
        int Next() {
            return 0;
        }
        int Remove() {
            return 0;
        }
        int Count() {
            return 0;
        }

    }


    


}
