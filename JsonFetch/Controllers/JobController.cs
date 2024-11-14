using JsonFetch.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text.Json;
using JsonFetch.Models;

namespace YourNamespace.Controllers
{
    public class JobsController : Controller
    {
        public IActionResult Index()
        {
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","lib", "Data.json");
            string jsonData = System.IO.File.ReadAllText(jsonFilePath);

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            JobsRoot jobsData = JsonSerializer.Deserialize<JobsRoot>(jsonData);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            return View(jobsData);
        }
    }
}
