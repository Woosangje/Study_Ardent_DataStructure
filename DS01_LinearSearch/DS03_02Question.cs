using System;
using System.Collections;
using System.Collections.Generic;
using NameCard;
using static NameCard.NameCardMethod;
namespace DS03_02Question
{
    //열혈 자료구조 99p
    /*
    class MainApp
    {

        static void Main(string[] args)
        {
            _NameCard nameCard = new _NameCard();
           
            List<_NameCard> list = new List<_NameCard>();
            //1.총 3명의 전화번호 정보를, 앞서 우리가 구현한 리스트에 저장한다.
            string name1 = "이진수", phone1 = "010-1111-2222";
            string name2 = "한지영", phone2 = "010-2222-3333";
            string name3 = "조수진", phone3 = "010-3333-4444";
            char[] chName1 = name1.ToCharArray(),chPhone1 = phone1.ToCharArray();
            char[] chName2 = name2.ToCharArray(), chPhone2 = phone2.ToCharArray();
            char[] chName3 = name3.ToCharArray(), chPhone3 = phone3.ToCharArray();

            nameCard.makeNameCard(chName1, chPhone1);
            list.Add(nameCard);
            nameCard.makeNameCard(chName2, chPhone2);
            list.Add(nameCard);
            nameCard.makeNameCard(chName3, chPhone3);
            list.Add(nameCard);
            //2.특정 이름을 대상으로 탐색을 진행하여, 그 사람의 정보를 출력한다.
            //한지영의 정보를 조회하여 출력,  없을시 출력 값 없음
            for(int i=0; i<list.Count; i++)
            {
                bool temp = list[i].NameCompare(chName2);
                if( temp)
                {
                    ShowNameCardInfo(list[i]);
                    break;
                }
            }
            //이진수의 정보를 조회하여 변경
            for (int i = 0; i < list.Count; i++)
            {
                bool temp = list[i].NameCompare(chName1);
                if (temp)
                {
                    string changeNumber = "010-3211-1233";
                    list[i].ChangePhoneNum(changeNumber.ToCharArray());
                    break;
                }

            }
            //조수진의 정보를 조회하여 삭제
            for(int i=0; i< list.Count; i++)
            {
                bool temp = list[i].NameCompare(chName3);
                if(temp)
                {
                    list.RemoveAt(i);
                    break;
                }
            }

            Console.WriteLine("현제 데이터의 수:" + list.Count);

            for(int i=0; i<list.Count; i++)
            {
                ShowNameCardInfo(list[i]);
            }
    
        }

    }*/
    

}
