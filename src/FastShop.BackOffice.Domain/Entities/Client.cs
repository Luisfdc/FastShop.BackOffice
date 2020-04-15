using System;
using System.Collections.Generic;
using System.Text;

namespace FastShop.BackOffice.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Document { get; set; }
    }
}
