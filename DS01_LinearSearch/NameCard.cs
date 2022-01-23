using System;
using System.Collections;
using System.Collections.Generic;
namespace NameCard
{//열혈자료구조 99p예제

    public struct _NameCard
    {
        public char[] name;
        public char[] phone;
        void makeNameCard(char[] name, char[] phone)
        {
            this.name = name;
            this.phone = phone;
        }
    }
    class NameCard
    {
        _NameCard pcard=new _NameCard();
        public void ShowNameCardInfo(_NameCard pcard)
        {
            Console.WriteLine("[이름]" + pcard.name);
            Console.WriteLine("[번호]" + pcard.name);
        }

        int NameCompare(_NameCard pcard, char[] name)
        {
            if(pcard.name == name)
            {
                return 0;
            }
            else
            {
                return 1;
            }

            
        }

        void ChangePhoneNum(_NameCard pcard, char[] phone)
        {
            pcard.phone = phone;
        }



    }






}
