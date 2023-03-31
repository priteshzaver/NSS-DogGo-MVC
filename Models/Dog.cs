using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DogGo.Models
{
    public class Dog
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Hmmm... Your dog should really add a Name...")]
        [MaxLength(35)]
        public string Name { get; set; }

        [DisplayName("Owner")]
        public int OwnerId { get; set; }

        [Required]
        [MaxLength(35)]
        public string Breed { get; set; }

        public string Notes { get; set; }
        public string ImageUrl { get; set; }
        public Owner Owner { get; set; }
    }
}
