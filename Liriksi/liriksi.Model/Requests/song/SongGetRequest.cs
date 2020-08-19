using System;
using System.Collections.Generic;
using System.Text;

namespace liriksi.Model.Requests
{
    public class SongGetRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual Album Album { get; set; }
    }
}
