using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Input  number");
             int   x = Convert.ToInt32(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("given number is negative");
                    Console.ReadLine(); 
                }
                else if (x > 0)
                {
                    Console.WriteLine("given number is positive");
                    Console.ReadLine();
                  
                }
                else if (x == 0)
                {
                    Console.WriteLine("given number is not a positive or not a negative number");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("please enter number");
                    Console.ReadLine();
                }
                   


                //int x, y;
                //char operation;

                //Console.Write("Input first number: ");
                //x = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Input operation: ");
                //operation = Convert.ToChar(Console.ReadLine());
                //Console.Write("Input second number: ");
                //y = Convert.ToInt32(Console.ReadLine());

                //if (operation == '+')
                //{
                //    Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                //    Console.ReadLine();
                //}


                //else if (operation == '-')
                //{
                //    Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                //    Console.ReadLine();
                //}
                //else if ((operation == 'x') || (operation == '*'))
                //{
                //    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                //    Console.ReadLine();
                //}
                //else if (operation == '/')
                //{
                //    Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                //    Console.ReadLine();
                //}
                //else
                //    Console.WriteLine("Wrong Character");


                //Console.WriteLine("Entter the firstnumber");
                //int a = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Entter the firstnumber");
                //int b = Convert.ToInt32(Console.ReadLine());

                //if (a==b)
                //{
                //    Console.WriteLine("both a = " + a + " and b = " + b + " are Equal");
                //    Console.ReadLine();
                //}
                //else
                //{
                //    Console.WriteLine("both a = " + a + " and b = " + b + " are not Equal");
                //    Console.ReadLine();
                //}


            }

        }
    }
}
