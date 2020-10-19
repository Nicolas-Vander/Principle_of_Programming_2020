using System;
using System.Collections.Generic;

namespace Lesson_3
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("How long is the first side of your triangle ? ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your side 1 is " + side1);
            Console.WriteLine("");
            Console.WriteLine("How long is the second side of your triangle ? ");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your side 2 is " + side2);
            Console.WriteLine("");
            Console.WriteLine("How long is the last side of your triangle ? ");
            int side3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your side 3 is " + side3);
            Console.WriteLine("");
            string answer = "";
            Console.WriteLine("");

            if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                if (side1 == side2 && side1 == side3)
                {
                    Console.WriteLine("Three of the sides are equal, the triangle is equilateral ");
                }
                else
                {
                    if (side1 == side2) { answer = "side 1 and side 2 are equals"; }
                    if (side1 == side3) { answer = "side 1 and side 3 are equals"; }
                    if (side2 == side3) { answer = "side 2 and side 3 are equals"; }
                    Console.WriteLine("Two of the sides are equal, the triangle is isocele, and  "+ answer);
                }
            }
            else
            {
                Console.WriteLine("Your triangle is a normal triangle ");
            }
        }

        static void Task2()
        {
            int sum = 0;
            List<int> numbers = new List<int>();
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("Give me a number ");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer >= 10 && 20 >= answer)
                {
                    numbers.Add(answer);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("The numbers between 10 and 20 that you entered are : ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                sum = sum + number;
            }
            Console.WriteLine("");
            Console.WriteLine("The sum of all these numbers is : " + sum);

        }

        static void Task3()
        {
            Console.WriteLine("Please enter your height in centimeters ");
            int height = Convert.ToInt32(Console.ReadLine());
            if (height >= 190) { Console.WriteLine("Basketball "); }
            if (height > 175 && height < 190) { Console.WriteLine("Athletics"); }
            if (height < 175) { Console.WriteLine("Horse riding"); }
        }

        static void Task4_1()
        {
            Console.WriteLine("What is the day of the week ? ");
            int day = Convert.ToInt32(Console.ReadLine());
            string dayName = "";
            int weekend = 7-day;
            string weekendSentance = "";
            switch (day)
            {
                case 1: dayName = "Monday"; break;
                case 2: dayName = "Tuesday"; break;
                case 3: dayName = "Wednesday"; break;
                case 4: dayName = "Thursday"; break;
                case 5: dayName = "Friday"; break;
                case 6: dayName = "Saturday"; break;
                case 7: dayName = "Sunday"; break;
                default: dayName = "Error"; break;
            }

            Console.WriteLine("What time is it ? ");
            int hour = Convert.ToInt32(Console.ReadLine());
            string hourName = "";
            switch (hour)
            {
                case 6: case 7: case 8: case 9: case 10: case 11: hourName = "morning"; break;
                case 12: case 13: case 14: case 15: case 16: case 17: hourName = "afternoon"; break;
                case 18: case 19: case 20: hourName = "evening"; break;
                case 21: case 22: case 23: case 0: case 1: case 2: case 3: case 4: case 5: hourName = "night"; break;
                default: hourName = "error"; break;
            }

            switch (weekend)
            {
                case 0: case 1:  weekendSentance = "is here !"; break;
                case 2: weekendSentance = "is coming tomorrow"; break;
                case 3: weekendSentance = "is coming in 2 days"; break;
                case 4: weekendSentance = "is coming in 3 days"; break;
                case 5: weekendSentance = "is coming in 4 days"; break;
                case 6: weekendSentance = "is coming in 5 days"; break;
            }
            Console.WriteLine("Good " + hourName + ", it is a lovely " + dayName + " today. Weekend " + weekendSentance);
        }

        static void Task4_2()
        {
            DateTime date = DateTime.Now;
            //It is in french so the day is written in french
            string dayName = date.ToString("dddd");
            int hour = date.Hour;
            int day = (int)date.DayOfWeek;
            int weekend = 7 - day;
            string weekendSentance = "";
            string hourName = "";   
            switch (hour)
            {
                case 6: case 7: case 8: case 9: case 10: case 11: hourName = "morning"; break;
                case 12: case 13: case 14: case 15: case 16: case 17: hourName = "afternoon"; break;
                case 18: case 19: case 20: hourName = "evening"; break;
                case 21: case 22: case 23: case 0: case 1: case 2: case 3: case 4: case 5: hourName = "night"; break;
                default: hourName = "error"; break;
            }
            switch (weekend)
            {
                case 0: case 1: weekendSentance = "is here !"; break;
                case 2: weekendSentance = "is coming tomorrow"; break;
                case 3: weekendSentance = "is coming in 2 days"; break;
                case 4: weekendSentance = "is coming in 3 days"; break;
                case 5: weekendSentance = "is coming in 4 days"; break;
                case 6: weekendSentance = "is coming in 5 days"; break;
            }
            Console.WriteLine("Good " + hourName + ", it is a lovely " + dayName + " today. Weekend " + weekendSentance);
        }

        static void Task5()
        {
            Console.WriteLine("What is your first name ? ");
            string firstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is your last  name ? ");
            string lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is the year of your date of birth ? ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the month of your date of birth ? ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the day of your date of birth ? ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime dateOfBirth = new DateTime(year, month, day);
            Console.WriteLine("What is your student ID ? ");
            string studentNumber = Convert.ToString(Console.ReadLine());

            char[] studentYear = new char[4];
            for (int i = 0; i <= 3; i++)
            {
                studentYear[i] = studentNumber[i]  ;
            }

            char[] studentFaculty = new char[2];
            int compteur = 0;
            for (int i = 4; i <= 5; i++)
            {
                studentFaculty[compteur] = studentNumber[i];
                compteur++;
            }
            compteur = 0;
            char[] studentSpeciality = new char[2];
            for (int i = 6; i <= 7; i++)
            {
                studentSpeciality[compteur] = studentNumber[i];
            }
            compteur = 0;
            char[] studentWithinSpeciality = new char[4];
            for (int i = 8; i <= 11; i++)
            {
                studentWithinSpeciality[compteur] = studentNumber[i];
            }

            Console.WriteLine("Your name is " + firstName + " " + lastName + ", you were born the " + dateOfBirth.Day + " of " + dateOfBirth.Month + " in " + dateOfBirth.Year);
            Console.WriteLine("Your ID Card was delivered on the year " + studentYear + ", your code of faculty is " + studentFaculty + ", your speciality number is " + studentSpeciality + " and your number within speciality is " + studentWithinSpeciality);
        }
        static void Main(string[] args)
        {
            Task5();
        }
    }
}
