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

            while (true) {
                Console.Write("자연수 입력 :");
                readData = int.Parse(ReadLine());
                if (readData < 1)
                    break;

                //노드의 추가과정
                newNode = new Node();
                newNode.data = readData;//
                newNode.next = null;

                if(head ==null) {
                    head = newNode;
                    tail = newNode;
                }
                else {
                    newNode.next = head;
                    head = newNode;
                }
            }
            Write("\n");

            //입력 받은 데이터의 출력과정
            WriteLine("입력 받은 데이터의 전체출력!");
            if(head == null) {
                WriteLine("저장된 자연수가 존재하지 않습니다.");

            }
            else {
                cur = head;
                WriteLine(cur.data);

                while(cur.next != null) {
                    cur = cur.next;
                    WriteLine(cur.data);
                }
            }


        }

    }*/

}
