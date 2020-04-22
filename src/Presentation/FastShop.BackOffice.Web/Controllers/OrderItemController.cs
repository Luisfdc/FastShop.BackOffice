using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastShop.BackOffice.Application.Contracts;
using FastShop.BackOffice.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FastShop.BackOffice.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemApplication _orderItemApplication;

        public OrderItemController(IOrderItemApplication orderItemApplication)
        {
            _orderItemApplication = orderItemApplication;
        }


        [HttpGet, Route("{orderId}")]
        public async Task<ActionResult<List<OrderItem>>> ListOrderItem(int orderId)
        {
            return _orderItemApplication.List(orderId);
        }
    }
}