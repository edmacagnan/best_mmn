using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMN.DL.Models;

[Table(TableNames.Site)]
[Index(nameof(CompanyId), nameof(Name),  IsUnique = true)]
[Index(nameof(Host), IsUnique = true)]
public class Site {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    [ForeignKey(nameof(Company))]
    public long CompanyId { get; set; }

    [Required]
    [MaxLength(80)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(256)]
    public string Host { get; set; } = null!;

    [Required]
    [MaxLength(50)]
    public string Status { get; set; } = null!;

    public virtual Company Company { get; set; }
}