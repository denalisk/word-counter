using Nancy;

namespace WordCounterApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
          return View["index.cshtml"];
      };
    }
  }
}
