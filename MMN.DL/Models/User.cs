using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMN.DL.Models;

[Table(TableNames.User)]
[Index(nameof(CompanyId), nameof(Username), IsUnique = true)]
public class User {
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [ForeignKey(nameof(Company))]
    public long? CompanyId { get; set; }

    [Required]
    [MaxLength(80)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(30)]
    public string Username { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;

    [Required]
    [MaxLength(50)]
    public string State { get; set; } = null!;

    public virtual Company? Company { get; set; }
    public virtual ICollection<UserProfile> Profiles { get; set; }
}