using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace liriksi.Model
{
    public class UserType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
