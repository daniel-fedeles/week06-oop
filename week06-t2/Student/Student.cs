namespace Student
{
    public class Student
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

        public override bool Equals(object obj)
        {
            var s = obj as Student;
            if (s == null)
            {
                return false;
            }
            return s.FirstName == this.FirstName && s.MiddleName == this.MiddleName &&
                   s.LastName == this.LastName && s.SSN == this.SSN && s.PermanentAddress == this.PermanentAddress &&
                   s.MobilePhoneNr == this.MobilePhoneNr && s.Email == this.Email && s.Course == this.Course &&
                   s.Speciality == this.Speciality && s.University == this.University && s.Faculty == this.Faculty;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^
                   MiddleName.GetHashCode() ^
                   LastName.GetHashCode() ^
                   SSN.GetHashCode() ^
                   PermanentAddress.GetHashCode() ^
                   MobilePhoneNr.GetHashCode() ^
                   Email.GetHashCode() ^
                   Course.GetHashCode() ^
                   Speciality.GetHashCode() ^
                   University.GetHashCode() ^
                   Faculty.GetHashCode();
        }

        public override string ToString()
        {
            return $"Student: {FirstName} {MiddleName} {LastName} with SSN {SSN} address: " +
                   $"{PermanentAddress} has emal: {Email}, attends: {Course}, {Speciality} " +
                   $"from University {University} faculty: {Faculty}";
        }

        public static bool operator ==(Student student1,
            Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1 == student2);
        }
    }
}