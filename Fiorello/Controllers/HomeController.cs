﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fiorello.Models;
using Fiorello.Data;
using Microsoft.EntityFrameworkCore;
using Fiorello.ViewModels;
using Newtonsoft.Json;

namespace Fiorello.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        //HttpContext.Session.SetString("name", "Ali");

        ////Response.Cookies.Append("surname", "Talibov");

        //Response.Cookies.Append("surname", "Talibov", new CookieOptions { MaxAge = TimeSpan.FromMinutes(30)});

        //Book book = new Book
        //{
        //    Id = 1,
        //    Name = "Xosrov ve Shirin"
        //};

        //Response.Cookies.Append("book", JsonConvert.SerializeObject(book));




        IEnumerable<Slider> sliders = await _context.Sliders.Where(s => !s.SoftDelete).ToListAsync();
        SliderInfo sliderInfo = await _context.SliderInfo.Where(si => !si.SoftDelete).FirstOrDefaultAsync();
        About about = await _context.Abouts.Where(a => !a.SoftDelete).Include(a => a.Advantages).FirstOrDefaultAsync();
        Expert expert = await _context.Experts.Where(e => !e.SoftDelete).Include(e => e.Persons).FirstOrDefaultAsync();
        Subscribe subscribe = await _context.Subscribes.Where(s => !s.SoftDelete).FirstOrDefaultAsync();
        Blog blog = await _context.Blogs.Where(b => !b.SoftDelete).Include(b => b.BlogPosts).FirstOrDefaultAsync();
        IEnumerable<Quote> quotes = await _context.Quotes.Where(q => !q.SoftDelete).ToListAsync();
        IEnumerable<Instagram> instagrams = await _context.Instagrams.Where(i => !i.SoftDelete).ToListAsync();
        IEnumerable<Category> categories = await _context.Categories.Where(c => !c.SoftDelete).ToListAsync();
        IEnumerable<Product> products = await _context.Products.Where(p => !p.SoftDelete).Include(p => p.ProductImages).ToListAsync();


        HomeVM homeVM = new HomeVM
        {
            Sliders = sliders,
            SliderInfo = sliderInfo,
            About = about,
            Expert = expert,
            Subscribe = subscribe,
            Blog = blog,
            Quotes = quotes,
            Instagrams = instagrams,
            Categories = categories,
            Products = products
        };

        return View(homeVM);
    }

    //public async Task<IActionResult> GetDataFromSession()
    //{
    //    //var sessionData = HttpContext.Session.GetString("name");

    //    //var cookieData = Request.Cookies["surname"];

    //    //return Json($"{sessionData} {cookieData}");

    //    var objectData = JsonConvert.DeserializeObject<Book>(Request.Cookies["book"]);

    //    return Json(objectData);
    //}
}

//public class Book
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}