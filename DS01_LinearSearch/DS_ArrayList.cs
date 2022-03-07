using System;
using System.Collections;
using System.Collections.Generic;
namespace DS_ArrayList {
    //DS03_01PointListMain 사용중
    class DS_ArrayList {

        int[] arr=new int[100];
        int numOfData;
        int curPosition;

        public void ListInit() {

            numOfData = 0;
            curPosition = -1;
        }

        public void LInsert(int data) {

            if(numOfData >= data) {
                Console.WriteLine("저장이 불가능합니다.");
                return;
            }

            arr[numOfData] = data;
            numOfData++;
        }

        public bool LFirst(int data) {

            if (numOfData == 0)
                return false;

            curPosition = 0;
            data = arr[0];
            return true;
        }

        public bool LNext(int data) {

            if (curPosition >= numOfData - 1)
                return false;

            curPosition++;
            data = arr[curPosition];
            return true;
        }

        public int LRemove() {

            int rpos = curPosition;
            int num = numOfData;
            int i;
            int rdata = arr[rpos];

            for (i = rpos; i < num - 1; i++) {
                arr[i] = arr[i + 1];
            }
                numOfData--;
                curPosition--;
                return rdata;
            
        }
        public int LCount() {
            return numOfData;
        }
    }


}
