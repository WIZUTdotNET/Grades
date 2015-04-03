using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(GradeBook book)
        {
            book = new GradeBook();
            book.Name = "Nowy dziennik";
            book.Name = "Jeszcze nowszy dziennik";
        }

        static void IncrementNumber(ref int number)
        {
            number += 1;
        }


        static void Main(string[] args)
        {

            //Arrays();

            //Immutable();
            //PassByValueAndRef();

            //GradeBook book = new GradeBook();
            //book.AddGrade(89.5f);
            //book.AddGrade(91f);
            //book.AddGrade(75f);

            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.HighestGrade);
            //Console.WriteLine(stats.LowestGrade);





            Console.ReadLine();
        }

        private static void Arrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            foreach (float grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private static void AddGrades(float[] grades)
        {
            if (grades.Length >= 3)
            {
                grades[0] = 91f;
                grades[1] = 89.1f;
                grades[2] = 75f;
            }
        }

        private static void Immutable()
        {
            DateTime date = new DateTime(2002, 9, 11);

            date = date.AddDays(1);

            string name = " Borys ";
            name = name.Trim();

            Console.WriteLine(date);
        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(g2);
            Console.WriteLine(g1.Name);

            int x1 = 4;
            IncrementNumber(ref x1);
            Console.WriteLine(x1);
        }
    }
}
