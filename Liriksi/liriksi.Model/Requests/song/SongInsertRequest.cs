using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace liriksi.Model.Requests
{
    public class SongInsertRequest 
    {
        [Required]
        [MinLength(1)]
        public string Title { get; set; }
        [Required]
        [MinLength(1)]
        public string Text { get; set; }
        public int AlbumId { get; set; }

    }
}
