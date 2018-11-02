using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGresham_competencyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int optFirst = 0;
            do
            {
                Console.WriteLine("==========================================================|");
                Console.WriteLine("^Enter in the value of the action you want to take        |");
                Console.WriteLine("^^ Input 1 if you would like to see conditionals          |");
                Console.WriteLine("^^ Input 2 if you would like to see for loops             |");
                Console.WriteLine("^^ Input 3 if you would like to see while loops           |");
                Console.WriteLine("^^ Input 4 if you would like to see arrays                |");
                Console.WriteLine("^^ Input 5 if you would like to see lists                 |");
                Console.WriteLine("^^ Input -1 if you would like to leave the program        |");
                Console.WriteLine("==========================================================|");
                optFirst = int.Parse(Console.ReadLine());
                if (optFirst == 1)
                {
                    int grade;
                    int readingLevel;
                    Console.Write("Enter your grade: ");
                    grade = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("What is your reading level?: ");
                    readingLevel = int.Parse(Console.ReadLine());
                    if(grade <= 5)// finds if they are in elementary
                    {
                        if(readingLevel < grade)
                        {
                            Console.WriteLine("You are in elementary school but are lacking in the reading. Go read some books");
                        }
                        else
                        {
                            Console.WriteLine("You are in elementary school and at a great reading level.");
                        }

                    }
                    else if(grade <= 8)// finds if they are in middle school
                    {
                        if (readingLevel < grade)
                        {
                            Console.WriteLine("You are in middle school but are lacking in the reading. Go read some books");
                        }
                        else
                        {
                            Console.WriteLine("You are in middle school and at a great reading level.");
                        }
                    }
                    else// finds if they are in highschool
                    {
                        if (readingLevel < grade)
                        {
                            Console.WriteLine("You are in high school but are lacking in the reading. Go read some books");
                        }
                        else
                        {
                            Console.WriteLine("You are in high school and at a great reading level.");
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                if(optFirst == 2)// if they choose opt 2
                {
                    int countTo;// initialize variables
                    int countBy;
                    // finds what they want to count to/ by
                    Console.Write("please select a number to count by: ");
                    countBy = int.Parse(Console.ReadLine());
                    Console.Write("Please select a number you would like to count to: ");
                    countTo = int.Parse(Console.ReadLine());
                    // as long as i is less than the number we are counting to
                    for (int i = 0; i <= countTo;)
                    {
                        Console.WriteLine(i);
                        i = i + countBy;
                        
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                if(optFirst == 3)
                {
                    int input = -1;
                    int newSum = 0;
                    Console.WriteLine("Our sum starts at 0 - please add up the integers until you are satisfied. then hit 0 to exit ");

                    do

                    {
                        Console.Write("Add a integer: ");
                        input = int.Parse(Console.ReadLine());

                        newSum = input + newSum;

                        Console.WriteLine("New sum is: " + newSum);
                           
                            
                            }
                    while (input != 0);
                    Console.WriteLine("Your final sum is: "+newSum);
                    Console.ReadKey();
                    Console.Clear();
                }
                if(optFirst == 4)
                {
                    int j;
                    int[] userArray = new int[10];
                    for(int i = 0; i <= userArray.Length - 1; i++)
                    {
                        Console.Write("Please add an integer to the array: ");
                        j = int.Parse(Console.ReadLine());
                        Console.WriteLine("Successfully added!");
                        userArray[i] = j;
                    }
                    for (int i = 0; i <= userArray.Length - 1; i++) 
                    {
                        Console.WriteLine("Index ["+i+"] ="+userArray[i]);
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                if (optFirst == 5)
                {
                    List<string> userList = new List<string>();
                    string userString = " ";
                    Console.WriteLine("welcome to your list! please input strings until you are satisfied, then type end. This will shut down the list section of the program.");

                    int counter = 0;
                    do
                        {
                       
                            Console.Write("Please Input a String!: ");
                            userString = Console.ReadLine();

                            if(userString != "end")
                            {
                            userList.Add(userString);
                            counter++;
                            }
                             

                           
                        }
                        while (userString != "end");
                    for(int i =0; i <= counter - 1; i ++)
                    {
                        Console.WriteLine("Value [" + i + "] for the list is = " + userList[i]);
                    }
                    Console.ReadKey();
                    Console.Clear();
                }





            } while (optFirst != -1) ;
           


        }
    }
}
