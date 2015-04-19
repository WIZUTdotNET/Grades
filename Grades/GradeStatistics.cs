using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public char LetterGrade
        {
            get
            {
                char result;
                if (AverageGrade >= 90)
                {
                    result = 'A';
                }
                else if (AverageGrade >= 80)
                {
                    result = 'B';
                }
                else if (AverageGrade >= 70)
                {
                    result = 'C';
                }
                else if (AverageGrade >= 60)
                {
                    result = 'D';
                }
                else
                {
                    result = 'E';
                }

                return result;
            }
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case 'A':
                        result = "Celujący";
                        break;
                    case 'B':
                        result = "Bardzo dobry";
                        break;
                    case 'C':
                        result = "Dobry";
                        break;
                    case 'D':
                        result = "Dostateczny";
                        break;
                    default:
                        result = "Niedostateczny";
                        break;
                }

                return result;
            }
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
