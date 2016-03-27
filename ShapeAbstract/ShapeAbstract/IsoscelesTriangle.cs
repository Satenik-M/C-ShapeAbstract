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
    }
}
