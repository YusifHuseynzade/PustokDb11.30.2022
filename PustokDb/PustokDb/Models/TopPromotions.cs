using System.ComponentModel.DataAnnotations;

namespace PustokDb.Models
{
    public class TopPromotions
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(75)]
        public string Image { get; set; }
        [Required]
        [MaxLength(100)]
        public string RedirectUrl { get; set; }
    }
}
