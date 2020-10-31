using System;
using System.Collections.Generic;
using System.Text;

namespace liriksi.Model.Requests.rates
{
    public class HasUserRatedRequest
    {
        public int UserId { get; set; }
        public int Id { get; set; } //song or album id
    }
}
