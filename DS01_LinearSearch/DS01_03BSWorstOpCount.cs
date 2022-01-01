using System;
using System.Linq;
using static System.Console;
namespace DS03_BSWorstOpCount
{
   /*
    class DS01_BinarySearch
    {
        static public int BSearch(int[] ar, int len, int target)//순차 탐색 알고리즘 적용된 메소드
        {
            int first = 0;
            int last = len - 1;
            int mid;
            int opCount = 0;

            while(first <= last)
            {
                mid = (first + last) / 2;
                if (target == ar[mid])
                {
                    return mid;
                }
                else
                {
                    if (target < ar[mid])
                        last = mid - 1;
                    else
                        first = mid + 1;
                }
                opCount += 1;   //비교연산의 횟수 1 증가
            }
            WriteLine("비교연산횟수: {0} \n", opCount);   //탐색실패 시 연산횟수 출력
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr1 = Enumerable.Repeat(0, 500).ToArray();//모든 요소 0으로 초기화
            int[] arr2 = Enumerable.Repeat(0, 5000).ToArray();
            int[] arr3 = Enumerable.Repeat(0, 50000).ToArray();
            int idx;

            //배열 arr1을 대상으로, 정장되지 않은 정수 1을 찾으라고 명령
            idx = BSearch(arr1, arr1.Length, 1);
            if (idx == -1)
                WriteLine("탐색 실패 \n \n");
            else
                WriteLine("타겟 저장 인덱스: {0} \n", idx);

            //배열 arr2를 대상으로, 저장되지 않은 정수 2를 찾으라고 명령
            idx = BSearch(arr2, arr2.Length, 2);
            if (idx == -1)
                WriteLine("탐색 실패 \n\n");
            else
                WriteLine("타겟 저장 인덱스: {0} \n", idx);

            //배열 arr3을 대상으로, 저장되지 않은 정수 3을 찾으라고 명령
            idx = BSearch(arr3, arr3.Length, 3);
            if (idx == -1)
                WriteLine("탐색 실패 \n\n");
            else
                WriteLine("타겟 저장 인덱스: {0} \n", idx);






        }
    }
   */
}
