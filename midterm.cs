using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;

            while (i <= 64)

            {

                {

                    if ((i % 2) == 0)

                    {

                        Console.WriteLine("[{0}]", i);

                    }

                    else if ((i % 2) != 0)

                    {

                        Console.Write("");

                    }

                    i *= 2;

                }

            }
        }
    }
}
