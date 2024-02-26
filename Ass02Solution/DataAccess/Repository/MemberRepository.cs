using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DAO;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int Id) => MemberDAO.Instance.Remove(Id);

        public Member GetMemberByID(int Id) => MemberDAO.Instance.GetMemberByID(Id);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();

        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);

        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);

        public Member GetAccount(string email, string password) => MemberDAO.Instance.GetAccount(email, password);
    }
}
