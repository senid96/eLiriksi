using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace liriksi.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
      

    }
}
