using System;
using System.Text;
using System.Collections.Generic;

namespace Lessons_2
{
    class Program
    {
        static int Agein10(int age)
        {
            int agein10 = age + 10;
            return agein10;
        }


        static int AreaSquare(int side1)
        {
            int area = side1 * side1;
            return area;
        }
        static int PerimeterSquare(int side1)
        {
            int perimeter = side1 * 4;
            return perimeter;
        }


        static int AreaRectangle(int side1, int side2)
        {
            int area = side1 * side2;
            return area;
        }
        static int PerimeterRectangle(int side1, int side2)
        {
            int perimeter = (side1 * 2) + (side2 * 2);
            return perimeter;
        }


        static int AreaTriangle(int side1, int height)
        {
            int area = (side1 * height) / 2;
            return area;
        }
        static int PerimeterTriangle(int side1, int side2, int side3)
        {
            int perimeter = side1 + side2 + side3;
            return perimeter;
        }


        static void Task1()
        {
            Console.WriteLine("How old are you ?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is : " + age);
            Console.WriteLine("Your age in 10 years will be  : " + Agein10(age));
        }

        static void Task2()
        {
            Console.WriteLine("What is the side of your square ?");
            int side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of your square is " + AreaSquare(side1));
            Console.WriteLine("The perimeter of your square is " + PerimeterSquare(side1));
        }

        static void Task3()
        {
            Console.WriteLine("What is the side A ?");
            int side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the side B ?");
            int side2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of your rectangle is " + AreaRectangle(side1, side2));
            Console.WriteLine("The perimeter of your rectangle is " + PerimeterRectangle(side1, side2));
        }

        static void Task4()
        {
            Console.WriteLine("What is the side A ?");
            int side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the side B ?");
            int side2 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the side C ?");
            int side3 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the height ?");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of your triangle is " + AreaTriangle(side1, height));
            Console.WriteLine("The perimeter of your trianglee is " + PerimeterTriangle(side1, side2, side3));
        }

        static void Task5()
        {
            DateTime date = DateTime.Now;

            Console.WriteLine("Enter the current date ");
            Console.WriteLine(date.ToShortDateString());

            Console.WriteLine("Enter the current time ");
            Console.WriteLine(date.ToShortTimeString());

            Console.WriteLine("The date after 10 years : ");
            Console.WriteLine(date.AddYears(10).ToShortDateString());

            Console.WriteLine("Give me a period ");
            int period = int.Parse(Console.ReadLine());
            Console.WriteLine("Date after {period} years : ");
            Console.WriteLine(date.AddYears(10).ToShortDateString());
        }

        static void Task6()
        {
            DateTime date = DateTime.Now;

            Console.WriteLine("Enter your age ");
            int currentAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your future age ");
            int futurAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your BirthDay month ");
            int bdayMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your BirthDay day ");
            int bdayDay = int.Parse(Console.ReadLine());

            int ageDifference = futurAge - currentAge;

            int FuturYear = DateTime.Now.Year + ageDifference;

            var futurBday = new DateTime(FuturYear, bdayMonth, bdayDay);

            Console.WriteLine($"Your future bday will be : {futurBday}");
        }

        static void HomeWork1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("My name is Nicolas");
        }

        static void HomeWork2()
        {
            Console.WriteLine("What is your first number ?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your second number ?");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("The sum of your two number is " + sum);

        }

        static void HomeWork3()
        {
            int resultA = (4 * 6) - 1;
            Console.WriteLine("The first result is " + resultA);
            int resultB = (35+5) % 7;
            Console.WriteLine("The second result is " + resultB);
            double a = 4;
            double b = 6;
            double c = 11;
            double d = 14;
            double resultC = ((-a*b)/c) + d;
            Console.WriteLine("The third result is " + resultC);
            int resultD = (15/6) + (-7%2) +2;
            Console.WriteLine("The last result is " + resultD);
        }

        static void HomeWork4()
        {
            Console.WriteLine("What is your first number ?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your second number ?");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your third number ?");
            int c = Convert.ToInt32(Console.ReadLine());
            int multiplication = a * b * c;
            Console.WriteLine("The multiplication of your three number is " + multiplication);
        }

        static void HomeWork5()
        {
            Console.WriteLine("What is your number ?");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The multiplication table for your number is : ");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(number * i);
            }

        }

        static void HomeWork6()
        {
            Console.WriteLine("What is your first number ?");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your second number ?");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your third number ?");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your fourth number ?");
            double d = Convert.ToInt32(Console.ReadLine());
            double average = (a + b + c + d) / 4;
            Console.WriteLine("The average of your four number is " + average);
        }

        static void HomeWork7()
        {
            Console.WriteLine("What is your number ?");
            double a = Convert.ToInt32(Console.ReadLine());
            if (100 <= a && a <= 200)
            {
                Console.WriteLine("Your number  is between 100 and 200");
            }
            else
            {
                Console.WriteLine("Your number is not between 100 and 200");            
            }
        }

        static void HomeWork8()
        {
            DateTime date = DateTime.Now;
            Console.Write("Today is the "+DateTime.Now.Day);
            Console.Write(" of the month number " + DateTime.Now.Month);
            Console.WriteLine(" of the year " + DateTime.Now.Year);
        }

        static void HomeWork9()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("How old are you ? ");
            int age = Convert.ToInt32(Console.ReadLine());
            int yearOfBirth = DateTime.Now.Year - age;
            Console.WriteLine("You were born during the year " + yearOfBirth);
        }

        static void HomeWork10()
        {
            Console.WriteLine("What is your first number ? (x) ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your second number ? (y) ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your third number ? (z) ");
            int z = Convert.ToInt32(Console.ReadLine());
            int multiplication1 = (x+y)*z;
            int multiplication2 = (x*y) + (y*z);
            Console.WriteLine("(x+y)*z = " + multiplication1);
            Console.WriteLine("(x*y) + (y*z) = " + multiplication2);
        }

        static void Main(string[] args)
        {
            HomeWork10();
        }

    }
}
