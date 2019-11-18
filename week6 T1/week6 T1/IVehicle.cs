namespace week6_T1
{
    public interface IVehicle
    {
        string Name { get; set; }
        decimal Price { get; set; }
        IProducer Producer { get; set; }
    }
}