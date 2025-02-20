using Microsoft.AspNetCore.Mvc;

namespace AdressBook.Controllers;

public class CountryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Add()
    {
        return View();
    }

    public IActionResult Edit()
    {
        return View();
    }
}