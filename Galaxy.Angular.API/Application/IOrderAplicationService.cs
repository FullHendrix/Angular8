using Galaxy.Angular.API.Infrastructure.Data.Repository;
using Galaxy.Angular.API.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galaxy.Angular.API.Application
{
    public interface IOrderAplicationService
    {
        IEnumerable<OrderDto> ListOrder(int CustomerId);

    }
}
