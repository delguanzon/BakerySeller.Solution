using System.Collections.Generic;

namespace BakerySeller.Models
{
  public class Vendor
  {

    public string Name { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public int Id { get; }
    private List<Order> _orders = new List<Order> { };

    public Vendor(){
      _instances.Add(this);
      Id = _instances.Count;
    }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void AddOrder(Order order)
    {
      _orders.Add(order);
    }

    public List<Order> GetOrders()
    {
      return _orders;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}