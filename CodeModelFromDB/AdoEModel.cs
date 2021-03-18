namespace CodeModelFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using LoginDomain.Classes;

    public partial class AdoEModel : DbContext
    {
        public AdoEModel()
            : base("name=AdoEModel")
        {
        }

        public virtual DbSet<ZDemoRole> ZDemoRoles { get; set; }
        public virtual DbSet<ZDemoUser> ZDemoUsers { get; set; }
        public virtual DbSet<ZDemoUserRole> ZDemoUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ZDemoRole>()
                .Property(e => e.RoleDescription)
                .IsFixedLength();

            modelBuilder.Entity<ZDemoRole>()
                .HasMany(e => e.ZDemoUserRoles)
                .WithRequired(e => e.ZDemoRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ZDemoUser>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<ZDemoUser>()
                .Property(e => e.Pwd)
                .IsFixedLength();

            modelBuilder.Entity<ZDemoUser>()
                .HasMany(e => e.ZDemoUserRoles)
                .WithRequired(e => e.ZDemoUser)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
