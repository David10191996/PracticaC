using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class Book
    {

        [Required(ErrorMessage = "{0} is required")]
        public string BookName { get; set; }

        public string Author { get; set; }

        public int Price { get; set; }
    }
}
