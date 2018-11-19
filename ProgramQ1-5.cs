using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        { //2. The four basic elements of the counter-controlled repetition are 1. a control variable (or loop counter) 2. the control variable's initial value 3. the control variable's increment that's applied during each iteration of the loop 4. the loop-continuation condition that determines if looping should continue.
          //3. When comparing and contrasting the while and for iteration statement the while statement can be used to implement any counter-controlled loop by running until the statement is false over multiple lines. As for the for repetition statement it specifies the four elements of a counter-controlled iteration in a single line ofcode. Usually the while statement is used for your sentinel-controlled iterations,although the for and while statements can be used to implement both iterations. 
          //4. An example when it would be more appropriate to use a do-while statement rather than a while statement in the case you need to run the block at least one time or to run a series of loops until you get a true result.
            for (int i = 1; i <= 100; ++i)
            {
                Console.WriteLine(i);
               if ((i%2) == 0)
                {
                    Console.WriteLine("It's Even!");
                }
               else
                {
                    Console.WriteLine("It's Odd!");
                }
            }
            Console.ReadLine();
        }
    }
}
