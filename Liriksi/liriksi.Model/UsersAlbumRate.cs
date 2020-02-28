using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace liriksi.Model
{
    public class UsersAlbumRate
    {
        [Key]
        public int AlbumId { get; set; }
        [Key]
        public int UserId { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
    }
}
