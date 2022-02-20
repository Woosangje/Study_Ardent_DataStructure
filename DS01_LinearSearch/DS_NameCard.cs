using System;
using System.Collections;
using System.Collections.Generic;
namespace DS_NameCard {//열혈자료구조 99p예제 DS03_02Question.cs 사용됨
    //c#에서 자료구조 구현은 struct대신 class 사용하자 
    class NameCard {
        public string name;
        public string phone;

        public NameCard(string name, string phone) {
       
            if (name.Length > 30 && phone.Length >30) {
                name.Substring(0, 30);
                phone.Substring(0, 30);
            }   
            this.name = name;
            this.phone = phone;
        }

        public void ShowNameCardInfo() {
            Console.WriteLine("[이름] {0}", this.name  );
            Console.WriteLine("[번호] {0}", this.phone);
        }
        public int NameCompare(string name) {
            return string.Compare(this.name, name);
        }

        public void ChangePhoneNum(string phone) {
            this.phone = phone;
        }

    
    }


}
