using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PustokDb.Models
{
    public class Genres
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(25)]
        public string BtnText { get; set; }
        public bool IsSelect { get; set; }
        public List<Books> Books { get; set; }
    }
}
