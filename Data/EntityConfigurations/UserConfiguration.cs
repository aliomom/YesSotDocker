using Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Data.EntityConfigurations
{

    internal class UserConfiguration : EntityTypeConfiguration<User>
    {
        internal UserConfiguration()
        {
            ToTable("User");

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasColumnName("UserId")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(256)
                .IsOptional();
            Property(x => x.DateOfBirth)
               .HasColumnName("dob")
               .HasColumnType("nvarchar")

               .IsOptional();


        }
    }
}
