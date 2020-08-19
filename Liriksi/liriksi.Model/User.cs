using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("UserTypeId")]
        public virtual UserType UserType { get; set; }
        public int? UserTypeId { get; set; }
        public string Username { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }

        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }
        public bool Status { get; set; } //active-inactive
        public byte[] Image { get; set; }
        public virtual ICollection<UsersSongRate> UsersSongRates { get; set; }
        public virtual ICollection<UsersAlbumRate> UsersAlbumRates { get; set; }
    }
}
