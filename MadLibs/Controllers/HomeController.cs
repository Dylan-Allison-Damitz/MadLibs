using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  { 
    [Route("/")]
    public ActionResult HomePage() { return View(); }

    [Route("/Form")]
    public ActionResult Form() { return View(); }

    [Route("/MadLibs")]
    public ActionResult MadLibs(string maleName, string teacherName, string exclamation, string number, string pluralObject, string storeName, string bodyPart, string sillyWord, string holidayName, string movieTitle, string verbWithIng, string amoutOfDistance, string country, string animal, string famousMovieQuote, string anotherBodyPart, string childrenSong, string adjective)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.MaleName = maleName;
      myMadLibsVariable.TeacherName = teacherName;
      myMadLibsVariable.Exclamation = exclamation;
      myMadLibsVariable.Number = number;
      myMadLibsVariable.PluralObject = pluralObject;
      myMadLibsVariable.StoreName = storeName;
      myMadLibsVariable.BodyPart = bodyPart;
      myMadLibsVariable.SillyWord = sillyWord;
      myMadLibsVariable.HolidayName = holidayName;
      myMadLibsVariable.MovieTitle = movieTitle;
      myMadLibsVariable.VerbWithIng = verbWithIng;
      myMadLibsVariable.AmoutOfDistance = amoutOfDistance;
      myMadLibsVariable.Country = country;
      myMadLibsVariable.Animal = animal;
      myMadLibsVariable.FamousMovieQuote = famousMovieQuote;
      myMadLibsVariable.AnotherBodyPart = anotherBodyPart;
      myMadLibsVariable.ChildrenSong = childrenSong;
      myMadLibsVariable.Adjective = adjective;
      
      return View(myMadLibsVariable);
    }

  }
}