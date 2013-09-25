using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Vica.Models
{
    public class VicaModelBase
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdatedOn { get; set; }

        protected VicaModelBase()
        {
            CreatedOn = DateTime.Now;
            LastUpdatedOn = DateTime.Now;
            Id = Guid.NewGuid();
        }
    }
}
