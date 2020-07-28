using System;
using System.Collections.Generic;
using System.Text;

namespace liriksi.Model.Requests
{
    public class UserAlbumRateGetRequest
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
    }
}
