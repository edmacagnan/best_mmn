using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMN.DL.Models;

[Table(TableNames.SystemPlan)]
public class SystemPlan {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required] [MaxLength(80)] public string Name { get; set; } = null!;

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }
}