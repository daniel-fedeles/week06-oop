namespace week6_T1
{
    public class Vehicle : IVehicle
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IProducer Producer { get; set; }
    }
}