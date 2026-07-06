using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Artist { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [DisplayName("Album Description")]
        public string Description { get; set; }

        
        [DisplayName("Type")]
        [Required]
        public string Type { get; set; }

        // either it is owned or it's in the wishlist
        [DisplayName("Owned")]
        public bool IsOwned { get; set; }
        [Range(1, 10)]
        public decimal? Rating { get; set; }

    }
}
