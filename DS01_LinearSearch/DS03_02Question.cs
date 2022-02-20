using System;
using System.Collections;
using System.Collections.Generic;
using DS_NameCard;
namespace DS03_02Question
{
    //열혈 자료구조 99p
    /*
    class MainApp
    {


        static void Main(string[] args)
        {
            List<NameCard> list = new List<NameCard>();
            NameCard pcard;

            pcard = new NameCard("이진수", "010-1111-2222");
            list.Add(pcard);

            pcard = new NameCard("한지영", "010-2222-5555");
            list.Add(pcard);

            pcard = new NameCard("조수진", "010-3333-7777");
            list.Add(pcard);

            foreach(NameCard i in list) {
                if(i.NameCompare("한지영") ==0) {
                    i.ShowNameCardInfo();
                    break;
                }
            }

            //이진수의 정보를 조회하여 변경
            foreach(NameCard i in list) {
                if(i.NameCompare("이진수") == 0) {
                    i.ChangePhoneNum("010-9999-9999");
                }
                break;
            }

            //조수진의 정보를 조회하여 삭제
            for(int i=list.Count-1; i>=0; i--) {
                if(list[i].NameCompare("조수진") ==0) {
                    list.RemoveAt(i);
                }
            }

            //모든 사람의 정보 출력
           Console.WriteLine("현재 데이터의 수: {0}", list.Count);

            foreach(NameCard i in list) {
                i.ShowNameCardInfo();
            }
        }
    }
    */

}
