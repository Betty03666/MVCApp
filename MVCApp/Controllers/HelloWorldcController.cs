using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MVCApp.Controllers
{
    public class HelloWorldcController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/HelloWorld/Index.cshtml");
        }
        public IActionResult Welcome(string name, int numTimes=1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View("~/Views/HelloWorld/Welcome.cshtml");

        }

        //public string Index()
        //{
        //    return "this is my default action...";
        //}

        //Get: /HelloWorldc/Welcome/
        //Requieres using System.Text.Encoding.Web
        //Get: /HelloWorldc/Welcome?name=betty&numtimes=5
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, Numtimes is: {numTimes}");
        //}

    }
}
