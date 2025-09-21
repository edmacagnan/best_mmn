using Microsoft.EntityFrameworkCore;
using MMN.DL.Models;

namespace MMN.DL.Interfaces;

public interface IAppDb {
    DbSet<Company> Companies { get; set; }
    DbSet<Profile> Profiles { get; set; }
    DbSet<Site> Sites { get; set; }
    DbSet<SystemPlan> SystemPlans { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<UserProfile> UserProfiles { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}