namespace MyTiresPlus.Web.Controllers
{
    using System.Diagnostics;

    using MyTiresPlus.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using MyTiresPlus.Data;
    using System.Linq;
    using System;
    using MyTiresPlus.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext data;

        public HomeController(ApplicationDbContext data)
        {
            this.data = data;
        }

        public IActionResult Index(int Id)
        {
            //Dictionary<string, object>
            this.ViewData["Year"] = 2020;
            this.ViewData["Name"] = "ss";
            this.ViewData["UsersCount"] = this.data.Users.Count();
            //dinamic
            this.ViewBag.Name = "Niki";
            this.ViewBag.Year = 2020;
            this.ViewBag.UsersCount = this.data.Users.Count();
            this.ViewBag.Calc = new Func<int>(() => 3);

            var indexViewModel = new IndexViewModel()
            {
                Id = Id,
                Name = "Niki",
                DataTime = DateTime.UtcNow.Year,
                ProcesorCount = Environment.ProcessorCount,
                UserCount = this.data.Users.Count()
            };

            return this.View(indexViewModel);
        }

        public IActionResult Privacy()
        {

            var model1 = new IndexViewModel
            {
                DataTime = DateTime.UtcNow.Year,
            };
            var model2 = new ivm2
            {
                Price = 12,
            };
            var ViewModel = new vmfull
            {
                Model1 = model1,
                Model2 = model2
            };
            //return this.View("Index", new IndexViewModel());
            //zarejda view na indexa s prazen view model
            //loading view of index with empty view model
            return this.View(ViewModel);
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
