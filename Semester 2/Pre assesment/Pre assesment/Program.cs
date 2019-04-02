using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pre_assesment
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;


            do
            {
                Console.WriteLine("to say hello world = 1");
                Console.WriteLine("To make a sum of ints = 2");
                Console.WriteLine("To calculate area of circle = 3");
                Console.WriteLine("To calculatre area of triange = 4");
                Console.WriteLine("To draw a square = 5");
                Console.WriteLine("To draw a hollow square = 6");
                Console.WriteLine("To swap = 7");
                Console.WriteLine("To reverse a string = 8");
                Console.WriteLine("To leave program = 9");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Hello world");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Input a integer");
                        int int1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input a second integer");
                        int int2 = int.Parse(Console.ReadLine());
                        int int3 = int1 + int2;
                        Console.WriteLine(int3);
                        break;
                    case 3:
                        Console.WriteLine("Input a radius please");
                        int radius = int.Parse(Console.ReadLine());
                        double area = Math.PI * Math.Pow(radius, 2);
                        
                        break;
                    case 4:
                        Console.WriteLine("Input side 1");
                        int side1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input side 2");
                        int side2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input side 3");
                        int side3 = int.Parse(Console.ReadLine());

                        int x = side1 + side2 + side3;
                         int s = x / 2;
                       Console.WriteLine( Math.Sqrt(s*(s - side1)*(s - side2) *(s - side3)));
                        break;
                    case 5:
                        Console.WriteLine("Please input the width");
                        int width = int.Parse(Console.ReadLine());
                        for(int i = 0; i < width; i++)
                        {
                            Console.Write(" x");

                            for (int o = 0; o < width -1;  o++)
                            {
                                Console.Write(" x");
                                
                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Please input the width");
                        int hollow = int.Parse(Console.ReadLine());
                        for (int i = 0; i < hollow; i++)
                        {

                            for (int o = 0; o < hollow; o++)
                            {
                                if (i == 0)
                                {
                                    Console.Write("x");
                                }
                                else if (i != 0 && i != hollow -1 && (o == 0 || o == hollow - 1))
                                {
                                    Console.Write("X");
                                }
                                else if (i == hollow -1)
                                {
                                    Console.Write("X");
                                }
                                else {Console.Write(" "); }
                            }
                            
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("input a value to swap");
                        int yeet = int.Parse(Console.ReadLine());
                        Console.WriteLine("input a second value to swap");
                        int swap = int.Parse(Console.ReadLine());
                        int temp = yeet;
                        yeet = swap;
                        swap = temp;
                        Console.WriteLine(yeet);
                        Console.WriteLine(swap);
                        break;
                    case 8:
                        Console.WriteLine("Please input a string");
                        string reverse = Console.ReadLine();
                        for (int i = reverse.Length -1 ; i >= 0; i--)
                        {
                            Console.Write(reverse[i]);
                        }
                        Console.WriteLine();
                        break;
                }
            } while (option != 9);
        }
    }
}
