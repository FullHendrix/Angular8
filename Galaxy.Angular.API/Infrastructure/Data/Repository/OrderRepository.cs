using Galaxy.Angular.API.Infrastructure.Data.EntityFrameCore.Context;
using Galaxy.Angular.API.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galaxy.Angular.API.Infrastructure.Data.Repository
{
    public class OrderRepository : IOrderRepository

    {
        public GalaxyAngularContext _galaxyAngularContext { get; set; }


        public OrderRepository(GalaxyAngularContext galaxyAngularContext )
        {
            _galaxyAngularContext = galaxyAngularContext;
        }
        public List<OrderDto> GetOrden(int customerId)
        {

            var q = from c in _galaxyAngularContext.Orders
                                 join s in _galaxyAngularContext.Customers on c.OrderId equals s.CustomerId
                                 where c.CustomerId == customerId
                                 select new OrderDto
                                 {
                                     OrderId = c.OrderId,
                                     Customer = string .Format(" {0},{1}", s.FirstName,s.LastName),
                                    
                                 };
             List<OrderDto> O = q.ToList();
            return O;
        }
    }
}
