using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class RentalAgreement
    {
        [Key]
        public int AgreementId { get; set; }

        [Required(ErrorMessage = "Vehicle ID is required.")]
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "Rental start date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Rental Start Date")]
        public DateTime RentalStartDate { get; set; }

        [Required(ErrorMessage = "Rental end date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Rental End Date")]
        public DateTime RentalEndDate { get; set; }

        [Required(ErrorMessage = "Total cost is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Total cost must be greater than or equal to 0.")]
        [Display(Name = "Total Cost")]
        public decimal TotalCost { get; set; }
    }
}