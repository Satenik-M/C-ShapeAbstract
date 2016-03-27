using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAbstract
{
    class RightTriangle : Shape
    {
        /*the methods are designed for the specific case when triangle's legs are equal, ie height=width*/
        public override void Paint()
        {
            for (int i = 1; i <= this.Height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public override void Draw()
        {
            for (int i = 1; i <= Height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == Height)
                    {
                        Console.Write("*");
                    }
                    else if (j==1||j==i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
