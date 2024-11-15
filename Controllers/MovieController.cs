using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class MovieController : Controller
{
    // 
    // GET: /Movie/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /Movie/Welcome/ 
    public string Welcome(string name, int numberRod = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {numberRod}");
    }
}