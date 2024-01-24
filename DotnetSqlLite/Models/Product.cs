using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotnetSqlLite.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductID { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }
        public string UnitName { get; set; }
        public int? UnitScale { get; set; }
        public long? InStock { get; set; }
        public double? Price { get; set; }
        public double? DiscontinuedPrice { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
