using System.ComponentModel.DataAnnotations;

namespace E_shoes.Models
{
    public class Producer
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture is required")]

        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]

        //public string FulleName { get; set; }

        public string Bio { get; set; }
        [Display(Name = "Biographg")]

        //Relationships

        public List<Movie>  Movies { get; set;}
        public string FullName { get; set; }
    }
}
