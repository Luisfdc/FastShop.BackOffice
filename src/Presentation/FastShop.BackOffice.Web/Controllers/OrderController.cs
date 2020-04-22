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


        [HttpGet, Route("{orderId}")]
        public async Task<ActionResult<Order>> GetOrder(int orderId)
        {
            return _orderApplication.Get(orderId);
        }


        [HttpGet, Route("{clientId}/Client")]
        public async Task<ActionResult<List<Order>>> ListOrder(int clientId)
        {
            return _orderApplication.List(clientId);
        }

        [HttpPost, Route("UpdateStatus")]
        public async Task<ActionResult<bool>> UpdateStatus(Order order)
        {
             _orderApplication.UpdateStatus(order);

            return true;
        }
        
    }
}