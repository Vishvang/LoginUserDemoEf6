namespace EDMXFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZDemoRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZDemoRole()
        {
            ZDemoUserRoles = new HashSet<ZDemoUserRole>();
        }

        [Required]
        [StringLength(10)]
        public string RoleDescription { get; set; }

        [Key]
        public Guid RoleId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZDemoUserRole> ZDemoUserRoles { get; set; }
    }
}
