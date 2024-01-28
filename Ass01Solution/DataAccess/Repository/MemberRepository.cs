using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public MemberObject GetMemberByID(int MemberID) => MemberDAO.Instance.GetMemberByID(MemberID);

        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList;

        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNew(member);

        public void DeleteMember(int MemberID) => MemberDAO.Instance.Remove(MemberID);

        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);

        public List<MemberObject> GetMemberListByName(string Name) => MemberDAO.Instance.GetMemberListByName(Name);

        public List<MemberObject> GetMemberListById(string ID) => MemberDAO.Instance.GetMemberListByID(ID);

        public List<string> GetCityList() => MemberDAO.Instance.GetCityList();

        public List<string> GetCountryList() => MemberDAO.Instance.GetCountryList();

        public List<MemberObject> FilterByCity(string City) => MemberDAO.Instance.FilterByCity(City);

        public List<MemberObject> FilterByCountry(string Country) => MemberDAO.Instance.FilterByCountry(Country);

        public MemberObject GetAccount(string email, string password) => MemberDAO.Instance.GetAccount(email, password);
    }
}
