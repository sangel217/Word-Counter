using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordsController : Controller
  {
    [HttpGet("/wordgame")]
        public ActionResult Game()
        {
          List<Word> allwords = Word.GetAll();
          return View(allwords);
        }


    [HttpPost("/wordgame/new")]
        public ActionResult Game(string userWord, string userSentence)
        {
          Word newWord = new Word(userWord,userSentence);
          List<Word> allwords = Word.GetAll();
          newWord.CountWords();

          return View("New",allwords);
        }

  }
}
