using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClassRepo
    {
        private List<SchoolClass> schoolClasses = new List<SchoolClass>();

        public void AddSchoolClass(SchoolClass schoolClass)
        {
            schoolClasses.Add(schoolClass);
        }

        public SchoolClass GetMostPaidSchoolClass()
        {
            return null;
        }
    }
}
