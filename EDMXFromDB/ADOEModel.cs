namespace EDMXFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;


    //See we have DbContect class. Create DbSets of the entities. 
     
    public partial class ADOEModel : DbContext
    {
        public ADOEModel()
            : base("name=ADOEModel")
        {
        }


        //ALL 
        /*We have virtual here-> Why? Because this concept lead towards to load data when?
         * Based on our requirements we can do
         *      - Early loading (Include keyword helpful to achieve that)
         *      - Lazy Loading (Virtual here useful to achieve Lazy loading)
         *      - Projection Loading (Inside the query we can create our own set of DTO(Used in web api but if you do projection in your query result its usually for your convinience))
         */

        public virtual DbSet<ZDemoRole> ZDemoRoles { get; set; }
        public virtual DbSet<ZDemoUser> ZDemoUsers { get; set; }
        public virtual DbSet<ZDemoUserRole> ZDemoUserRoles { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*Here we can see some contraint with some property like 
             * IsFixedLength
             * WillCascadeOnDelete
             * 
             */

            /*This called Fluent configuration which is present here in DbContext class. 
             * In addition to this for property we can have data annotation as well
             * Which we can apply in class which is generated(infer) from DB.
             */

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
