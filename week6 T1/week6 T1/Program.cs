using System;

namespace week6_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            var alex = new Client("Alex");
            IStore fordStore = new Store("ford");
            IVehicle focus = new Vehicle
            {
                Name = "focus",
                Price = 15000,
                Producer = new Producer(fordStore.Name)
            };
            IOrder focusOrder = fordStore.EnterStore(alex, focus, DateTime.Parse("12/31/2019"));
            IStore skodaStore = new Store("Skoda");
            IVehicle octavia = new Vehicle
            {
                Name = "octavia",
                Price = 14000,
                Producer = new Producer(skodaStore.Name),
            };
            IOrder octaviaOrder = skodaStore.EnterStore(alex, octavia, DateTime.Parse("12/10/2019"));

            if (octaviaOrder.DeliveryDate < focusOrder.DeliveryDate)
            {
                fordStore.CancelOrder(focusOrder);
                Console.WriteLine($"after {octaviaOrder.GetDeliveryTime()} weeks {octaviaOrder.Person.Name} gets his {octaviaOrder.Vehicle.Producer.Name} {octaviaOrder.Vehicle.Name}");
            }
            else
            {
                skodaStore.CancelOrder(octaviaOrder);
                Console.WriteLine($"after {octaviaOrder.GetDeliveryTime()} weeks {focusOrder.Person.Name} gets his {focusOrder.Vehicle.Producer.Name} {focusOrder.Vehicle.Name}");
            }


        }
    }


}
