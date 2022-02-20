using System;
using System.Linq;
using static System.Console;
namespace DS02_05RecursiveBinarySearch
{

    /*
  class MainApp
  {
      static public int BSearchRecur(int[] ar, int first, int last, int target)
      {
          int mid;
          if (first > last)
              return -1;
          mid = (first + last) / 2;

          if (ar[mid] == target)
              return mid;
          else if (target < ar[mid])
              return BSearchRecur(ar, first, mid - 1, target);
          else
              return BSearchRecur(ar, mid + 1, last, target);
      }
      static void Main(string[] args)
      {
          int[] arr = { 1, 3, 5, 7, 9 };
          int idx;

          idx = BSearchRecur(arr, 0, arr.Length - 1, 7);
          if (idx == -1)
              WriteLine("탐색 실패");
          else
              WriteLine("타겟 저장 인덱스: {0}", idx);

          idx = BSearchRecur(arr, 0, arr.Length - 1, 4);
          if (idx == -1)
              WriteLine("탐색 실패");
          else
              WriteLine("타겟 저장 인덱스: {0}", idx);
      } 

  }
*/

}
