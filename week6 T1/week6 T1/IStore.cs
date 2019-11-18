using System;

namespace week6_T1
{
    public interface IStore
    {
        string Name { get; set; }
        IOrder EnterStore(IPerson alex, IVehicle focus, DateTime delivery);
        void CancelOrder(IOrder order);
    }
}