using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ScharpExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //--------------------------------------------------- CSharp Exercises Part 1 (basic concept and if statement)
            // 1. Even or Odd 
            //int num;
            //int Res;

            //Console.WriteLine("Enter the number:");
            //num = int.Parse(Console.ReadLine());

            //Res = num % 2;

            //if (Res == 0)
            //{
            //    Console.WriteLine("The number is Even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}

            //----------------------------------------------------


            // 2. Largest of Three Numbers

            //int num1;
            //int num2;
            //int num3;

            //Console.WriteLine("Enter first number:" );
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number:");
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter third number:");
            //num3 = int.Parse(Console.ReadLine());

            //if (num1>num2 && num1>num3) 
            //{
            //    Console.WriteLine(num1 + " is the largest number");
            //}

            //else if (num2 > num1 && num2 > num3)
            //{
            //    Console.WriteLine(num2 + " is the largest number");
            //}

            //else 
            //{
            //    Console.WriteLine(num3 +" is the largest number");
            //}

            //---------------------------------------------------------------------------------------

            //3. Temperature Converter

            //float C;
            //float F;
            //Console.WriteLine("\nEnter the dgree of temerature in Celsius:\n");

            //C = float.Parse(Console.ReadLine());

            //F = (C * 9 / 5) + 32;

            //Console.WriteLine("\nthe " +C+ " Celsius degree in Fahrenheit is " + F);

            //-------------------------------------------------------------------------------------

            // 4. Simple Discount Calculator
            // it dose not work until i put the douple as the data type 
            //double price;
            //double discount;
            //double disprice;
            //Console.WriteLine("\nEnter the price: \n");
            //price = double.Parse(Console.ReadLine());

            //if (price > 100)
            //{
            //    discount = price * 0.10;
            //    disprice = price - discount;
            //    Console.WriteLine("\nFinal price is: \n" + disprice);

            //}
            //else
            //{
            //    Console.WriteLine("\nFinal price is: \n" + price);

            //}

            //----------------------------------------------------------------------------------

            //5.Grading System

            //int Mark;
            //Console.WriteLine("Enter Your Mark:\n");
            //Mark = int.Parse(Console.ReadLine());

            //if (Mark >= 90 && Mark <= 100)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (Mark >= 80 && Mark <= 89)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (Mark >= 70 && Mark <= 79)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (Mark >= 60 && Mark <= 69)
            //{
            //    Console.WriteLine("D");
            //}
            //else
            //{
            //    Console.WriteLine("F");
            //}

            //Or Or Or Or 

            //int Mark;
            //char grade;
            //Console.WriteLine("Enter Your Mark:\n");
            //Mark = int.Parse(Console.ReadLine());

            //if (Mark >= 90)
            //    grade = 'A'
            //else if (Mark >= 80)
            //    grade = 'B'
            //else if (Mark >= 70)
            //    grade = 'C'
            //else if (Mark >= 60)
            //    grade = 'D'
            //else
            //    grade = 'F'

            //Console.WriteLine(grade);

            //----------------------------------------------------------------------------

            // 6. Swap Two Numbers

            //int num1;
            //int num2;
            //int hold;

            //Console.WriteLine("Enter First Number:\n");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Second Number:\n");
            //num2 = int.Parse(Console.ReadLine());

            //hold = num1;
            //num1 = num2;
            //num2 = hold;

            //Console.WriteLine("First number is " + num1 + " Second number is " + num2);

            //---------------------------------------------------------------------------------

            //7.Days to Weeks and Days Converter

            //int UserDays;
            //int week;
            //int days;
            //Console.WriteLine("Enter the number of days :\n");
            //UserDays = int.Parse(Console.ReadLine());
            //week = UserDays / 7;
            //days = UserDays % 7;

            //Console.WriteLine(week + " weeks and " + days + " days");

            //-----------------------------------------------------------------

            //8.Electricity Bill Calculator

            //double NumberUnitsConsume;
            //double ElectricityBill;
            //Console.WriteLine("Enter the number of units consume :\n");
            //NumberUnitsConsume = float.Parse(Console.ReadLine());

            //if (NumberUnitsConsume <= 100)
            //{
            //    ElectricityBill = NumberUnitsConsume * 0.5;
            //    Console.WriteLine("The Electricity Bill is: " + ElectricityBill);

            //}

            //else if (NumberUnitsConsume >= 101 && NumberUnitsConsume <= 300)
            //{
            //    ElectricityBill = NumberUnitsConsume * 0.75;
            //    Console.WriteLine("The Electricity Bill is: " + ElectricityBill);
            //}

            //else
            //{
            //    ElectricityBill = NumberUnitsConsume * 1;
            //    Console.WriteLine("The Electricity Bill is: " + ElectricityBill);
            //}

            //--------------------------------------------------------------------------

            //9.Simple Calculator

            //float num1;
            //float num2;
            //char operation;
            //float res;
            //Console.WriteLine("Enter First Number:\n");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Second Number:\n");
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the operation:\n");
            //operation = Console.ReadKey().KeyChar;

            //if (operation = "+")
            //{
            //    res = num1 + num2;
            //    Console.WriteLine("The result is: " + res);

            //}

            //else if (operation = "*")
            //{
            //    res = num1 * num2;
            //    Console.WriteLine("The result is: " + res);
            //}

            //else if (operation = "-")
            //{
            //    res = num1 - num2;
            //    Console.WriteLine("The result is: " + res);
            //}

            //else if (operation = "/")
            //{
            //    if (num2 != 0)
            //    {
            //        res = num1 / num2;
            //        Console.WriteLine("The result is: " + res);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Can not devided by 0");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("the operation is unavilable");
            //}

            //---------------------------------------------------------- CSharp Part2 Exercises
            //1. . Simple Calculator (Switch-Case) 

            //char choice;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Enter the operation number :\n1. Addition\n2. Subtraction ");
            //    Console.WriteLine("3. Multiplication\n4. Division");

            //    int operation = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter first number :");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter first number :");
            //    int num2 = int.Parse(Console.ReadLine());


            //    double res = 0;

            //    bool isActive = false;

            //    switch (operation)
            //    {


            //        case 1:
            //            res = num1 + num2;
            //            break;

            //        case 2:
            //            res = num1 - num2;
            //            break;

            //        case 3:
            //            res = num1 * num2;
            //            break;

            //        case 4:

            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Division by zero not allowed");
            //                isActive = true;

            //            }
            //            else
            //            {
            //                res = num1 / num2;
            //            }

            //            break;

            //        default:
            //            Console.WriteLine("Wrong Choice");
            //            isActive = true;
            //            break;
            //    }


            //    if (!isActive)
            //    {
            //        Console.WriteLine(res);
            //    }

            //    Console.WriteLine("Do you want another operation ? y / n");
            //    choice = Console.ReadKey().KeyChar;

            //} while (choice == 'y' || choice == 'Y');

            //Console.WriteLine("\ngood bye");

            //---------------------------------------------------------------------
            //2.  Basic ATM System

            //char choice;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Display a menu with options:\n");
            //    Console.WriteLine(" 1. Withdraw Money \n 2. Deposit Money\n 3. Check Balance\n 4. Exit ");
            //    int option = int.Parse(Console.ReadLine());
            //    double FinalBalance = 0;
            //    double balance = 1000;
            //    switch (option)
            //    {
            //        case 1:
            //            Console.WriteLine(" Enter the The Money you want withdraw it :");
            //            double withdraw = double.Parse(Console.ReadLine());
            //            FinalBalance = balance - withdraw;
            //            Console.WriteLine("your current balance is " + FinalBalance);
            //            break;

            //        case 2:
            //            Console.WriteLine(" Enter the The Money you want deposit it :");
            //            double deposit = double.Parse(Console.ReadLine());
            //            FinalBalance = balance + deposit;
            //            Console.WriteLine("your current balance is " + FinalBalance);
            //            break;

            //        case 3:
            //            Console.WriteLine(" Your Current Balane is :" + balance);
            //            break;

            //        case 4:
            //            Console.WriteLine("\ngood bye");
            //            break;

            //        default:
            //            Console.WriteLine("Wrong Choice");
            //            break;
            //    }

            //    Console.WriteLine("Do you want another operation ? y / n");
            //    choice = Console.ReadKey().KeyChar;


            //} while (choice == 'y' || choice == 'Y');

            //Console.WriteLine("\ngood bye");

            //-------------------------------------------------------------------------------------------
            //3.  Geometry Calculator 
            //char choice;
            //do
            //{
            //    //Console.Clear();
            //    Console.WriteLine("choice the shape:\n 1. Circle\n 2. Square\n 3. Triangle");
            //    int option = int.Parse(Console.ReadLine());

            //    switch(option)
            //    {
            //        case 1:
            //            Console.WriteLine("Please Enter the value of Radius: ");
            //            double radius = double.Parse(Console.ReadLine());
            //            double CircleArea = 3.14 * (radius * radius * radius);
            //            double CircleCircumference = 2 * 3.14 * radius;
            //            Console.WriteLine("The Circle Area is " + CircleArea);
            //            Console.WriteLine("The Circle Area is " + CircleCircumference);
            //            break;

            //        case 2:
            //            Console.WriteLine("Please Enter the value of hight: ");
            //            double hight = double.Parse(Console.ReadLine());
            //            double SquareArea = hight * hight;
            //            double SequarePerimeter = 4*hight;
            //            Console.WriteLine("The Square Area is " + SquareArea);
            //            Console.WriteLine("The Square Perimeter is " + SequarePerimeter);
            //            break;

            //        case 3:
            //            Console.WriteLine("Please Enter the value of hight: ");
            //            double hight2 = double.Parse(Console.ReadLine());
            //            Console.WriteLine("Please Enter the value of width: ");
            //            double base2 = double.Parse(Console.ReadLine());
            //            double TriangleArea = 0.5 * hight2 * base2;
            //            Console.WriteLine("The Triangle Area is " + TriangleArea);
            //            break;
            //        default:
            //            Console.WriteLine("The Choice is wrong");
            //            break;
            //    }
            //    Console.WriteLine("Do you want another operation ? y / n");
            //    choice = Console.ReadKey().KeyChar;
            //} while (choice == 'y' || choice == 'Y');
            //Console.WriteLine("\ngood bye");

            //-------------------------------------------------------------------------------------
            //4.  Factorial of a Number
            //Console.WriteLine("Please Enter the Number : \n");
            //int num = int.Parse(Console.ReadLine());
            //int Factorial =1;

            //for (int Counter = num; Counter >= 1; Counter--)
            //{
            //    Factorial = Factorial * Counter;

            //}
            //Console.WriteLine("The Factorial of a Number "+ num + " is \n"+ Factorial);

            //-----------------------------------------------------------------------------------
            //5.Sum of Even and Odd Numbers 
            //Console.WriteLine("Please Enter the Number : \n");
            //int num = int.Parse(Console.ReadLine());
            //int SumOdd = 0;
            //int SumEven = 0;
            //for (int i =1; i <=num; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        SumEven = SumEven + i;
            //    }

            //    else
            //    {
            //        SumOdd = SumOdd + i;
            //    }
            //}
            //Console.WriteLine("The Sum Of Even Numbers is " + SumEven);
            //Console.WriteLine("The Sum Of Odd Numbers is " + SumOdd);

            //---------------------------------------------------------------------------------------
            //6.  Scientific Calculator (Switch-Case & Math Functions)

            //char choice;
            //do
            //{
            //    //Console.Clear();
            //    double res;
            //    Console.WriteLine("choice the operation:\n 1. sin\n 2.cos\n 3.tan\n 4.sqrt\n 5.log\n 6.pow");
            //    int option = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Please Enter the Value:");
            //    double Num = double.Parse(Console.ReadLine());

            //    switch (option)
            //    {
            //        case 1:
            //            res = Math.Sin(Num);
            //            Console.WriteLine("Sin of input = " + res);
            //            break;

            //        case 2:
            //            res = Math.Cos(Num);
            //            Console.WriteLine("Cos of input = " + res);
            //            break;

            //        case 3:
            //            res = Math.Tan(Num);
            //            Console.WriteLine("Tan of input = " + res);
            //            break;
            //        case 4:
            //            res = Math.Sqrt(Num);
            //            Console.WriteLine("Sqrt of input = " + res);
            //            break;
            //        case 5:
            //            res = Math.Log(Num);
            //            Console.WriteLine("Lof of input = " + res);
            //            break;
            //        case 6:
            //            Console.WriteLine("Please Enter the exponent Value:");
            //            double exponent = double.Parse(Console.ReadLine());
            //            res = Math.Pow(Num, exponent);
            //            Console.WriteLine("Power of input = " + res);
            //            break;

            //        default:
            //            Console.WriteLine("The Choice is wrong");
            //            break;
            //    }
            //    Console.WriteLine("Do you want another operation ? y / n");
            //    choice = Console.ReadKey().KeyChar;
            //} while (choice == 'y' || choice == 'Y');
            //Console.WriteLine("\ngood bye");

            //------------------------------------------------------------------------------------
            //7. Print Pattern (For Loop)
            //Console.WriteLine("Enter the number of line: \n");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //----------------------------------------------------------------------

            //8. Print a Pyramid Pattern (For Loop)
            //Console.WriteLine("Enter the number of line: \n");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    for (int j = i; j <= num; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //-----------------------------------------------------------------------
            //9. Print a Diamond Pattern (For Loop)

            // Console.WriteLine("Enter the number of line: \n");
            // int num = int.Parse(Console.ReadLine());
            //// Upper half of the diamond
            // for (int i = 1; i <= num; i++)
            // {
            //     for (int j = i; j < num; j++)
            //     {
            //         Console.Write(" ");
            //     }


            //     for (int j = 1; j <= (2 * i - 1); j++)
            //     {
            //         Console.Write("*");
            //     }

            //     Console.WriteLine();
            // }

            // // Lower half of the diamond
            // for (int i = num - 1; i >= 1; i--)
            // {
            //     for (int j = num; j > i; j--)
            //     {
            //         Console.Write(" ");
            //     }

            //     for (int j = 1; j <= (2 * i - 1); j++)
            //     {
            //         Console.Write("*");
            //     }

            //     Console.WriteLine();
            // }

            //-----------------------------------------------------------------------------
            //10. Guess Game with helper
            //Random rng = new Random();

            //int num = 0;
            //int rand = rng.Next(1,101);
            //do
            //{
            //    Console.WriteLine("Enter your Guess");
            //    num = int.Parse(Console.ReadLine());

            //    if (num > rand)
            //    {
            //        Console.WriteLine("Try Lower!");
            //    }
            //    else if (num < rand)
            //    {
            //        Console.WriteLine("Try Higher!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You Win!");
            //    }
            //}
            //while (num != rand);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSelect A Task: ");
                Console.WriteLine("2.Task 2 (Foor Loop)");
                Console.WriteLine("3.Task 3 (Array)");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your task choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice){
                    case 2: ChoiceTask2FooeLoop(); break;
                    case 3: ChoiceTask3Array(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid Choice! Try again."); break;
                }
                Console.ReadLine();

            }

            

            


        }

        //choice tasks in tasks 2 (for loop)
        static void ChoiceTask2FooeLoop()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSelect a Program:");
                Console.WriteLine("1. Simple Calculator");
                Console.WriteLine("2. Basic ATM System");
                Console.WriteLine("3. Geometry Calculator");
                Console.WriteLine("4. Factorial of a Number");
                Console.WriteLine("5. Sum of Even and Odd Numbers");
                Console.WriteLine("6. Scientific Calculator");
                Console.WriteLine("7. Print Triangle Pattern");
                Console.WriteLine("8. Print Pyramid Pattern");
                Console.WriteLine("9. Print Diamond Pattern");
                Console.WriteLine("10. Guess the Number Game");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your program choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: SimpleCalculator(); break;
                    case 2: BasicATM(); break;
                    case 3: GeometryCalculator(); break;
                    case 4: Factorial(); break;
                    case 5: SumEvenOdd(); break;
                    case 6: ScientificCalculator(); break;
                    case 7: PrintTriangle(); break;
                    case 8: PrintPyramid(); break;
                    case 9: PrintDiamond(); break;
                    case 10: GuessGame(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid Choice! Try again."); break;
                }
                Console.ReadLine();
            }
        }

        //choice tasks in tasks 3 (Array)
        static void ChoiceTask3Array()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSelect a Program:");
                Console.WriteLine("1. Array Initialization And Output");
                Console.WriteLine("2. Find Maximum & Minimum in an Array");
                Console.WriteLine("3. Count Even & Odd Numbers");
                Console.WriteLine("4. Reverse an Array");
                Console.WriteLine("5. Search for a Number in an Array");
                Console.WriteLine("6. Sorting an Array (Ascending Order)");
                Console.WriteLine("7. Merging Two Arrays ");
                Console.WriteLine("8. Remove Duplicates from an Array");
                Console.WriteLine("9. Second Largest Number in an Array");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: ArrayInitializationOutput(); break;
                    case 2: MaximumMinimumInAnArray(); break;
                    case 3: CountEvenAndOddNumbers(); break;
                    case 4: ReverseArray(); break;
                    case 5: SearchForNumberInArray(); break;
                    case 6: SortingAnArray(); break;
                    case 7: MergingTwoArrays(); break;
                    case 8: RemoveDuplicatesFromAnArray(); break;
                    case 9: SecondLargestNumberInAnArray(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid Choice! Try again."); break;
                }
                Console.ReadLine();
            }
        }

        //-----------------------------------------------------------------------------------Task 2 (Foor Loop)

        // 1. Simple Calculator
        static void SimpleCalculator()
        {
            char choice;

            do
            {
                //Console.Clear();
                Console.WriteLine("Enter the operation number :\n1. Addition\n2. Subtraction ");
                Console.WriteLine("3. Multiplication\n4. Division");

                int operation = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter first number :");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter first number :");
                int num2 = int.Parse(Console.ReadLine());


                double res = 0;

                bool isActive = false;

                switch (operation)
                {


                    case 1:
                        res = num1 + num2;
                        break;

                    case 2:
                        res = num1 - num2;
                        break;

                    case 3:
                        res = num1 * num2;
                        break;

                    case 4:

                        if (num2 == 0)
                        {
                            Console.WriteLine("Division by zero not allowed");
                            isActive = true;

                        }
                        else
                        {
                            res = num1 / num2;
                        }

                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        isActive = true;
                        break;
                }


                if (!isActive)
                {
                    Console.WriteLine(res);
                }

                Console.WriteLine("Do you want another operation ? y / n");
                choice = Console.ReadKey().KeyChar;

            } while (choice == 'y' || choice == 'Y');

            Console.WriteLine("\ngood bye");
        }

        // 2. Basic ATM System
        static void BasicATM()
        {
            char choice;

            do
            {
                //Console.Clear();
                Console.WriteLine("Display a menu with options:\n");
                Console.WriteLine(" 1. Withdraw Money \n 2. Deposit Money\n 3. Check Balance\n 4. Exit ");
                int option = int.Parse(Console.ReadLine());
                double FinalBalance = 0;
                double balance = 1000;
                switch (option)
                {
                    case 1:
                        Console.WriteLine(" Enter the The Money you want withdraw it :");
                        double withdraw = double.Parse(Console.ReadLine());
                        FinalBalance = balance - withdraw;
                        Console.WriteLine("your current balance is " + FinalBalance);
                        break;

                    case 2:
                        Console.WriteLine(" Enter the The Money you want deposit it :");
                        double deposit = double.Parse(Console.ReadLine());
                        FinalBalance = balance + deposit;
                        Console.WriteLine("your current balance is " + FinalBalance);
                        break;

                    case 3:
                        Console.WriteLine(" Your Current Balane is :" + balance);
                        break;

                    case 4:
                        Console.WriteLine("\ngood bye");
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }

                Console.WriteLine("Do you want another operation ? y / n");
                choice = Console.ReadKey().KeyChar;


            } while (choice == 'y' || choice == 'Y');

            Console.WriteLine("\ngood bye");
        }

        // 3. Geometry Calculator
        static void GeometryCalculator()
        {
            char choice;
            do
            {
                //Console.Clear();
                Console.WriteLine("choice the shape:\n 1. Circle\n 2. Square\n 3. Triangle");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please Enter the value of Radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        double CircleArea = 3.14 * (radius * radius * radius);
                        double CircleCircumference = 2 * 3.14 * radius;
                        Console.WriteLine("The Circle Area is " + CircleArea);
                        Console.WriteLine("The Circle Area is " + CircleCircumference);
                        break;

                    case 2:
                        Console.WriteLine("Please Enter the value of hight: ");
                        double hight = double.Parse(Console.ReadLine());
                        double SquareArea = hight * hight;
                        double SequarePerimeter = 4 * hight;
                        Console.WriteLine("The Square Area is " + SquareArea);
                        Console.WriteLine("The Square Perimeter is " + SequarePerimeter);
                        break;

                    case 3:
                        Console.WriteLine("Please Enter the value of hight: ");
                        double hight2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter the value of width: ");
                        double base2 = double.Parse(Console.ReadLine());
                        double TriangleArea = 0.5 * hight2 * base2;
                        Console.WriteLine("The Triangle Area is " + TriangleArea);
                        break;
                    default:
                        Console.WriteLine("The Choice is wrong");
                        break;
                }
                Console.WriteLine("Do you want another operation ? y / n");
                choice = Console.ReadKey().KeyChar;
            } while (choice == 'y' || choice == 'Y');
            Console.WriteLine("\ngood bye");
        }

        // 4. Factorial
        static void Factorial()
        {
            Console.WriteLine("Please Enter the Number : \n");
            int num = int.Parse(Console.ReadLine());
            int Factorial = 1;

            for (int Counter = num; Counter >= 1; Counter--)
            {
                Factorial = Factorial * Counter;

            }
            Console.WriteLine("The Factorial of a Number " + num + " is \n" + Factorial);
        }

        // 5. Sum of Even and Odd Numbers
        static void SumEvenOdd()
        {
            int num;
            int Res;

            Console.WriteLine("Enter the number:");
            num = int.Parse(Console.ReadLine());

            Res = num % 2;

            if (Res == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }

        // 6. Scientific Calculator
        static void ScientificCalculator()
        {
            char choice;
            do
            {
                //Console.Clear();
                double res;
                Console.WriteLine("choice the operation:\n 1. sin\n 2.cos\n 3.tan\n 4.sqrt\n 5.log\n 6.pow");
                int option = int.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter the Value:");
                double Num = double.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        res = Math.Sin(Num);
                        Console.WriteLine("Sin of input = " + res);
                        break;

                    case 2:
                        res = Math.Cos(Num);
                        Console.WriteLine("Cos of input = " + res);
                        break;

                    case 3:
                        res = Math.Tan(Num);
                        Console.WriteLine("Tan of input = " + res);
                        break;
                    case 4:
                        res = Math.Sqrt(Num);
                        Console.WriteLine("Sqrt of input = " + res);
                        break;
                    case 5:
                        res = Math.Log(Num);
                        Console.WriteLine("Lof of input = " + res);
                        break;
                    case 6:
                        Console.WriteLine("Please Enter the exponent Value:");
                        double exponent = double.Parse(Console.ReadLine());
                        res = Math.Pow(Num, exponent);
                        Console.WriteLine("Power of input = " + res);
                        break;

                    default:
                        Console.WriteLine("The Choice is wrong");
                        break;
                }
                Console.WriteLine("Do you want another operation ? y / n");
                choice = Console.ReadKey().KeyChar;
            } while (choice == 'y' || choice == 'Y');
            Console.WriteLine("\ngood bye");
        }

        // 7. Print Triangle Pattern
        static void PrintTriangle()
        {
            Console.WriteLine("Enter the number of line: \n");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // 8. Print Pyramid Pattern
        static void PrintPyramid()
        {
            Console.WriteLine("Enter the number of line: \n");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = i; j <= num; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // 9. Print Diamond Pattern

        static void PrintRow(int i, int n)
        {

            for (int j = 0; j < n - i; j++)
                Console.Write(" ");

            for (int j = 0; j < 2 * i - 1; j++)
                Console.Write("*");

            Console.WriteLine();
        }

        static void PrintDiamond()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            // Upper part of the diamond
            for (int i = 1; i <= n; i++)
            {
                PrintRow(i, n);
            }

            // Lower part of the diamond
            for (int i = n - 1; i >= 1; i--)
            {
                PrintRow(i, n);
            }



        }

        // 10. Guess Game
        static void GuessGame()
        {
            Random rand = new Random();
            int target = rand.Next(1, 101);

            int num;
            do
            {
                Console.WriteLine("Enter your Guess");
                num = int.Parse(Console.ReadLine());

                if (num > target)
                {
                    Console.WriteLine("Try Lower!");
                }
                else if (num < target)
                {
                    Console.WriteLine("Try Higher!");
                }
                else
                {
                    Console.WriteLine("You Win!");
                }
            }
            while (num != target);
        }

        //---------------------------------------------------------------C# Part3 Exercises (Array)
        //1. Array Initialization & Output
        static void ArrayInitializationOutput()
        {
            //int[] num = new int[5];
            int [] num = {2, 4, 6, 8, 10};
            for (int i=0; i<num.Length; i++)
            {
                Console.WriteLine(i);
            }
        }

        //2. Find Maximum & Minimum in an Array

        static void MaximumMinimumInAnArray()
        {
            
            int[] num = new int[10];
            Console.WriteLine("Enter 10 numbers : ");
            for (int i = 0; i < num.Length; i++)
                num[i] = int.Parse(Console.ReadLine());

            int Max = num[0];
            int Min = num[0];
  
            for (int j=0; j<num.Length; j++)
            {
                if (num[j] > Max)
                    Max = num[j];

                if (num[j] < Min)
                    Min = num[j];
            }

            Console.WriteLine($"The Max number is {Max}");
            Console.WriteLine($"The Min Number is {Min}");

        }

        //3. Count Even & Odd Numbers 

        static void CountEvenAndOddNumbers()
        {
            Console.WriteLine("Enter N numbers into an array: ");
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            Console.WriteLine("Enter " + N + " Numbers : ");

            int[] num = new int[N];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            int CountEven =0;
            int CountOdd =0;

            for (int j = 0; j < num.Length; j++)
            {
                if (num[j] % 2 == 0)
                {
                    CountEven++;
                }
                else
                {
                    CountOdd++;
                }
            }

            Console.WriteLine($"The Number of Even Numbers are: {CountEven}");
            Console.WriteLine($"The Number of Odd Numbers are: {CountOdd}");

        }

        //4. Reverse an Array
        static void ReverseArray()
        {
            Console.WriteLine("Enter N numbers into an array: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter " + N + " Numbers : ");
            int[] num = new int[N];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            //Array.Reverse(num);
            //Console.WriteLine("The Reverse array \n");
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);

            //}

            for (int i=N-1; i>=0; i--)
            {
                Console.WriteLine(num[i]+ " ");
            }
            Console.WriteLine();

        }

        //5.Search for a Number in an Array 
        static void SearchForNumberInArray()
        {
            Console.WriteLine("Enter N numbers into an array: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + N + " Numbers : ");
            int[] num = new int[N];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the number you want to search : ");
            int SearchNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < num.Length; i++)
            {

                if (num[i] == SearchNum)
                {
                    Console.WriteLine("The" + SearchNum + "on" + i + "index");
                }
            }
        }

        //6. Sorting an Array (Ascending Order) 
        static void SortingAnArray()
        {
            Console.WriteLine("Enter N numbers into an array: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + N + " Numbers : ");
            int[] num = new int[N];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Sort An Array is: ");
            Array.Sort(num);

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }

        //7. Merging Two Arrays
        static void MergingTwoArrays()
        {
            Console.WriteLine("Enter the size of array: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + N + " Numbers for first array : ");
            int[] num = new int[N];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter " + N + " Numbers for seconde array : ");
            int[] num2 = new int[N];

            for (int i = 0; i < num2.Length; i++)
            {
                num2[i] = int.Parse(Console.ReadLine());
            }
            int [] newArray= num.Concat(num2).ToArray();
            Console.WriteLine("The merge Array is \n ");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }




        }

        //8. Remove Duplicates from an Array 
        static void RemoveDuplicatesFromAnArray()
        {
            Console.WriteLine("Enter the size of array: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + N + " Numbers for first array : ");
            int[] num = new int[N];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            int[] UniqueNum = num.Distinct().ToArray();
            Console.WriteLine("The Uniqe Array is \n ");
            for (int i = 0; i < UniqueNum.Length; i++)
            {
                Console.WriteLine(UniqueNum[i]);
            }
        }

        //9. Second Largest Number in an Array
        static void SecondLargestNumberInAnArray()
        {
            Console.WriteLine("Enter the size of array: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter " + N + " Numbers for array : ");
            int[] num = new int[N];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(num);

            Console.WriteLine("The Seconde Largest Number :" + num[N - 2]);
        }

    }
}
