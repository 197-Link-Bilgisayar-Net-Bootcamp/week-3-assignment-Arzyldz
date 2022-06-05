using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.DAL.Models
{
    public class ProductFeature
    {
        [Key]
        [ForeignKey("Product")]
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        
    }
}
