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
    public class OrderController : ControllerBase
    {
        private readonly IOrderApplication _orderApplication;

        public OrderController(IOrderApplication orderApplication)
        {
            _orderApplication = orderApplication;
        }


        [HttpGet("[action]")]
        public Order GetOrder([FromRoute] int orderId)
        {
            return _orderApplication.Get(orderId);
        }


        [HttpGet("[action]")]
        public List<Order> ListOrder([FromRoute] int clientId)
        {
            return _orderApplication.List(clientId);
        }

        [HttpPost("[action]")]
        public bool UpdateStatus([FromBody] Order order)
        {
             _orderApplication.UpdateStatus(order);

            return true;
        }
        
    }
}