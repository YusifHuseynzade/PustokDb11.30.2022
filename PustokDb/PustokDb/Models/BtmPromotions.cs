using System.ComponentModel.DataAnnotations;

namespace PustokDb.Models
{
    public class BtmPromotions
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title1 { get; set; }
        [Required]
        [MaxLength(35)]
        public string Title2 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title3 { get; set; }
        [Required]
        [MaxLength(25)]
        public string BtnText { get; set; }
        [Required]
        [MaxLength(100)]
        public string RedirectUrl { get; set; }
    }
}
