using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
namespace DS04_1LinkedRead {
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

         Node newNode=null;
         int readData = 0;

         //데이터를 입력 받는 과정
         while (true) {
             WriteLine("자연수 입력: ");
             readData = int.Parse(ReadLine());

             if (readData < 1)
                 break;

             //노드의 추가과정
             newNode = new Node();
             newNode.data = readData;
             newNode.next = null;

             if (head == null) {
                 head = newNode;
             }
             else
                 tail.next = newNode;

             tail = newNode;
         }
         WriteLine();

         //입력 받은 데이터의 출력과정
         WriteLine("입력 받은 데이터의 전체출력! ");
         if (head == null) {
             WriteLine("저장된 자연수가 존재하지 않습니다. ");
         }
         else {
             cur = head;
             WriteLine("{0} ", cur.data);//첫 번째 데이터 출력

             while (cur.next != null) {
                 cur = cur.next;
                 WriteLine("{0} ", cur.data);
             }
         }
         WriteLine("\n");

         //메모리의 해제과정
         if (head == null) {

         }
         else {
             Node delNode = head;
             Node delNextNode = head.next;

             WriteLine("{0}을(를) 삭제합니다. \n", head.data);

             while (delNextNode != null) //두 번째 이후 노드 삭제
             {
                 delNode = delNextNode;
                 delNextNode = delNextNode.next;

                 WriteLine("{0}을(를) 삭제합니다. ", delNode.data);

             }
         }

     }


 }*/


}
