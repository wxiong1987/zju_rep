using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Vica.Models
{
    public class Role : VicaModelBase
    {
        [Required]
        public string RoleName { get; set; }

        public string Description { get; set; }
    }
}
