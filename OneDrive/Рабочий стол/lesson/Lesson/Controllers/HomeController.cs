using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lesson.Models;
using Lesson.ViewModels;

namespace Lesson.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CurrencyService _currencyService;


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _currencyService = new CurrencyService();
    }

    public IActionResult Index()
    {
        /*string jsonText = System.IO.File.ReadAllText("wwwroot/currency.json");
        List<Currency> currency = _currencyService.GetCurrencyRates(jsonText);*/
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GetMessage()
    {
        return PartialView("_GetMessage");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}