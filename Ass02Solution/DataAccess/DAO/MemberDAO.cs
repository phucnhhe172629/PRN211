using BusinessObject;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class MemberDAO : FStoreContext
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
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
        public IEnumerable<Member> GetMemberList()
        {
            using FStoreContext context = new FStoreContext();
            return context.Members.ToList();
        }
        public Member GetMemberByID(int id)
        {
            using FStoreContext context = new FStoreContext();
            return context.Members.SingleOrDefault(m => m.MemberId == id);
        }
        public void AddNew(Member member)
        {
            using FStoreContext context = new FStoreContext();
            context.Members.Add(member);
            context.SaveChanges();
        }
        public void Update(Member member)
        {
            using FStoreContext context = new FStoreContext();
            context.Members.Update(member);
            context.SaveChanges();
        }
        public void Remove(int id)
        {
            using FStoreContext context = new FStoreContext();
            context.Members.Remove(GetMemberByID(id));
            context.SaveChanges();
        }
        public Member GetAccount(string email, string password)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string adminEmail = configurationRoot["admin:email"];
            string adminPassword = configurationRoot["admin:password"];
            if (email.Equals(adminEmail) && password.Equals(adminPassword))
                return new Member { Email = email, Password = password };
            using FStoreContext context = new FStoreContext();
            return context.Members.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
        }
    }
}
