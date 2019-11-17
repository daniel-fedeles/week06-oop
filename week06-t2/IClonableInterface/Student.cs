using Student;
using System;

namespace IClonableInterface
{
    public class Student : ICloneable
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


        public object Clone()
        {
            var s = new Student
            {
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                SSN = this.SSN,
                PermanentAddress = this.PermanentAddress,
                MobilePhoneNr = this.MobilePhoneNr,
                Email = this.Email,
                Course = this.Course,
                Speciality = this.Speciality,
                University = this.University,
                Faculty = this.Faculty
            };
            return s;
        }
    }
}