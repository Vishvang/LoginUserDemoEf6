using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDomain.Classes
{
    public class UserRole_cl
    {
        [Key]
        public Guid Id { get; set; }
        public string RoleName { get; set; }

        [Required]
        public User_cl User { get; set; }
    }
}
