using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace liriksi.Model
{
    public class UsersSongRate
    {
        [Key]
        public int UserId { get; set; }
        [Key]
        public int SongId { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
    }
}
