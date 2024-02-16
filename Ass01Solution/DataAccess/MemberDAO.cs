using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObject;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> MemberList = new List<MemberObject>()
        {
            new MemberObject{ID = 2, Name = "Nguyen Thi Lan", Email = "lannguyen89@gmail.com", Password = "1", City = "Ho Chi Minh City", Country = "Viet Nam"},
            new MemberObject{ID = 3, Name = "Tran Van Minh", Email = "minhtran25@yahoo.com", Password = "1", City = "Da Nang", Country = "Viet Nam"},
            new MemberObject{ID = 4, Name = "Le Thi Thuy", Email = "thuy.le@fpt.edu.vn", Password = "1", City = "Ha Noi", Country = "Viet Nam"},
            new MemberObject{ID = 5, Name = "Ngo Duc Anh", Email = "ducanhngo@hotmail.com", Password = "1", City = "Can Tho", Country = "Viet Nam"},
            new MemberObject{ID = 6, Name = "Pham Thi Huong", Email = "huong.pham12@gmail.com", Password = "1", City = "Hai Phong", Country = "Viet Nam"},
            new MemberObject{ID = 7, Name = "Ayana Tanaka", Email = "ayana.tanaka@japanmail.jp", Password = "1", City = "Tokyo", Country = "Japan"},
            new MemberObject{ID = 8, Name = "Jean DuBois", Email = "jean.dubois@orange.fr", Password = "1", City = "Paris", Country = "France"},
            new MemberObject{ID = 9, Name = "Maria Fernandez", Email = "maria.fernandez@hotmail.es", Password = "1", City = "Madrid", Country = "Spain"},
            new MemberObject{ID = 10, Name = "Lukas Schmidt", Email = "lukas.schmidt@gmx.de", Password = "1", City = "Berlin", Country = "Germany"},
            new MemberObject{ID = 11, Name = "Elena Petrova", Email = "elena.petrova@mail.ru", Password = "1", City = "Moscow", Country = "Russia"},
            new MemberObject{ID = 12, Name = "Ayesha Ali", Email = "ayesha.ali@pakistanmail.pk", Password = "1", City = "Islamabad", Country = "Pakistan"},
            new MemberObject{ID = 13, Name = "Omar Hernandez", Email = "omar.hernandez@yahoo.com.mx", Password = "1", City = "Mexico City", Country = "Mexico"},
            new MemberObject{ID = 14, Name = "David Miller", Email = "david.miller@bigpond.com", Password = "1", City = "Sydney", Country = "Australia"},
            new MemberObject{ID = 15, Name = "Lin Wang", Email = "lin.wang@qq.com", Password = "1   ", City = "Beijing", Country = "China"},
        };

        // Using Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO()
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string adminEmail = configurationRoot["admin:email"];
            string adminPassword = configurationRoot["admin:password"];
            MemberList.Add(new MemberObject(1, "Admin", adminEmail, adminPassword, "Ha Noi", "VietNam"));
        }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public List<MemberObject> GetMemberList => MemberList;

        public MemberObject GetMemberByID(int MemberID) => MemberList.SingleOrDefault(m => m.ID == MemberID);

        // Add new a Member
        public void AddNew(MemberObject Member)
        {
            MemberObject member = GetMemberByID(Member.ID);
            if (member == null)
            {
                MemberList.Add(Member);
            }
            else
            {
                throw new Exception("Member is alreadly exist.");
            }
        }

        // Update a Member
        public void Update(MemberObject Member)
        {
            MemberObject m = GetMemberByID(Member.ID);
            if (m != null)
            {
                var index = MemberList.IndexOf(m);
                MemberList[index] = Member;
            }
            else
            {
                throw new Exception("Member does not already exist.");
            }
        }

        // Remove a Member
        public void Remove(int MemberID)
        {
            MemberObject m = GetMemberByID(MemberID);
            if (m != null)
            {
                MemberList.Remove(m);
            }
            else
            {
                throw new Exception("Member does not already exist");
            }
        }

        public List<MemberObject> GetMemberListByName(string Name) => MemberList.FindAll(m => m.Name.ToLower().Contains(Name.ToLower()));

        public List<MemberObject> GetMemberListByID(string ID) => MemberList.FindAll(m => m.ID.ToString().Contains(ID));

        public List<string> GetCityList() => MemberList.Select(m => m.City).Distinct().ToList();

        public List<string> GetCountryList() => MemberList.Select(m => m.Country).Distinct().ToList();

        public List<MemberObject> FilterByCity(string City) => MemberList.FindAll(m => m.City.Equals(City));

        public List<MemberObject> FilterByCountry(string Country) => MemberList.FindAll(m => m.Country.Equals(Country));

        public MemberObject GetAccount(string email, string password) 
            => MemberList.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
    }
}
