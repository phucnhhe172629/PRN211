using System.Collections.Generic;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int Id);
        void InsertMember(Member member);
        void DeleteMember(int Id);
        void UpdateMember(Member member);
        Member GetAccount(string email, string password);
    }
}
