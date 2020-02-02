using Galaxy.Angular.API.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galaxy.Angular.API.Infrastructure.Data.Repository
{
    public interface IOrderRepository
    {
        List< OrderDto> GetOrden(int customerId);
    }
}
