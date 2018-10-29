using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFSM_Model;

namespace UFSM_DataAccessLayer
{
    public class UserInfoDal
    {
        /// <summary>
        /// 根据内存的表的行返回UserInfo对象
        /// </summary>
        /// <param name="user">UserInfo对象</param>
        /// <param name="dr">DataRow对象</param>
        /// <returns></returns>
        private UserInfo GetUserFromDataRow(DataRow dr)
        {
            UserInfo user = new UserInfo();
            user.ID = Convert.ToInt32(dr["ID"]);
            user.Name = dr["Name"] != DBNull.Value ? dr["Name"].ToString() :"NULL";
            user.Authority = dr["Authority"] .ToString() ;
            user.AreaNum = dr["AreaNum"] != DBNull.Value ? Convert.ToInt32(dr["AreaNum"]) : -1; 
            user.Department = dr["Department"] != DBNull.Value ? dr["Department"].ToString() : "NULL";
            user.Account = dr["Account"].ToString();
            user.Password = dr["Password"].ToString();
            user.Email=dr["Email"] != DBNull.Value ? dr["Email"].ToString() : "NULL";
            user.Telephone = dr["Telephone"] != DBNull.Value ? dr["Telephone"].ToString() : "NULL";
            return user;
        }


        /// <summary>
        /// 查询数据库用户信息表，返回UserInfo集合
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetUserInfoList()
        {
            string sql = "select * from UFSM_UserInfo";
            DataTable dt = SqlHelper.GetDataTable(sql);
            List<UserInfo> userList =null;
            if(dt.Rows.Count > 0 )
            {
                userList = new List<UserInfo>();
                UserInfo user = null;
                foreach (DataRow dr in dt.Rows)
                {
                    user = GetUserFromDataRow(dr);
                    userList.Add(user);
                }
            }
            return userList;
        }


        /// <summary>
        /// 添加用户信息：根据一个有内容的UserInfo对象向数据库添加信息,返回受影响行数。注意：如果数据库信息更新，要重新获取UserInfo集合（在业务层操作）。
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddUserInfo(UserInfo user)
        {
            string sql = "insert into UFSM_UserInfo(Name,Authority,AreaNum,Department,Account,Password,Email,Telephone) values(@Name,@Authority,@AreaNum,@Department,@Account,@Password,@Email,@Telephone)";

            SqlParameter[] pars = {
                new SqlParameter("@Name",SqlDbType.NVarChar,8),
                new SqlParameter("@Authority",SqlDbType.NVarChar, 8),
                new SqlParameter("@AreaNum", SqlDbType.Int),
                new SqlParameter("@Department", SqlDbType.NVarChar, 64),
                new SqlParameter("@Account", SqlDbType.NVarChar, 16),
                new SqlParameter("@Password", SqlDbType.NVarChar, 16),
                new SqlParameter("@Email", SqlDbType.NVarChar, 32),
                new SqlParameter("@Telephone", SqlDbType.NVarChar, 16)};
            pars[0].Value = user.Name;
            pars[1].Value = user.Authority;
            pars[2].Value = user.AreaNum;
            pars[3].Value = user.Department;
            pars[4].Value = user.Account;
            pars[5].Value = user.Password;
            pars[6].Value = user.Email;
            pars[7].Value = user.Telephone;

            return SqlHelper.ExecuteNonQuery(sql, pars);
        }


        /// <summary>
        /// 通过Account值删除数据库对应用户
        /// </summary>
        /// <param name="account">账号字符串</param>
        /// <returns></returns>
        public bool DeleteUserInfo(string account)
        {
            string sql = "delete from UFSM_UserInfo where Account=@Account";
            SqlParameter[] pars = { new SqlParameter("Account", account) };
            if(SqlHelper.ExecuteNonQuery(sql,pars)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            
    }
}
