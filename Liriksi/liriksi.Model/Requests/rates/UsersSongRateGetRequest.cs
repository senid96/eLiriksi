using System;
using System.Collections.Generic;
using System.Text;

namespace liriksi.Model.Requests.rates
{
    public class UsersSongRateGetRequest
    {
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
    }
}
