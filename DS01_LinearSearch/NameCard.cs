using System;
using System.Collections;
using System.Collections.Generic;
namespace NameCard
{//열혈자료구조 99p예제 DS03_02Question.cs 사용됨
    //해결해야할 문제 구조체 char에 [30]선언하기 선언하고 다른 메소드들 응용하기
    //어차피 게임엔진이든 웹이든 문자열길이제한은 여러가지방법이 있다. 일단 넘어가자
    public struct _NameCard
    {
        public char[] name;
        public char[] phone;
        public void makeNameCard(char[] name, char[] phone)
        {
            

                this.name = name;
                this.phone = phone;
        }

    }
    static class NameCardMethod
    {
        
        public static void ShowNameCardInfo(_NameCard pcard)
        {
            string temp1 = new string(pcard.name);
            string temp2 = new string(pcard.phone);
            Console.WriteLine("[이름]" + temp1);
            Console.WriteLine("[번호]" + temp2);
        }

        public static bool NameCompare(this _NameCard pcard, char[] name)
        {
            if(pcard.name == name)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public static void ChangePhoneNum(this _NameCard pcard, char[] phone)
        {
            pcard.phone = phone;
        }



    }






}
