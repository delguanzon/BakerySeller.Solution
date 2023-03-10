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
        public double Price { get; set; }
        public DateTime Date { get; set; }
        private static List<Order> _instances = new List<Order>();
        public int Id { get; }

        public Order(string title, string description, int price)
        {
            Title = title;
            Description = description;
            Price = price;
            _instances.Add(this);
            Id = _instances.Count;
            Date = DateTime.Now;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}