using System;
using System.Collections.Generic;

namespace Assignement_1
{
    class Program
    {
        static void Main()
        {
            Address address1 = new Address(48, "Hameau street", "Paris", "France");
            double[] scores1 = { 1, 3, 5, 7, 9, 11, 13, 15 };
            Student student1 = new Student("Nico", "Vanderstigel", "702717", 20, scores1, address1);
            List<Student> studentList = new List<Student>();
            studentList.Add(student1);
            int answer;
            bool escape = false;
            Console.WriteLine("I already created a random student so you can test all my features. Tape 4 to see his name");
            while (escape == false)
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("What do you want to do ?");
                Console.WriteLine();
                Console.WriteLine("Tape 1 to ADD a student");
                Console.WriteLine("Tape 2 to DELETE a student");
                Console.WriteLine("Tape 3 to SEARCH and DISPLAY some informations of a student");
                Console.WriteLine("Tape 4 to LIST all students");
                Console.WriteLine("Tape 0 to STOP the program");
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine();
                answer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (answer)
                {
                    case 1: Add(studentList); break;
                    case 2: Delete(studentList); break;
                    case 3: Display(studentList); break;
                    case 4: List(studentList); break;
                    case 0: escape = true; break;
                }
                Console.WriteLine();
            }
        }

        static void Add(List<Student> studentList)
        {
            Console.WriteLine("What is the first name of your new student ?");
            string firstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is the last name of your new student ?");
            string lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is the student number of your new student ?");
            string studentNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is the age of your new student ?");
            int studentAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many scores will you enter ?");
            int numberOfScores = Convert.ToInt32(Console.ReadLine());
            double[] studentScores = new double[numberOfScores];
            Console.WriteLine("Enter all the scores pushing enter between all of them ");
            for (int i = 0; i <numberOfScores; i++)
            {
                int score = Convert.ToInt32(Console.ReadLine());
                studentScores[i] = score;
            }
            Console.WriteLine("What is the adress of the student ?");
            Console.WriteLine("Enter the number of the street ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the street ");
            string street = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the name of the city ");
            string city = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the name of the country ");
            string country = Convert.ToString(Console.ReadLine());
            Address address = new Address(number, street, city, country);
            Student student = new Student(firstName, lastName, studentNumber, studentAge, studentScores, address);
            studentList.Add(student);
            Console.WriteLine();
        }

        static void Delete(List<Student> studentList)
        {
            bool inTheList = false;
            Console.WriteLine("(I had a problem for this features, I know it wasn't mandatory but still, i let it in my code )");
            Console.WriteLine("What is the full name of the student you want to delete ?");
            string name = Convert.ToString(Console.ReadLine());            
            foreach (var student in studentList) // I am using a foreach but the problem is that when the List is empty, it can't find any student in student list so the program just crash...
            {
                if (student.GetFullName == name)// I think that the problem comes from the fact that i delet a student in the list while i am in my foreach so it's going out of range
                {
                    inTheList = true;
                    studentList.Remove(student);
                    Console.WriteLine("This student has been delete with success");
                }
            }
            if (inTheList == false)
            {
                Console.WriteLine(name + " is not in the List");
            }
            Console.WriteLine();
        }

        static void Display(List<Student> studentList)
        {
            bool inTheList = false;
            Console.WriteLine();
            Console.WriteLine("What is the full name of the Student of which you need informations ?");
            Console.WriteLine();
            string name = Convert.ToString(Console.ReadLine());
            foreach (var student in studentList)
            {
                if (student.GetFullName == name)
                {
                    inTheList = true;
                    Student studentChoosen = student;
                    int answer;
                    bool escape = false;
                    while (escape == false)
                    {
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine("What do you want to do ?");
                        Console.WriteLine();
                        Console.WriteLine("Tape 1 to display the FULL NAME of your student");
                        Console.WriteLine("Tape 2 to display the STUDENT NUMBER of your student");
                        Console.WriteLine("Tape 3 to display the AGE of your student");
                        Console.WriteLine("Tape 4 to display the ALL THE SCORES of your student");
                        Console.WriteLine("Tape 5 to display the AVERAGE SCORES of your student");
                        Console.WriteLine("Tape 6 to display the FULL ADDRESS of your student");
                        Console.WriteLine("Tape 7 to display the NUMBER OF THE STREET of your student");
                        Console.WriteLine("Tape 8 to display the NAME OF THE STREET of your student");
                        Console.WriteLine("Tape 9 to display the NAME OF THE CITY of your student");
                        Console.WriteLine("Tape 10 to display the COUNTRY of your student");
                        Console.WriteLine("Tape 11 to display SOME SENTANCES about your student");
                        Console.WriteLine("Tape 12 to display ALL THE INFORMATIONS of your student");
                        Console.WriteLine("Tape 0 to LEAVE this student");
                        Console.WriteLine("------------------------------------------------------------------------");
                        Console.WriteLine();
                        answer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        string grades = " ";
                        switch (answer)
                        {
                            case 1: Console.WriteLine(studentChoosen.GetFullName); Console.WriteLine(); break;
                            case 2: Console.WriteLine(studentChoosen.StudentNumber); Console.WriteLine(); break;
                            case 3: Console.WriteLine(studentChoosen.Age); Console.WriteLine(); break;
                            case 4:
                                for (int i = 0; i < studentChoosen.Scores.Length; i++)
                                {
                                    grades = grades + studentChoosen.Scores[i] + " ";
                                }
                                Console.WriteLine(grades); break;
                            case 5: Console.WriteLine(studentChoosen.GetAverageScore); Console.WriteLine(); break;
                            case 6: Console.WriteLine(studentChoosen.GetFullAddress); Console.WriteLine(); break;
                            case 7: Console.WriteLine(studentChoosen.GetAddress.Number); Console.WriteLine(); break;
                            case 8: Console.WriteLine(studentChoosen.GetAddress.Street); Console.WriteLine(); break;
                            case 9: Console.WriteLine(studentChoosen.GetAddress.City); Console.WriteLine(); break;
                            case 10: Console.WriteLine(studentChoosen.GetAddress.Country); Console.WriteLine(); break;
                            case 11:
                                Console.WriteLine("Student : " + studentChoosen.GetFullName + " average score is " + studentChoosen.GetAverageScore);
                                Console.WriteLine("Student : " + studentChoosen.GetFullName + " is living in " + studentChoosen.GetAddress.City);
                                Console.WriteLine("Student : " + studentChoosen.GetFullName + " address is " + studentChoosen.GetFullAddress);
                                Console.WriteLine("Student : " + studentChoosen.GetFullName + " is " + studentChoosen.Age + " years old");
                                break;
                            case 12: Console.WriteLine(studentChoosen.ToString()); break;
                            case 0: escape = true; break;
                        }
                        Console.WriteLine();
                    }
                
                }
            }
            if (inTheList == false)
            {
                Console.WriteLine(name + " is not in the List");
            }
            Console.WriteLine();
        }

        static void List(List<Student> studentList)
        {
            if (studentList.Count != 0)
            {
                Console.WriteLine("These are the names of all the students :");
                Console.WriteLine();
                foreach (var student in studentList)
                {
                    Console.WriteLine(student.GetFullName);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is no student in the list ");
            }
        }
    }
}
