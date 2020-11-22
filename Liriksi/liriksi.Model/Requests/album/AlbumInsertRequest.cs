using System;
using System.Collections.Generic;
using System.Text;

namespace liriksi.Model.Requests
{
    public class AlbumInsertRequest
    {
        public string Name { get; set; }
        public int YearRelease { get; set; }
        public int GenreId { get; set; }
        public int PerformerId { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
    }
}
