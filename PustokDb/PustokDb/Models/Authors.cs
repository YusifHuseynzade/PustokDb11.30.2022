using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PustokDb.Models
{
    public class Authors
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public string FullName { get; set; }
        public List<Books> Books { get; set; }
    }
}
