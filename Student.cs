using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int grade;
        private Single gpa;
        private string studentID;

        public static int NumOfStudents = 0;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 9 || value > 12)
                {
                    grade = 9;
                }
                else
                {
                    grade = value;
                }
            }
        }

        public Single GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public string StudentID
        {
            get { return studentID; }
        }

        public Student(string fN, string lN, int ag)
        {
            firstName = fN;
            lastName = lN;
            age = ag;
            NumOfStudents += 1;
            studentID = NumOfStudents.ToString("00000");
        }

        public override string ToString()
        {
            return $"{studentID} - {firstName} {lastName} ";
        }
    }
}
