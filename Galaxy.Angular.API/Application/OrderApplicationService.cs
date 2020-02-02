using Galaxy.Angular.API.Infrastructure.Data.Repository;
using Galaxy.Angular.API.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galaxy.Angular.API.Application
{
    public class OrderApplicationService : IOrderAplicationService
    {
        public IOrderRepository _orderRepository { get; set; }
        public OrderApplicationService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public IEnumerable<OrderDto> ListOrder(int CustomerId)
        {
            return _orderRepository.GetOrden(CustomerId); 
                }
    }
}