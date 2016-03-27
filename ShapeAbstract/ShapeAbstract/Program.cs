using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //RightTriangle tr = new RightTriangle();
            //tr.Height = 5;
            //tr.Draw();
            //Console.WriteLine();
            //tr.Paint();


            Rectangle r = new Rectangle();
            r.Height = 5;
            r.Width = 10;
            r.Paint();
            Console.WriteLine();
            r.Draw();
            Console.ReadLine();
        }
    }
}
