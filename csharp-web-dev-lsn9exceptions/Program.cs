using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Divide by zero error: Divisor must not be zero.");
            }
            return (x / y);
        }

        static int CheckFileExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new NullReferenceException("Error: Filename is null.");
            }
            if (fileName.Trim().Equals(""))
            {
                throw new NullReferenceException("Error: Filename is blank.");
            }
            
            string[] fileNameParts = fileName.Split('.');
            string extension = fileNameParts[fileNameParts.Length - 1];

            if (fileNameParts[fileNameParts.Length-1].Equals("cs"))
            {
                return 1;
            }
            else
                return 0;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                double quotient = Divide(5, 0);
            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    //score = CheckFileExtension(student.Value);
                    Console.WriteLine(student.Key + "'s filename is " + student.Value + ", and score is " + CheckFileExtension(student.Value));
                } catch (NullReferenceException e)
                {
                    Console.WriteLine(student.Key + ": " + e.Message);
                }
            }
        }
    } // class
} // namespace
