using System;

namespace problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float count = float.Parse(Console.ReadLine());



                for (int i = 0; i < count; i++)
                {
                    var tokens = Console.ReadLine().Split();
                    string firstNameStudent = tokens[0];
                    string lastNameStudent = tokens[1];
                    string facultynumber = tokens[2];
                    string firstName = tokens[3];
                    string lastName = tokens[4];
                    int weeksalary = int.Parse(tokens[5]);
                    int hourperday = int.Parse(tokens[6]);
                    student Student = new student(firstNameStudent,lastNameStudent,facultynumber,firstName,lastName,weeksalary,hourperday);
                    student.ToResult(firstNameStudent, lastNameStudent, facultynumber);
                    student.ToResult1(firstName,lastName,weeksalary,hourperday);


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}