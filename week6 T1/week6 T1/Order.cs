using System;

namespace week6_T1
{
    public class Order : IOrder
    {
        public IPerson Person { get; set; }
        public IVehicle Vehicle { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int GetDeliveryTime()
        {
            TimeSpan ts = DeliveryDate.Subtract(DateTime.Now);
            int dif = ts.Days / 7;
            return dif;
        }
    }
}