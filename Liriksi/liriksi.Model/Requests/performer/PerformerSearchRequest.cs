using System;
using System.Collections.Generic;
using System.Text;

namespace liriksi.Model.Requests.performer
{
    public class PerformerSearchRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ArtisticName { get; set; }
    }
}
