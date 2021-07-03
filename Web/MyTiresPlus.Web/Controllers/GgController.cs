namespace MyTiresPlus.Web.Controllers
{
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using MyTiresPlus.Data;

    public class DataViewModel
    {
        public int UserCount { get; set; }

        public string ParametarValue { get; set; }

    }

    public class GgController : Controller
    {
        private readonly ApplicationDbContext data;

        public GgController(ApplicationDbContext data)
        {
            this.data = data;
        }

        [NonAction]
        public void AA()
        {
            //nqma da e dostapen
        }

        [HttpGet]
        [HttpPost]
        //[Route("Blog/Special")] samo na tozi adres 6te dostapva ac6ana
        public IActionResult ById(string name, int year, int mounth, int day)
        {
            var viewModel = new DataViewModel();
            viewModel.UserCount = this.data.Users.Count();
            viewModel.ParametarValue = $"{year}, {mounth}, {day}";
            return this.View(viewModel);
        }
    }
}

