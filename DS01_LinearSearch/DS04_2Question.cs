﻿using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
namespace DS03_02Question
{
    //열혈106p
    /*
  public class _node
  {
      public int data;

      public _node next;
  }
  class MainApp
  {

      static void Main(string[] args)
      {
          _node head = null;
          _node tail = null;
          _node cur = null;
            _node dummy = null;
          _node newNode = null;
          int readData;

          while(Convert.ToBoolean(1))
          {
              Console.Write("자연수 입력:");
              readData = int.Parse(ReadLine());
              if (readData < 1)
                  break;

              //노드의 추가과정
              newNode = new _node();
              newNode.data = readData;
              newNode.next = null;

                if (head == null)
                {
                    head = newNode;
                    dummy = newNode;
                }
                else
                {
                    tail.next = newNode;
                    dummy.next = newNode;
                }
                tail = newNode;
          }
          Write("\n");

          WriteLine("입력 받은 데이터의 전체출력!");
          if (head == null)
          {
              WriteLine("저장된 자연수가 존재하지 않습니다.");
          }
          else
          {
              cur = head;
              WriteLine(cur.data);

              while(cur.next != null)
              {
                  cur = cur.next;
                  WriteLine(cur.data);
              }
          }
          WriteLine("\n");

          if(head == null)
          {

          }
          else
          {
              _node delNode = head;
              _node delNextNode = head.next;

              WriteLine("{0}을(를) 삭제합니다.", head.data);
              delNode = null;
              while(delNextNode != null)
              {
                  delNode = delNextNode;
                  delNextNode = delNextNode.next;

                  WriteLine("{0}을(를) 삭제합니다.", delNode.data);
                  delNode = null;
              }
          }

      }


  }
    */

}