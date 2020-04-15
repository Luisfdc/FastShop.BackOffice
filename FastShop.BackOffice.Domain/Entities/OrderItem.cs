using System;
using System.Collections.Generic;
using System.Text;

namespace FastShop.BackOffice.Domain.Entities
{
    public class OrderItem
    {

        public OrderItem(int id, int qtd)
        {
            Product = new Product(id);
            Qtd = qtd;
        }

        public int ProductId { get; set; }
        public Product Product { get; private set; }
        public int Qtd { get; private set; }

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
