using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetSqlLite.Models
{
    [Table("Order Details")]
    public class OrderDetail
    {
        [Column(Order = 1)]
        public long OrderID { get; set; }

        [Column(Order = 2)]
        public long ProductID { get; set; }

        public double Price { get; set; }
        public double Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
