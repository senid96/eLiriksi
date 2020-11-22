using System;
using System.Collections.Generic;
using System.Text;

namespace liriksi.Model.Requests.rates
{
    public class RateDetails
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Performer { get; set; }
        public byte[] Image { get; set; }
        public double AvgRate { get; set; }
    }
}
