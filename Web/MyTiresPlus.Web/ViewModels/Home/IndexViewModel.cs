using System.ComponentModel.DataAnnotations;

namespace MyTiresPlus.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        //opisvame danite koito mu trqbvat na vito
        
        
        [Range(2000, 2100)]
        public int Year { get; set; }

        public int UserCount { get; set; }

        public int ProcesorCount { get; set; }

        public int DataTime { get; set; }

        public int Id { get; set; }
        [DataType(DataType.MultilineText)]//za mnoigoredvi poleta
        public string Email { get; set; }

        public string Name { get; set; }

    }
}

