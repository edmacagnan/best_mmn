using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MMN.DL.Models;

[Table(TableNames.UserProfile)]
[PrimaryKey(nameof(ProfileId), nameof(SiteId), nameof(UserId))]
public class UserProfile {
    
    [ForeignKey(nameof(Site))]
    public long SiteId { get; set; }
    
    [ForeignKey(nameof(User))]
    public long UserId { get; set; }
    
    [ForeignKey(nameof(Profile))]
    public int ProfileId { get; set; }

    public virtual Site Site { get; set; }
    public virtual User User { get; set; }
    public virtual Profile Profile { get; set; }
}