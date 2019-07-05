using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]       //type of request
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }
        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }
    }
}
