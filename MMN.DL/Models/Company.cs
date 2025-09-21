using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMN.DL.Models;

[Table(TableNames.Company)]
[Index(nameof(Document), IsUnique = true)]
public class Company {
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(SystemPlan))]
    public int PlanId { get; set; }

    [Required] [MaxLength(90)] public string Name { get; set; } = null!;

    [Required]
    [MaxLength(30)]
    public string Document { get; set; } = null!;
    
    [Required]
    [MaxLength(50)]
    public string Status { get; set; } = null!;


    public virtual SystemPlan Plan { get; set; }
    public virtual ICollection<Site> Sites { get; set; }
}