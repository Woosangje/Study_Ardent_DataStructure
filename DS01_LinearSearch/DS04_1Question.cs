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

        public _node before;
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
                newNode.data = readData;//1
                newNode.before = null;

                if (tail == null)//1 null  =  tail 1 2 null
                {
                    tail = newNode;
                }
                else
                    tail.before = newNode;

                head = newNode;//1,2 null
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
                cur = head;
                WriteLine(cur.data);

                while (cur.next != null)
                {
                    cur = cur.next;
                    WriteLine(cur.data);
                }
            }
            WriteLine("\n");
            
        }

    }
    

}
