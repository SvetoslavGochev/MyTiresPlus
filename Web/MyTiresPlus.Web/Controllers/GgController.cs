namespace MyTiresPlus.Web.Controllers
{
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using MyTiresPlus.Data;
    using MyTiresPlus.Web.Service;

    public class DataViewModel
    {
        public int UserCount { get; set; }

        public string ParametarValue { get; set; }

    }

    public class GgController : Controller
    {
        private readonly ApplicationDbContext data;
        private readonly IshortStringservice gservice;
        public GgController(ApplicationDbContext data, IshortStringservice gservice)
        {
            this.gservice = gservice;
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

