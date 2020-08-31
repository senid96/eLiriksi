using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace liriksi.Model
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int YearRelease { get; set; }

        ////performer relationship
        //[ForeignKey("PerformerId")]
        //public Performer Performer { get; set; }
        //public int PerformerId { get; set; }


        [ForeignKey("PerformerId")]
        public virtual Performer Performer { get; set; }
        public int PerformerId { get; set; }

        //genre relationship
        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }
        public int GenreId { get; set; }
        public byte[] Image { get; set; }
        public virtual ICollection<UsersAlbumRate> UsersAlbumRates { get; set; }
        public string Description { get; set; }


    }
}
