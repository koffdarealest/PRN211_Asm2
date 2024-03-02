using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memberId)
        {
            MemberDAO.Instance.Remove(memberId);
        }

        public List<MemberObject> FilterByCity(string city)
        {
            return MemberDAO.Instance.FilterByCity(city);
        }

        public List<MemberObject> FilterByCountry(string country)
        {
            return MemberDAO.Instance.FilterByCountry(country);
        }

        public MemberObject getMemberByEmailPass(string email, string pass)
        {
            return MemberDAO.Instance.GetMemberByUsernameAndPassword(email, pass);
        }

        public MemberObject GetMemberById(int memberId)
        {
            return MemberDAO.Instance.getMemberByID(memberId);
        }

        public List<MemberObject> GetMembers()
        {
            return MemberDAO.Instance.GetMemberObject();
        }

        public void InsertMember(MemberObject member)
        {
            MemberDAO.Instance.AddMember(member);
        }

        public MemberObject SearchMemberById(int id)
        {
            return MemberDAO.Instance.getMemberByID(id);
        }

        public List<MemberObject> SearchMemberByName(string name)
        {
            return MemberDAO.Instance.SearchMemberByName(name);
        }

        public void UpdateMember(MemberObject member)
        {
            MemberDAO.Instance.UpdateMember(member);
        }
    }
}
