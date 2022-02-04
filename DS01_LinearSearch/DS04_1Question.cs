using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
namespace DS03_02Question
{
    //열혈106p
    
    public class _node
    {
        public int data;

        public _node prev;
    }
    class MainApp
    {

        static void Main(string[] args)
        {
            _node head = null;
            _node tail = null;
            _node cur = null;

            _node newNode = null;
            int readData;

            while (Convert.ToBoolean(1))
            {
                Console.Write("자연수 입력 : ");
                readData = int.Parse(ReadLine());
                if (readData < 1)
                    break;

                //노드의 추가과정
                newNode = new _node();
                newNode.prev.data = readData;//1
                newNode = null;

                if (tail == null)//1 null  =  tail 1 2 null
                {
                    tail = newNode;
                }
                else
                    tail.prev = newNode;

                head = tail.prev;//null, 2,1 
            }
            Write("\n");

            //입력 받은 데이터의 출력과정
            WriteLine("입력 받은 데이터의 전체출력!");
            if (head == null)
            {
                WriteLine("저장된 자연수가 존재하지 않습니다. ");
            }
            else
            {
                //cur.prev = head;//2 1 
               // WriteLine(cur.data);
                /*
                while (cur != null)
                {
                    cur = cur.next;
                    WriteLine(cur.data);
                }*/
            }
            WriteLine("\n");
            
        }

    }
    

}
