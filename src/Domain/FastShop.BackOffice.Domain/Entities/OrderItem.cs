using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FastShop.BackOffice.Domain.Entities
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int id, int qtd)
        {
            ProductId = id;
            Qtd = qtd;
        }

        public int Id { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int Qtd { get; private set; }

        public int OrderId { get; set; }

        public void AddQtd(int qtd)
        {
            Qtd += qtd;
        }   
        public decimal TotalPartial()
        {
            return Product.Price * Qtd;
        }
    }
}
