using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab27.Models;

namespace Lab27.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RedditDal RD = new RedditDal();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult Subreddit()
        {
            //string output = RD.GetAPIJson("aww");
            //ViewBag.test = output;

            RedditPost rp = RD.GetPost("aww");
            return View(rp);
        }
        public IActionResult Postlist()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Postlist(string subreddit)
        {            
            RedditPost rp = RD.GetPosts(subreddit);
            return View(rp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
