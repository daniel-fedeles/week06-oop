using Student;
using System;
using System.Text;

namespace IComparableInterface
{

    public class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhoneNr { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Speciatity Speciality { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public string FullName()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(FirstName);
            builder.Append(" ");
            builder.Append(MiddleName);
            builder.Append(" ");
            builder.Append(LastName);
            return builder.ToString();
        }


        public int CompareTo(Student other)
        {
            var fNameComp = string.Compare(FullName(), other.FullName(), true);
            if (fNameComp != 0) return fNameComp;
            var ssnComp = string.Compare(FullName(), other.FullName(), StringComparison.Ordinal);
            if (ssnComp != 0) return ssnComp;
            return 0;
        }
    }
}