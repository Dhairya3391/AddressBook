using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace AdressBook.Controllers;

public class ProductController : Controller
{
    
    // private IConfiguration _configuration;
    // public ProductController(IConfiguration _configuration)
    // {
    //     this._configuration = _configuration;
    // }
    // [Obsolete("Obsolete")]
    // public IActionResult Index()
    // {
    //     string? connectionString = this._configuration.GetConnectionString("DefaultConnection");
    //     SqlConnection connection = new SqlConnection(connectionString);
    //     connection.Open();
    //     SqlCommand command = connection.CreateCommand();
    //     command.CommandType = CommandType.StoredProcedure;
    //     command.CommandText = "PR_City_SelectAll";
    //     SqlDataReader reader = command.ExecuteReader();
    //     DataTable table = new DataTable();
    //     table.Load(reader);
    //     return View(table);
// }

    public object some;

    public IActionResult Index()
    {
        some = ViewData["Message"] = "Product List";
        return View();
    }

    public IActionResult Privacy()
    {
        return View(some);
    }
}