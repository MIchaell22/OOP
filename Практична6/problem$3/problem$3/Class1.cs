using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace problem_2
{
    class student
    {
       private string firstNameStudent;
        private string lastNameStudent;
        private string facultynumber;
        private string firstName;
        private string lastName;
        private int weeksalary;
        private int hourperday;

        public student(string firstNameStudent, string lastNameStudent, string facultynumber,string firstName,string lastName,int weeksalary,int houperday)
        {
            this.FirstNameStudent = firstNameStudent; this.LastNameStudent = lastNameStudent; this.Facultynumber = facultynumber;this.Weeksalary = weeksalary;this.Hourperday = hourperday;
        }
        public string FirstNameStudent
        {
            get
            {
                return this.firstNameStudent;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
            }
        }

        public string LastNameStudent
        {
            get
            {
                return this.lastNameStudent;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
            }
        }


        public string Facultynumber
        {
            get
            {
                return facultynumber;
            }
            set
            {
                if (value.Length < 5 || value.Length > 10 || !IsValidFacultyNumber(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
            }
        }
        private bool IsValidFacultyNumber(string value)
        {
            bool isValidFacultyNumber = true;
            foreach (char ch in value)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    isValidFacultyNumber = false;
                }
            }

            return isValidFacultyNumber;
        }
        public string FirstName
        {
            get
            {
                return this.firstNameStudent;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastNameStudent;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
            }

        }

        public int Weeksalary
        {
            get { 
            
                return weeksalary;
            }
            set
            {
                if ( value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");

                }
            }
        }
        public int Hourperday
{
            get
            {
                return hourperday;
            }
            set
            {
                if  (1>value && value<12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");

                }
            }
        }

        public static void ToResult(string firstNameStudent, string lastNameStudent, string facultynumber)
        {

            Console.WriteLine($" FirstNameStudent :  {firstNameStudent} , LastNameStudent : {lastNameStudent} , Facultynumber : {facultynumber} ");
        }
        public static void ToResult1(string firstName, string lastName, int weeksalary , int hourperday)
        {

            Console.WriteLine($" FirstName :  {firstName} , LastName : {lastName} , Weeksalary : {weeksalary} , Hourperday : {hourperday} , Salary  per  hour {weeksalary/(hourperday*5) }");
        }

    }


    

}
