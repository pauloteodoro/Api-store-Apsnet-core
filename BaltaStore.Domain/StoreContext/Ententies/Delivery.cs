

using System;
using BaltaStore.Domain.StoreContext.Emuns;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            this.status = EDeliveryStatus.Waiting;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus status { get; private set; }

        public void Ship()
        {
            status = EDeliveryStatus.Shiped;

        }

        public void Cancel()
        {
            status = EDeliveryStatus.Canceled;

        }


    }
}