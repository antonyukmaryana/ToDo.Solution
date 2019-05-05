using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Controllers
{
  public class ItemsController : Controller
  {
        [HttpGet("/items")]
        public ActionResult Index()
        {
          List<Item> allItems = Item.GetAll();
          return View(allItems);
        }
        [HttpGet("/items/new")]
        public ActionResult CreateForm()
        {
          return View();
        }

        [HttpPost("/items")]
        public ActionResult Create(string word, string sentence)
        {
          Item item = new Item(word, sentence, Counting(sentence, word));
          Item.GetAll().Add(item);

          return RedirectToAction("Index");
        }
        public static int Counting(string sentence, string yourWord)
        {
          int counter = 0;
          string[] words = sentence.Split(' ');
          foreach (string word in words)
          {
            if (yourWord.Equals(word))
            {
              counter++;
            }
          }

          return counter;
        }
  }
}
