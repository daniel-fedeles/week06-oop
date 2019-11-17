using System.Text;

namespace Person
{
    public class Person
    {
        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Details about ");
            builder.Append(Name);
            builder.Append(": age is ");
            if (Age == null)
            {
                builder.Append("not specified.");
            }
            else
            {

                builder.Append(Age);
            }

            return builder.ToString();
        }
    }
}