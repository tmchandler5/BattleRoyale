using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1;
using Homework1.Math;


namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            String A = "Sadie";
            String B = " jumps";
            String C = " over";
            String D = " the";
            String E = " slow";
            String F = " white";
            String G = " fox.";

            Console.WriteLine(A + B + C + D + E + F + G);

            //1.2
            string[] myArray = new string[]
            {
                "Sadie", "jumps", "over", "the", "slow", "white", "fox"
            };

            for (int x = 0; x < myArray.Count(); x++)
            {
                Console.Write(myArray[x]+ " ");
                if(x == myArray.Count() - 1)
                    Console.WriteLine();
            }
        




            //2
            for (int x = 1; x <= 10; x++)
            {
                String numA = new String('A', x);
                Console.WriteLine(numA);
            }

            //3
            for (int y = 0; y <= 100; y++)
            {
                if (y % 2 == 0)
                { }
                else
                    Console.WriteLine(y);
            }

            MathStuff myMathStuff = new MathStuff();

            MathStuff myMathStuff2 = new MathStuff(55);


            //2.1
            Console.WriteLine(myMathStuff.addToMavisTailLength(6));

            //4
            Console.WriteLine("Please enter a string:");
            Console.WriteLine(myMathStuff.addToMavisTailLength(Int32.Parse(Console.ReadLine())));

            

            Console.WriteLine("Please enter a integer:");
            int inputOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another integer:");
            int inputTwo = Int32.Parse(Console.ReadLine());

            Console.WriteLine(MathStuff.product1(inputOne, inputTwo));


            System.Threading.Thread.Sleep(999999);
        }
        
        
        
    }
}
