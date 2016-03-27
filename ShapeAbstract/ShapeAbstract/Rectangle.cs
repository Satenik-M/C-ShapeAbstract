using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAbstract
{
    class Rectangle : Shape
    {
        public override void Paint()
        {
            for (int i = 1; i <= Height; i++)
            {
                for (int j = 1; j <= Width; j++)
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
                for (int j = 1; j <= Width; j++)
                {
                    if (i==1||i==Height)
                    {
                        Console.Write("*");
                    }
                    else if (j==1||j==Width)
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
