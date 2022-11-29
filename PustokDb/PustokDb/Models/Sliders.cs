using System.ComponentModel.DataAnnotations;

namespace PustokDb.Models
{
    public class Sliders
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title1 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title2 { get; set; }
        [Required]
        [MaxLength(250)]
        public string Desc { get; set; }
        [Required]
        [MaxLength(75)]
        public string Image { get; set; }
        [Required]
        [MaxLength(30)]
        public string BtnText { get; set; }
        [Required]
        [MaxLength(100)]
        public string RedirectUrl { get; set; }
        public int Order { get; set; }
    }

}
