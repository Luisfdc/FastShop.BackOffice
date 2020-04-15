using System;

namespace FastShop.BackOffice.Domain.Entities
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}