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

            //---------------------------------------------------------- CSharp Exercises part2 ()
        }
    }
}
