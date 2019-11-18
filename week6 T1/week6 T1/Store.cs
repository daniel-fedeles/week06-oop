using System;
using System.Collections.Generic;

namespace week6_T1
{
    public class Store : IStore
    {
        public Store(string name)
        {
            this.Name = name;
            Orders = new List<IOrder>();
        }

        public string Name { get; set; }
        public List<IOrder> Orders { get; set; }

        public void CancelOrder(IOrder order)
        {
            Console.WriteLine($"{order.Person.Name} cancel order {order.Vehicle.Producer.Name} {order.Vehicle.Name}");
            Orders.Remove(order);
        }
        public IOrder EnterStore(IPerson person, IVehicle vehicle, DateTime delivery)
        {
            Console.WriteLine($"{person.Name} enter {Name}");
            Console.WriteLine($"{person.Name} order {vehicle.Producer.Name} {vehicle.Name}");

            var order = new Order
            {
                Person = person,
                Vehicle = vehicle,
                DeliveryDate = delivery
            };
            Orders.Add(order);
            return order;
        }
    }
}