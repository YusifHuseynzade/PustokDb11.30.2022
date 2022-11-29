using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokDb.Models
{
    public class Books
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        public bool StockStatus { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DisCountPercent { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostPrice { get; set; }
        public Genres Genres { get; set; }
        public Authors Authors { get; set; }
        public List<BookImages> BookImages { get; set; }

    }
}
