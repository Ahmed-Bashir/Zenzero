﻿using Zenzero.Core.Models;

namespace Zenzero.Core.Contracts
{
    public interface IOrderLineService : IService<OrderLine>
    {
        void DeleteAsync(OrderLine entity);
    }
}
