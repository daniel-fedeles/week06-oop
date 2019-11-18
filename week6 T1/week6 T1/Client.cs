namespace week6_T1
{
    public class Client : IPerson
    {
        public Client(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}