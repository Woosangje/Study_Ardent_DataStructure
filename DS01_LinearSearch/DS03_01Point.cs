using System;
using System.Collections;
using System.Collections.Generic;
namespace DS03_01ListQuesion
{
    struct _Point
    {
       
        public int xpos;
        public int ypos;

        public void SetPointPos(int xpos, int ypos)
        {
            this.xpos = xpos;
            this.ypos = ypos;
        }
        public void ShowPointPos()
        {
            Console.WriteLine("[{0}, {1}]", this.xpos, this.ypos);
        }

        public int PointComp(_Point pos1, _Point pos2)//21 20
        {
            if (pos1.xpos == pos2.xpos && pos1.ypos == pos2.ypos)
                return 0;
            else if (pos1.xpos == pos2.xpos)
                return 1;
            else if (pos1.ypos == pos2.ypos)
                return 2;
            else
                return -1;
        }


    }




    class MainApp
    {

        static void Main(string[] args)
        {
            List<_Point> list = new List<_Point>();
            _Point compPos;
            _Point ppos;

            ppos = new _Point();
            ppos.SetPointPos(2, 1);
            list.Add(ppos);
            ppos.SetPointPos(2, 2);
            list.Add(ppos);

            ppos.SetPointPos(3, 1);
            list.Add(ppos);

            ppos.SetPointPos(3, 2);
            list.Add(ppos);

            Console.WriteLine("현재 데이터의 수: {0}", list.Count);

            foreach (_Point i in list)
            {
                i.ShowPointPos();
            }

            //
            compPos.xpos = 2;
            compPos.ypos = 0;

         
            for(int i=0; i<list.Count; i++)
            {
                if (ppos.PointComp(list[i], compPos) == 1)
                {
                    //x값이 같을 경우1
                    list.RemoveAt(i);
                    i -= 1;

                }
            }
            //삭제 후 남은 데이터 전체 출력///
            Console.WriteLine("현재 데이터의 수: {0}", list.Count);
            
            for(int i=0; i<list.Count; i++)
            {
                list[i].ShowPointPos();
            }
        }

    }


}
