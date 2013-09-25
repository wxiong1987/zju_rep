using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vica.Models
{
    public class User : VicaModelBase
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string Description { get; set; }
        public string DisplayName { get; set; }

        public virtual ICollection<UserInRole> UserInRoles { get; set; }
    }
}
