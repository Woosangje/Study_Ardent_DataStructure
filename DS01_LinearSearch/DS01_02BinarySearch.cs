using System;
using static System.Console;
namespace DS02_BinarySearch {

    /*
    class DS01_BinarySearch
    {
        static public int BSearch(int[] ar, int len, int target)//순차 탐색 알고리즘 적용된 메소드
        {
            int first = 0;
            int last = len - 1;
            int mid;

            while(first <= last)
            {
                mid = (first + last) / 2;//탐색 대상의 중앙을 찾는다.

                if(target == ar[mid])
                {
                    return mid;//탐색 완료!
                }
                else//타겟이 아니라면 탐색 대상을 반으로 줄인다.
                {
                    if (target < ar[mid])
                        last = mid - 1;//왜 -1을 하였을까?
                    else
                        first = mid + 1;//왜 +1을 하였을까?
                }
            }
            return -1;//찾지 못했을 때 반환되는 값 -1
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            int idx;

            idx = BSearch(arr, arr.Length, 7);

            if (idx == -1)
                WriteLine("탐색 실패");
            else
                WriteLine("타겟 저장 인덱스: {0}", idx);
            idx = BSearch(arr, arr.Length, 4);
            if (idx == -1)
                WriteLine("탐색 실패");
            else
                WriteLine("타겟 저장 인덱스:" + idx);


        }
    }*/
}
