namespace MyTiresPlus.Web.Controllers
{
    using System.Diagnostics;

    using MyTiresPlus.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using MyTiresPlus.Data;
    using System.Linq;
    using System;
    using MyTiresPlus.Web.ViewModels.Home;
    using MyTiresPlus.Web.Service;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext data;
        private readonly IshortStringservice gservise;
        public HomeController(ApplicationDbContext data, IshortStringservice gservise)
        {
            this.data = data;
            this.gservise = gservise;
            
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
                UserCount = this.data.Users.Count(),
                Email = @"Курсът ""ASP.NET Core"" ще ви научи как се изграждат съвременни уеб приложения с архитектурата Model-View-ControlleR",
            };
            indexViewModel.Email = this.gservise.GetShort(indexViewModel.Email, 25);
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
