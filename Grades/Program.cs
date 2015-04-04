using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Grades
{
    class Program
    {
        public delegate void Writer(string message);

        static void Main(string[] args)
        {
            GradeBook book = new GradeBook("Borys's Book");
            book.AddGrade(89.5f);
            book.AddGrade(91f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();

            book.NameChanged += OnNameChanged;

            book.Name = "Agata's book";

            //WriteNames(book.Name);

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

            book.Name = "Cezary's book";
            book.NameChanged -= OnNameChanged;
            book.Name = "Dorota's book";

            Console.ReadLine();
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("***");
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Name changed from {0} to {1}", args.OldValue, args.NewValue);
        }

        static void GiveBookAName(GradeBook book)
        {
            book = new GradeBook();
            book.Name = "Nowy dziennik";
        }

        private static void WriteNames(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        private static void WriteByteArray(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                Console.WriteLine("0x{0}", b);
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
    }
}
