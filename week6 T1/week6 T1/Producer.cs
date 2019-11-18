namespace week6_T1
{
    public class Producer : IProducer
    {
        public Producer(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}