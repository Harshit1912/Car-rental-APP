using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Car
    {
        [Key]
        public int VehicleId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Maker { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Model { get; set; }

        [Required]
        [Range(
            0,
            double.MaxValue,
            ErrorMessage = "Rental price must be greater than or equal to 0."
        )]
        public decimal RentalPrice { get; set; }

        public bool IsAvailable { get; set; }
    }


}
