using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace BakerySeller.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Order(string title, string description, int price)
        {
            Title = title;
            Description = description;
            Price = price;
        }
    }
}