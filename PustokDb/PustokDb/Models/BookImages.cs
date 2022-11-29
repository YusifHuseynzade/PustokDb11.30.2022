using System.ComponentModel.DataAnnotations;

namespace PustokDb.Models
{
    public class BookImages
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Image { get; set; }
        public int BookId { get; set; }
        public bool PosterStatus { get; set; }
        public Books Books { get; set; }
    }
}
