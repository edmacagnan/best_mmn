using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMN.DL.Models;

namespace MMN.DL.Configurations;

internal class SystemPlanConfiguration : IEntityTypeConfiguration<SystemPlan> {
    public void Configure(EntityTypeBuilder<SystemPlan> builder) {
        builder.Property(p => p.Price).HasPrecision(10, 2);
    }
}