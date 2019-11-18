using System;

namespace week6_T1
{
    public interface IOrder
    {
        IPerson Person { get; set; }

        IVehicle Vehicle { get; set; }

        DateTime DeliveryDate { get; set; }

        int GetDeliveryTime();
    }
}