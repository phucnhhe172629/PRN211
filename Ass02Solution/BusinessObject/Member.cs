using System;
using System.Collections.Generic;

namespace BusinessObject
{ 
    public partial class Member
    {
        public Member()
        {
            Orders = new HashSet<Order>();
        }

        public int MemberId { get; set; }
        public string Email { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Password { get; set; } = null!;

        public Member(string Email, string CompanyName, string City, string Country, string Password)
        {
            this.Email = Email;
            this.CompanyName = CompanyName;
            this.City = City;
            this.Country = Country;
            this.Password = Password;
        }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
