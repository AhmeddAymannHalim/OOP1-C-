using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }



        public static void CaluclateDistance(int x1, int x2, int y1, int y2)
        {
            int DistanceX = x2 - x1;
            int DistanceY = y2 - y1;
            Console.WriteLine($"Distance Between X ={DistanceX} ");
            Console.WriteLine($"Distance Between Y ={DistanceY} ");

        }



    }
}
