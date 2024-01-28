using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();
        MemberObject GetMemberByID(int MemberID);
        void InsertMember(MemberObject member);
        void DeleteMember(int MemberID);
        void UpdateMember(MemberObject member);

        List<MemberObject> GetMemberListByName(string Name);

        List<MemberObject> GetMemberListById(string ID);

        List<string> GetCityList();

        List<string> GetCountryList();

        List<MemberObject> FilterByCity(string City);

        List<MemberObject> FilterByCountry(string Country);

        MemberObject GetAccount(string email, string password);
    }
}
