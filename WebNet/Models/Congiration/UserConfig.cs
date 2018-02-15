using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebNet.Models.Congiration
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            HasKey(u => u.UserId);
            Property(u => u.FName).IsRequired().HasMaxLength(32);
            Property(u => u.LName).HasMaxLength(32).IsRequired();
            Property(u => u.Login).IsRequired().HasMaxLength(20).HasColumnAnnotation(IndexAnnotation.AnnotationName,
                                                                                     new IndexAnnotation(new IndexAttribute("IX_Login")
                                                                                     { IsUnique = true }));

            Property(u => u.Password).IsRequired().HasMaxLength(20);
            Property(u => u.Email).IsRequired();
            Property(u => u.Phone).IsRequired();
            Property(u => u.CreatedAt).IsRequired();
            Property(u => u.Gender).IsRequired();
            Property(u => u.isOnline).IsRequired();
            Property(u => u.Salt).IsRequired();
            


        }

    }
}