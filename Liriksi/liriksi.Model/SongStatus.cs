using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace liriksi.Model
{
    public class SongStatus
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }

    }
}
