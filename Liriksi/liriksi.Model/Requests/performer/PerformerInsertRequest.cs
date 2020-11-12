using System;
using System.Collections.Generic;
using System.Text;

namespace liriksi.Model.Requests
{
    public class PerformerInsertRequest 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ArtisticName { get; set; }
        public byte[] Image { get; set; }
        public string About { get; set; }
    }
}
