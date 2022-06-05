using System.ComponentModel.DataAnnotations;

namespace NLayer.DAL.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public decimal? UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Categories { get; set; }
    }
}
