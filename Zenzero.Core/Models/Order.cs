using System;
using System.Collections.Generic;
using Zenzero.Core.Contracts;

namespace Zenzero.Core.Models
{
    public sealed class Order : IEntity
    {
        public Order()
        {
            OrderLines = new List<OrderLine>();
            IsActive = true;
            OrderDateInitial = DateTime.UtcNow; // Keep datetimes consistent no matter where this is deployed.
        }

        public int Id { get; init; }

        public bool IsActive { get; set; }

        public string CustomerName { get; set; }

        public DateTime OrderDateInitial { get; init; }

        public DateTime? OrderDateLastUpdated { get; set; }

        public double TotalAmount { get; set; }

        public IEnumerable<OrderLine> OrderLines { get; set; }
    }
}
