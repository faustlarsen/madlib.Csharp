using MadLips.Models; // makes our model available to our controller:
using Microsoft.AspNetCore.Mvc; //  imports functionality from the ASP.NET Core MVC package listed in our .csproj
                                // This line imports the Microsoft.AspNetCore.Mvc namespace into our controller, so we have access to ASP.NET Core's built in Controller 
namespace MadLips.Controllers 
{
  public class HomeController : Controller // tell .NET that HomeController should inherit or extend functionality from ASP.NET Core's built-in Controller class that we import with our using statement.
  {
    [Route("/madlips")] // root path and it's the home page for All sites
    public ActionResult Madlips( string person1, string person2, string animal, string exclamation, string noun, string verb) {  // The return type of our Letter() method is now an ActionResult, This is a built-in MVC class that handles rendering views.. 
      MadlipStory myMadlips = new MadlipStory();
      myMadlips.Person1 = person1;
      myMadlips.Person2 = person2;
      myMadlips.Animal = animal;
      myMadlips.Exclamation = exclamation;
      myMadlips.Verb = verb;
      myMadlips.Noun = noun;
      return View(myMadlips); // This is a built-in method from the Microsoft.AspNetCore.Mvc namespace. When our route is invoked, it will return a view.
    }  

    [Route("/form")]
    public ActionResult Form() { return View(); }

  }
}