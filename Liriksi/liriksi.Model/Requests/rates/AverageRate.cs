using System;
using System.Collections.Generic;
using System.Text;

namespace liriksi.Model.Requests.rates
{
    public class AverageRate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double AvgRate { get; set; }
    }
}
