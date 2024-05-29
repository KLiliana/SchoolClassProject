using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClass
    {
        public int Grade { get; set; }
        public string ClassName { get; set; }
        public int MonthlyClassFee { get; set; }
        public int NumberOfStudents { get; set; }

        public SchoolClass(int grade, string className, int monthlyClassFee, int numberOfStudents)
        {
            Grade = grade;
            ClassName = className;
            MonthlyClassFee = monthlyClassFee;
            NumberOfStudents = numberOfStudents;
        }

        public override string ToString()
        {
            return $"{Grade}. {ClassName} ({MonthlyClassFee} Ft)";
        }

        public static SchoolClass MostPaydSchoolClass(List<SchoolClass> schoolClasses)
        {
            SchoolClass mostPaydSchoolClass = schoolClasses.OrderByDescending(sc => sc.MonthlyClassFee).First();
            return mostPaydSchoolClass;
        }
    }
}
