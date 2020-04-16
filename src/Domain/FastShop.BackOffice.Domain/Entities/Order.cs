using FastShop.BackOffice.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FastShop.BackOffice.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public OrderStatusEnum Status { get; set; }
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; }
        public decimal Amount => Items.Sum(x => x.TotalPartial());

    }
}
