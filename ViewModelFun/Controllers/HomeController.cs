using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace HelloASP
{
  public class HomeController : Controller
{

   [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet("user")]
    public IActionResult UserPage()
    {
      User someUser = new User()
      {
        FirstName = "Bill",
        LastName = "TestBill"
      };

      return View(someUser);
    }



    [HttpGet("users")]
    public IActionResult Users()
    {
        // to a View that has defined a model as @model string[]
        string[] names = new string[]
        {
            "Sally",
            "Billy",
            "Joey",
            "Moose"
        };
        return View(names);
    }

[HttpGet("numbers")]
  public IActionResult Numbers()
    {
        // to a View that has defined a model as @model string[]
        int[] numbers = new int[]
        {
            1,2,3,4,5,6,7,8,9
        };
        return View(numbers);
    }


}



}





    