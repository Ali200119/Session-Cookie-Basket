﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fiorello.Models;
using Fiorello.Data;
using Microsoft.EntityFrameworkCore;
using Fiorello.ViewModels;

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
}