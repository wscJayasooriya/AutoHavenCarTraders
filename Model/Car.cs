using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders.Model
{
    internal class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string CarCode { get; set; }
        public byte[] Image { get; set; }
        public string CarModel { get; set; }
        public string ManufactureYear { get; set; }
        public string Color { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public string Mileage { get; set; }
        public string FuelType { get; set; }
        public string Condition { get; set; }
        public int NoOfOwners { get; set; }
        public string OwnerName { get; set; }
        public string OwnerNic { get; set; }
        public string OwnerContact { get; set; }
        public DateTime RegistrationDate { get; set; }
        public double Price { get; set; }
        public string Specification { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Status { get; set; }
        public int IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedBy { get; set; }


    }
}
