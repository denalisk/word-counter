using Nancy;
using System.Collections.Generic;
using RepeatCounterApp.Objects;

namespace RepeatCounterApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
          return View["forms.cshtml"];
      };
      Post["/"] = _ =>
      {
          RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["long-string"]);
          newRepeatCounter.SetTargetWord(Request.Form["target-word"]);
          newRepeatCounter.StringSplitter();
          newRepeatCounter.FindWord();
          return View["index.cshtml", newRepeatCounter];
      };
    }
  }
}
