using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders.Model
{
    internal class OrderItemDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string OrderCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; } = 0.0;
        public DateTime OrderDate { get; set; }

        public virtual OrderDetails OrderDetails { get; set; }
    }
}
