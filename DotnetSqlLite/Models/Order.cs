using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotnetSqlLite.Models
{
    [Table("Orders")]
    public class Order
    {
        public Order()
        {
            OrderDate = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public double Freight { get; set; }
        public DateTime? ShipDate { get; set; }
        public Double Discount { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
