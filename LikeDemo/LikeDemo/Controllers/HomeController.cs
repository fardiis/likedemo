using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LikeDemo.Models;
using BookDAL;

namespace LikeDemo.Controllers
{
    public class HomeController : Controller
    {
        BookContext ctx;
        public HomeController()
        {
            ctx = new BookContext();
        }
        public IActionResult Index()
        {
            BookViewModel model = new BookViewModel()
            {
                books = ctx.Books
            };
            return View(model);
        }
        public ContentResult AddLike(int id)
        {
            var likeCnt = 0;
            var book = ctx.Books.Find(id);
            var like = ctx.Books.Find(id).IsLiked;
            if (like)
            {
                like = false;
                likeCnt = 0;
            }
            else
            {
                like = true;
                likeCnt = 1;
            }
            ctx.Books.Find(id).IsLiked = like;
            ctx.SaveChanges();
            return Content(likeCnt.ToString());
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
