using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAbstract
{
    class IsoscelesTriangle : Shape
    {
        public override void Paint()
        {
            for (int i = 1; i <= Height; i++)
            {
                for (int j = 1; j <= Height; j++)
                {
                    if ((j <= Height - i))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }
                Console.WriteLine();

            }
        }

        public override void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 1; j <2*Height; j++)
                {
                    if (i==(Height-1))
                    {
                        Console.Write("*");
                    }
                    else if ((j == Height - i)||(j==Height+i))
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
        public IsoscelesTriangle(int height)
        {
            this.Height = height;
        }
    }
}
