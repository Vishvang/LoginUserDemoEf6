namespace EDMXFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //Crud classes simple geter and setter properties
    //Its a partial class and if you want to add anyting into it you have to add as another partial class. 
    //With Data Annotation

    [Table("ZDemoUser")]
    public partial class ZDemoUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZDemoUser()
        {
            ZDemoUserRoles = new HashSet<ZDemoUserRole>();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(10)]
        public string UserName { get; set; }

        [Required]
        [StringLength(10)]
        public string Pwd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZDemoUserRole> ZDemoUserRoles { get; set; }
    }
}
