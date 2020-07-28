using System;
using System.Collections.Generic;
using System.Text;

namespace liriksi.Model.Requests
{
    public class UserGetRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName 
        { 
            get 
            {
                return Name + " " + Surname;
            }
        }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public bool Status { get; set; }
        public City City { get; set; }
        public UserType UserType { get; set; }
        public byte[] Image { get; set; }
    }
}
