using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorello.Data;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Fiorello.Controllers
{
    public class BasketController: Controller
    {
        private readonly AppDbContext _context;

        public BasketController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            int basketCount;

            if (Request.Cookies["basket"] != null)
            {
                basketCount = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]).Count;
            }

            else
            {
                basketCount = 0;
            }

            ViewBag.BasketCount = basketCount;



            List<Product> products = new List<Product>();
            Product product = new Product();
            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);

            foreach (var item in basketProducts)
            {
                product = await _context.Products.Include(p => p.ProductImages).FirstOrDefaultAsync(p => p.Id == item.Id);
                product.Count = item.Count;
                products.Add(product);
            }

            return View(products);
        }
    }
}