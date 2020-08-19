using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace liriksi.Model
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        public int CountryId { get; set; }
        
    }
}
