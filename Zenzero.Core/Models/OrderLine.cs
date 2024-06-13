using Zenzero.Core.Contracts;

namespace Zenzero.Core.Models
{
    public sealed class OrderLine : IEntity
    {
        public int Id { get; init; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
