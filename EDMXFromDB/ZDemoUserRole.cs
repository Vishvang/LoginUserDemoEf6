namespace EDMXFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //Infer from Database. Crud classes simple geter and setter properties
    //Its a partial class and if you want to add anyting into it you have to add as another partial class. 

    /*Here we have data annotation to overrite other convention.
     * The tool do the reverse enginner configure everything it could using data annotation 
     * but not every configuration describe by the data annotation.
     * Like we see in DbContext -> precisioncan only be configured only by the Fluent API, not by the data annotation.
     */


    [Table("ZDemoUserRole")]
    public partial class ZDemoUserRole
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        public virtual ZDemoRole ZDemoRole { get; set; }

        public virtual ZDemoUser ZDemoUser { get; set; }
    }
}
