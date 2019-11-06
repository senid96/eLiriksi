using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace liriksi.Model.Requests
{
    public class UserInsertRequest
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        [MinLength(5)]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [MinLength(5)]
        public string Username { get; set; }
        [Required]
        public int UserType { get; set; }

        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
    }
}
