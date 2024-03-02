using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.Data.SqlClient;

namespace DataAccess.DAO
{
    public class MemberDAO
    {
        private static MemberDAO instance;
        private static readonly object instanceLock = new object();
        public MemberDAO() { }

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

        public MemberObject GetMemberByUsernameAndPassword(string Username, string Password)
        {
            string sql = "select * from Member where Email = @Email and Password = @Password";
            DataTable DataTable = DBContext.GetDataBySQL(sql, new SqlParameter("@Email", Username), new SqlParameter("@Password", Password));
            MemberObject MemberObject = null;
            foreach (DataRow dr in DataTable.Rows)
            {
                MemberObject = new MemberObject
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    MemberEmail = dr["Email"].ToString(),
                    MemberCity = dr["City"].ToString(),
                    MemberCountry = dr["Country"].ToString(),
                    MemberPassword = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
            }
            return MemberObject;
        }

        public List<MemberObject> GetMemberObject()
        {
            string sql = "select * from Member";
            var MemberList = new List<MemberObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql).Rows)
            {
                MemberObject member = new MemberObject
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    MemberEmail = dr["Email"].ToString(),
                    MemberCity = dr["City"].ToString(),
                    MemberCountry = dr["Country"].ToString(),
                    MemberPassword = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
                MemberList.Add(member);
            }
            return MemberList;
        }

        public MemberObject getMemberByID(int id)
        {
            string sql = "select * from Member where MemberId = @MemberId";
            DataTable dt = DBContext.GetDataBySQL(sql, new SqlParameter("@MemberId", id));
            MemberObject member = new MemberObject
            {
                MemberId = int.Parse(dt.Rows[0]["MemberId"].ToString()),
                MemberEmail = dt.Rows[0]["Email"].ToString(),
                MemberCity = dt.Rows[0]["City"].ToString(),
                MemberCountry = dt.Rows[0]["Country"].ToString(),
                MemberPassword = dt.Rows[0]["Password"].ToString(),
                CompanyName = dt.Rows[0]["CompanyName"].ToString()
            };
            return member;
        }

        public int AddMember(MemberObject member)
        {
            string sql = "insert into Member(Email, City, Country, Password, CompanyName) values(@Email, @City, @Country, @Password, @CompanyName)";
            DataTable dt = DBContext.GetDataBySQL(sql, new SqlParameter("@Email", member.MemberEmail), new SqlParameter("@City", member.MemberCity), new SqlParameter("@Country", member.MemberCountry), new SqlParameter("@Password", member.MemberPassword), new SqlParameter("@CompanyName", member.CompanyName));
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@Email", member.MemberEmail),
                    new SqlParameter("@City", member.MemberCity),
                    new SqlParameter("@Country", member.MemberCountry),
                    new SqlParameter("@Password", member.MemberPassword),
                    new SqlParameter("@CompanyName", member.CompanyName)
            };
            return DBContext.ExcuteSql(sql, parameters);
        }

        public int UpdateMember(MemberObject member)
        {
            string sql = "UPDATE Member SET Email = @Email, City = @City, Country = @Country, Password = @Password, CompanyName = @CompanyName WHERE MemberId = @MemberId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@Email", member.MemberEmail),
                    new SqlParameter("@City", member.MemberCity),
                    new SqlParameter("@Country", member.MemberCountry),
                    new SqlParameter("@Password", member.MemberPassword),
                    new SqlParameter("@CompanyName", member.CompanyName),
                    new SqlParameter("@MemberId", member.MemberId)
            };
            return DBContext.ExcuteSql(sql, parameters);
        }

        public int Remove(int id)
        {
            string sql = "delete from Member where MemberId = @MemberId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@MemberId", id)
            };
            return DBContext.ExcuteSql(sql, parameters);
        }

        public List<MemberObject> FilterByCity(string city)
        {
            string sql = "select * from Member where City = @City";
            List<MemberObject> memberObject = new List<MemberObject>();
            DataTable dataTable = DBContext.GetDataBySQL(sql, new SqlParameter("@City", city));
            foreach (DataRow dr in dataTable.Rows)
            {
                MemberObject member = new MemberObject
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    MemberEmail = dr["Email"].ToString(),
                    MemberCity = dr["City"].ToString(),
                    MemberCountry = dr["Country"].ToString(),
                    MemberPassword = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
                memberObject.Add(member);
            }
            return memberObject;
        }

        public List<MemberObject> FilterByCountry(string country)
        {
            string sql = "select * from Member where Country = @Country";
            List<MemberObject> memberObject = new List<MemberObject>();
            DataTable dataTable = DBContext.GetDataBySQL(sql, new SqlParameter("@Country", country));
            foreach (DataRow dr in dataTable.Rows)
            {
                MemberObject member = new MemberObject
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    MemberEmail = dr["Email"].ToString(),
                    MemberCity = dr["City"].ToString(),
                    MemberCountry = dr["Country"].ToString(),
                    MemberPassword = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
                memberObject.Add(member);
            }
            return memberObject;
        }

        public List<MemberObject> SearchMemberByName(string name)
        {
            string sql = "select * from Member where Name = @Name";
            List<MemberObject> memberObjects = new List<MemberObject>();
            DataTable dataTable = DBContext.GetDataBySQL(sql, new SqlParameter("@Name", name));
            foreach (DataRow dr in dataTable.Rows)
            {
                MemberObject memberObject = new MemberObject
                {
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    MemberEmail = dr["Email"].ToString(),
                    MemberCity = dr["City"].ToString(),
                    MemberCountry = dr["Country"].ToString(),
                    MemberPassword = dr["Password"].ToString(),
                    CompanyName = dr["CompanyName"].ToString()
                };
                memberObjects.Add(memberObject);
            }
            return memberObjects;
        }
    }
}
