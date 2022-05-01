using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
         /*
         *Basic Syntax for c#:
         *1. Console prints and inputs
         *2. Variables
         *3. DataTypes
         */

        // 1. Console prints
            // Prints "Hello, World" to the console.
            Console.WriteLine("Hello World!");
            Console.WriteLine("Console.WriteLine :Similar to println gives a new line");
            Console.Write("Hello World!");
            Console.Write("--- Console.Write :Similar to print continue from sane line");
            Console.WriteLine();


         // 2. Variables
         int a = 10;
         int b = 10;
         Console.WriteLine(a + b);

        // 3. DataTypes
        // Integer - int a = 10;
        // Floating point number - float b;
        // Character - char c = 'a';
        // Boolean - bool d = true;
        // String - string imp = "Prasun"

        int c = 10;
        float d = 34.4F;
        
        Console.WriteLine(c + d);

    //Type casting

    /**
     * There are 2types of type casting:
     * 1. Implicit casting
     * -> char to int to long to float to double
     * -> C# does this internally
     */
    int f = 3;
    double g = f;

    /*
     * 2. Explicit casting
     * -> We does this manually
     */
     int e = (int) 3.5;
     Console.WriteLine(e);

    // TypeCasting with inbuilt methods
    float var = Convert.ToInt32(3.55);

            //Taking inputs
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
        //Keeps the console open
         Console.ReadLine();
        }
    }
}
 