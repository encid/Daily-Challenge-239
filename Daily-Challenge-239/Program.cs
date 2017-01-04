using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyChallenge239
{
    class Program
    {
        static void Main()
        {
            int num;
            string input;

            Console.WriteLine("Game of Threes");            

            do {
                Console.Write("Input a number: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out num));

            Calc(num);
                                        
            Console.ReadKey();
        }

        static void Calc(int num)
        {
            //do {
	           // if (num % 3 == 0) {
            //        Console.WriteLine("{0} 0", num);
            //        num = num / 3;
	           // }
	           // else {
	           //     if ((num + 1) % 3 == 0) {
            //            Console.WriteLine("{0} 1", num);
            //            num = (num + 1) / 3;	                    
	           //     }
	           //     else {
            //            Console.WriteLine("{0} -1", num);
            //            num = (num - 1) / 3;	                    
	           //     }
	           // }
            //} while (num != 1);
            //Console.WriteLine("1");


            while (num != 1 && num != 0) {
                if (num % 3 == 0) {
                    Console.WriteLine("{0} 0", num);
                    num = num / 3;
                }
                else {
                    if ((num + 1) % 3 == 0) {
                        Console.WriteLine("{0} 1", num);
                        num = (num + 1) / 3;
                    }
                    else {
                        Console.WriteLine("{0} -1", num);
                        num = (num - 1) / 3;
                    }
                }
            }
            Console.WriteLine("1");

            //return num;
        }
    }
}
