using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatientCrud.DTO
{
  public class PatientDTO
  {
    //Validations are already added in the BAL
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } // Auto-incrementing ID

    [Required]
    [Column(TypeName = "decimal(7,4)")]
    public decimal Dosage { get; set; } // Decimal(7,4)

    [Required]
    public string Drug { get; set; }

    [Required]
    public string Patient { get; set; }

    [Required]
    public System.DateTime ModifiedDate { get; set; }
  }
}
