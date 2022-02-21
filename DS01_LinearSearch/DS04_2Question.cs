using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
namespace DS03_02Question
{
    //열혈106p
    /*
    
    class Node {
        public int data;

        public Node next;
    }
    class MainApp {

        static void Main(string[] args) {
            Node head = null;
            Node tail = null;
            Node cur = null;

            Node newNode = null;
            int readData;

            head = new Node();
            tail = head;

            while (true) {
                Console.Write("자연수 입력 : ");
                readData = int.Parse(ReadLine());
                if (readData < 1)
                    break;

                //노드의 추가과정
                newNode = new Node();
                newNode.data = readData;//1
                newNode.next = null;

                tail.next = newNode;//2 4
                tail = newNode;//2 2

            }
            Write("\n");

            //입력 받은 데이터의 출력과정
            WriteLine("입력 받은 데이터의 전체출력!");
            if (head == tail) {
                WriteLine("저장된 자연수가 존재하지 않습니다.");
            }
            else {
                cur = head;

                while (cur.next != null) {
                    cur = cur.next;
                    WriteLine(cur.data);
                }
            }
            WriteLine();

            if(head == tail) {

            }
            else {
                Node delNode = head;
                Node delNextNode = head.next;

                while(delNextNode != null) {
                    delNode = delNextNode;
                    delNextNode = delNextNode.next;
                    WriteLine("{0}을(를) 삭제합니다. ", delNode.data);

                }
            }


        }

    }*/


}
