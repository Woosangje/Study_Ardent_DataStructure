using System;
using System.Collections;
using System.Collections.Generic;
namespace DS_Point {
    //DS03_01PointListMain 사용중
    class Point
    {

        public int xpos;
        public int ypos;

        public Point(int x, int y)
        => (xpos, ypos) = (x, y);

        public void ShowPointPos()
        {
            Console.WriteLine("[{0}, {1}]", this.xpos, this.ypos);
        }

        public int PointComp(Point pos1, Point pos2)//21 20
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


}
