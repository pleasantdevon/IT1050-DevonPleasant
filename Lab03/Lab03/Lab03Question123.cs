using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {//2. The comparison between an If statement and a While statement is that they both are considered to provide an output based on a true or false input. 
         //The differences would be that an If statement is just a single true or false answer. 
         //When utilizing the while statement, although it is based on true/false it is a repeated statement that continues to run as long as the statement is true 
         //but ends once the statement reaches a false outcome. 

            int speedLimit = 35;
            int speed = 42;
           

         if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }
                Console.ReadLine();
            
        }
        
        
    }

}

