using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BakerySeller.Models;

namespace BakerySeller.Controllers
{
    
    public class VendorController : Controller
    {
        
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string name, string description)
        {
            Vendor newVendor = new Vendor(name, description);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            model.Add("vendor", selectedVendor);
            model.Add("orders", selectedVendor.GetOrders());
            return View(model);
        }

        [HttpPost("/vendors/{vendorId}/order")]
        public ActionResult Create(int vendorId, string title, string description, int price)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor vendor = Vendor.Find(vendorId);
            Order newOrder = new Order(title, description, price);
            vendor.AddOrder(newOrder);
            List<Order> vendorOrders = vendor.GetOrders();
            model.Add("orders", vendorOrders);
            model.Add("vendor", vendor);
            return View("Show", model);
        }

    }
}