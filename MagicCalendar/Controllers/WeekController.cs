using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MagicCalendar.Controllers
{
    public class WeekController : Controller
    {
        // GET: /Week/

        public IActionResult Index()
        {   
            return View();
        }

        // GET: /Week/Weirdness
        public string Store(string storeName)
        {
            return HtmlEncoder.Default.Encode($"Events at {storeName}");
        }

    }
}