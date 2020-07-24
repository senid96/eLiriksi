using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace liriksi.Model
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
