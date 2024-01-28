using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public class MemberObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public MemberObject(int iD, string name, string email, string password, string city, string country)
        {
            ID = iD;
            Name = name;
            Email = email;
            Password = password;
            City = city;
            Country = country;
        }

        public MemberObject()
        {
        }
    }
}
