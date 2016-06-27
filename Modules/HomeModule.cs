using Nancy;using Letter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables
                                                {
                                                  user = "Jess, Stew"
                                                };
        return View["hello.html", myLetterVariables];
      };
      Get["/form"] = _ => View["form.html"];
      Get["/login"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables
        {
            Username = Request.Query["username"],
            Password = Request.Query["password"]
        };
        return View["hello.html", myLetterVariables];
      };
    }
  }
}
