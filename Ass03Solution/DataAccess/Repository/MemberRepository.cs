﻿using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();
        public Member GetMemberByID(int MemberID) => MemberDAO.Instance.GetMemberByID(MemberID);
        public Member GetMemberByAccount(string email, string password) => MemberDAO.Instance.GetMemberByAccount(email, password);

        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);
        public void DeleteMember(int MemberID) => MemberDAO.Instance.Remove(MemberID);
        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);     
    }
}
