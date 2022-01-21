using System;
using System.Collections;
using System.Collections.Generic;
namespace NameCard
{//열혈자료구조 99p예제
    enum Len
    {
        NAME_LEN = 30,
        PHONE_LEN = 30,
    }

    struct _Point
    {
        static Len len =Len.NAME_LEN;
        public static char[] name = new char[(int)len];
        public static char[] phone = new char[30];
        
        //Name
        void MakeNameCard(char[] name, char[] phone)
        {

        }

        //NameCard 구조체 변수의 정보 출력
        void ShowNameCardInfo()
        {

        }
        //NameCard 구조체 변수의 정보 출력
        int NameCompare(char[] name)
        {
            return 0;
        }
        //전화번호 정보를 변경
        void ChangePhoneNum(char[] phone)
        {

        }
    }







}
