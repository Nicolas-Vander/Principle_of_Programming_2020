using System;
using System.Collections.Generic;
using System.Text;

namespace Assignement_1
{
    class Student : Person
    {       
        private string studentNumber;
        private int age;
        private double[] scores;
        private Address address;
        private double averageScore;
        private string fullAddress;
        private string fullName;    

        public Student(string firstName, string lastName, string studentNumber, int age, double[] scores, Address address) : base (firstName, lastName)
        {
            this.studentNumber = studentNumber;
            this.age = age;
            this.scores = scores;
            this.address = address;
            this.averageScore = Average(scores);
            this.fullAddress = address.ToString();
            this.fullName = firstName + " " + lastName;
        }

        public string StudentNumber
        {
            get { return studentNumber; }
        }
        public int Age
        {
            get { return age; }
        }
        public double[] Scores
        {
            get { return scores; }
        }
        public double GetAverageScore
        {
            get { return averageScore; }
        }
        public Address GetAddress
        {
            get { return address; }
        }
        public string GetFullAddress
        {
            get { return fullAddress; }
        }
        public string GetFullName
        {
            get { return fullName; }
        }


        public double Average(double[] scores)
        {
            double average = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                average = average + scores[i];
            }
            average = average / scores.Length;
            return average;
        }


        public override string ToString()
        {
            string answer = fullName + " lives in " + fullAddress + ".\nHe is " + Age + " and his student number is " + studentNumber + ".\nAll his grades are : ";
            for (int i = 0; i < scores.Length; i++)
            {
                answer = answer + scores[i] + " "; 
            }
            answer = answer + ".\nHis average score is " + averageScore;
            answer = answer + ".\n ";
            return answer;
        }
    }
}
