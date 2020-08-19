using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace liriksi.Model
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        public string Title { get; set; }
        [Required]
        [MinLength(1)]
        public string Text { get; set; }

        [ForeignKey("AlbumId")]
        public virtual Album Album { get; set; }
        public int AlbumId { get; set; }
        public virtual ICollection<UsersSongRate> UsersSongRates { get; set; }
    }
}
