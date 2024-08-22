using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders.Model
{
    internal class OrderDetails
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string OrderCode { get; set; }
        public string CustomerCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; } = 0.0;
        public double PaidAmount { get; set; } = 0.0;
        public double ChangeAmount { get; set; } = 0.0;
        public string OrderStatus { get; set; }
        public int IsPayment { get; set; }
        public int IsApproved { get; set; }
        public int IsDelivered { get; set; }
        public int Is_active { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveredDate { get; set; }
        public DateTime ApprovedDate { get; set; }
        public String ApprovedBy { get; set; }

    }
}
