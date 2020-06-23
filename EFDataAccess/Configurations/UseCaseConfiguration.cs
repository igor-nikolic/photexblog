using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Configurations
{
    public class UseCaseConfiguration : IEntityTypeConfiguration<UseCase>
    {
        public void Configure(EntityTypeBuilder<UseCase> builder)
        {
            builder.Property(x => x.Name).IsRequired();
            builder.HasIndex(x => x.Name).IsUnique();

            builder.HasMany(uc => uc.UserUseCases)
                .WithOne(uuc => uuc.UseCase)
                .HasForeignKey(uuc => uuc.UseCaseId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(uc => uc.UseCaseLogs)
                .WithOne(ucl => ucl.UseCase)
                .HasForeignKey(ucl => ucl.UseCaseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
