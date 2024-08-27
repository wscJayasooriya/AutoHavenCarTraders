using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders.Model
{
    internal class CarParts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string CarPartCode { get; set; }
        public byte[] Image { get; set; }

        [Required(ErrorMessage = "Car Model is required.")]
        [StringLength(100, ErrorMessage = "Car Model cannot exceed 100 characters.")]
        public string CarModel { get; set; }

        [Required(ErrorMessage = "Part Name is required.")]
        [StringLength(100, ErrorMessage = "Part Name cannot exceed 100 characters.")]
        public string PartName { get; set; }

        [Required(ErrorMessage = "Manufacturer is required.")]
        [StringLength(100, ErrorMessage = "Manufacturer cannot exceed 100 characters.")]
        public string Manufacture { get; set; }

        [StringLength(50, ErrorMessage = "Color cannot exceed 50 characters.")]
        public string Color { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a non-negative number.")]
        public double Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Part Category is required.")]
        [StringLength(100, ErrorMessage = "Part Category cannot exceed 100 characters.")]
        public string PartCategory { get; set; }

        [Required(ErrorMessage = "Condition is required.")]
        [StringLength(100, ErrorMessage = "Condition cannot exceed 100 characters.")]
        public string Condition { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Status { get; set; }

        public int IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedBy { get; set; }

    }
}
