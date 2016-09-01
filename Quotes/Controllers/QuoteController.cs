﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Quotes.DAL;
using Quotes.Models;

namespace Quotes.Controllers
{
    public class QuoteController : Controller
    {

        public ActionResult MyQuotes()
        {

            return View(QuoteDAL.FindUserQuotes(User.Identity.GetUserId<int>()));
        }

        [HttpPost]
        public ActionResult PostQuote(string text)
        {
            //Save new quote in database
            QuoteDAL.SaveQuote(new QuoteModel() {QuoteText = text, UserId = User.Identity.GetUserId<int>()});

            //Refresh page
            return RedirectToAction("MyQuotes");
        }

        [HttpPost]
        public JsonResult LikeQuote(QuoteModel quote)
        {
            
            return new JsonResult();
        }

        [HttpPost]
        public JsonResult DislikeQuote(QuoteModel quote)
        {

            return new JsonResult();
        }

        [HttpPost]
        public JsonResult StarQuote(QuoteModel quote)
        {

            return new JsonResult();
        }

        [HttpPost]
        public JsonResult EditQuote(QuoteModel quote)
        {

            return new JsonResult();
        }
    }
}