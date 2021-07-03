namespace MyTiresPlus.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MyTiresPlus.Data;
    using System.Linq;

    public class DateGG
    {
        //private readonly ApplicationDbContext data;
        //public DateGG(string name, ApplicationDbContext data)
        //{
        //    this.data = data;
        //    this.Name = name;
        //    this.UserCount = this.data.Users.Count();
        //}
        public string Name { get; set; }
        public int UserCount { get; set; }
    }
    public class AAController : Controller
    {
        private readonly ApplicationDbContext data;

        public AAController(ApplicationDbContext data)
        {
            this.data = data;
        }

        
        public IActionResult HH(string name)
        {
            var gg = new DateGG();
            gg.Name = name;
            gg.UserCount = this.data.Users.Count();

            return View(gg);


            
        }
    }
}
