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

        public int SongStatusId { get; set; }
        [ForeignKey("SongStatusId")]
        public SongStatus SongStatus { get; set; }

        public int AlbumId { get; set; }
        [ForeignKey("AlbumId")]
        public Album Album { get; set; }

        //performer relationship
        //[ForeignKey("PerformerId")]
        //public ICollection<Performer> Performer { get; set; }
        //public int PerformerId { get; set; }

        public ICollection<UsersSongRate> UsersSongRates { get; set; }

        public int PerformerId { get; set; }
        [ForeignKey("PerformerId")]
        public Performer Performer { get; set; }

    }
}
