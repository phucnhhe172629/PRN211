using BusinessObject;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class MemberDAO : DBContext
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
            string sql = "select * from Member";
            var memberList = new List<Member>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql).Rows)
            {
                Member member = new Member
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    Email = dr["Email"].ToString(),
                    City = dr["City"].ToString(),
                    Country = dr["Country"].ToString(),
                    Password = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
                memberList.Add(member);
            }
            return memberList;
        }
        public Member GetMemberByID(int id)
        {
            string sql = "select * from Member where MemberId = @MemberId";
            DataTable dt = DBContext.GetDataBySQL(sql, new SqlParameter("@MemberId", id));
            Member member = new Member
            {
                MemberId = int.Parse(dt.Rows[0]["MemberId"].ToString()),
                Email = dt.Rows[0]["Email"].ToString(),
                City = dt.Rows[0]["City"].ToString(),
                Country = dt.Rows[0]["Country"].ToString(),
                Password = dt.Rows[0]["Password"].ToString(),
                CompanyName = dt.Rows[0]["CompanyName"].ToString()
            };
            return member;
        }
        public void AddNew(Member member)
        {
            string sql = "insert into Member(Email, City, Country, Password, CompanyName) values(@Email, @City, @Country, @Password, @CompanyName)";
            DataTable dt = DBContext.GetDataBySQL(sql, new SqlParameter("@Email", member.Email), new SqlParameter("@City", member.City), new SqlParameter("@Country", member.Country), new SqlParameter("@Password", member.Password), new SqlParameter("@CompanyName", member.CompanyName));
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@Email", member.Email),
                    new SqlParameter("@City", member.City),
                    new SqlParameter("@Country", member.Country),
                    new SqlParameter("@Password", member.Password),
                    new SqlParameter("@CompanyName", member.CompanyName)
            };
            DBContext.ExcuteSql(sql, parameters);
        }
        public void Update(Member member)
        {
            string sql = "UPDATE Member SET Email = @Email, City = @City, Country = @Country, Password = @Password, CompanyName = @CompanyName WHERE MemberId = @MemberId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@Email", member.Email),
                    new SqlParameter("@City", member.City),
                    new SqlParameter("@Country", member.Country),
                    new SqlParameter("@Password", member.Password),
                    new SqlParameter("@CompanyName", member.CompanyName),
                    new SqlParameter("@MemberId", member.MemberId)
            };
            DBContext.ExcuteSql(sql, parameters);
        }
        public void Remove(int id)
        {
            string sql = "delete from Member where MemberId = @MemberId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@MemberId", id)
            };
            DBContext.ExcuteSql(sql, parameters);
        }
        public Member GetAccount(string email, string password)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string adminEmail = configurationRoot["admin:email"];
            string adminPassword = configurationRoot["admin:password"];
            if (email.Equals(adminEmail) && password.Equals(adminPassword))
                return new Member { Email = email, Password = password };
            string sql = "select * from Member where Email = @Email and Password = @Password";
            DataTable dt = DBContext.GetDataBySQL(sql, new SqlParameter("@Email", email), new SqlParameter("@Password", password));
            Member member = null;
            foreach (DataRow dr in dt.Rows)
            {
                member = new Member
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    Email = dr["Email"].ToString(),
                    City = dr["City"].ToString(),
                    Country = dr["Country"].ToString(),
                    Password = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
            }
            return member;
        }
    }
}
