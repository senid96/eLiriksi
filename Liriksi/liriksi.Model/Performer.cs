using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace liriksi.Model
{
    public class Performer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ArtisticName { get; set; }
        public byte[] Image { get; set; }
        public string About { get; set; }
    }
}
