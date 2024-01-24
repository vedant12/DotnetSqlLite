using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotnetSqlLite.Models
{
    [Table("ProductCategory")]
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CategoryID { get; set; }

        [Required]
        [MaxLength(20)]
        public string CategoryName { get; set; }

        public virtual ProductCategory ParentCategory { get; set; }
        public virtual ICollection<ProductCategory> ChildCategories { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
