using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEFApp.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [MinLength(3,ErrorMessage ="Name must have atleast 3 character and max of 20 characters")]
        public string Name { get; set; }=string.Empty;

        [Required]
        public string Speciality { get; set; } = string.Empty;

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Column(TypeName ="numeric(18,2)")]
        public decimal VisitingFees {  get; set; }

        [Required]
        [Column(TypeName ="numeric(18,0)")]
        public decimal PhoneNumber {  get; set; }
    }
}
