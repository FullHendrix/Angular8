using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galaxy.Angular.API.Application;
using Galaxy.Angular.API.Infrastructure.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Galaxy.Angular.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        public IOrderAplicationService _orderApplicationService { get; set; }
        public OrdersController(IOrderAplicationService orderApplicationService)
        {
            _orderApplicationService = orderApplicationService;
        }

        [HttpGet("{customerId}")]
        //[Authorize]
        public IEnumerable<OrderDto> ListOrders(int customerId)
        {
            return _orderApplicationService.ListOrder(customerId);
        }
    }
}