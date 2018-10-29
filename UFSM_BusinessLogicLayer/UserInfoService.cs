using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFSM_DataAccessLayer;
using UFSM_Model;

namespace UFSM_BusinessLogicLayer
{
    public class UserInfoService
    {
        /// <summary>
        /// 获取数据库中的UserInfo集合
        /// </summary>
        private static List<UserInfo> userList = new UserInfoDal().GetUserInfoList();


        /// <summary>
        /// 向数据库注册UserInfo，返回一个bool。
        /// </summary>
        /// <param name="user">注册的UserInfo对象</param>
        /// <param name="returnMessage">返回注册信息字符串：如注册成功、失败</param>
        /// <returns></returns>
        public bool AddUserInfo(UserInfo user,out string returnMessage)
        {
            foreach(UserInfo u in userList)  
            {
                if(user.Account==u.Account)
                {
                    returnMessage = "对不起，该账号名已被占用!";
                    return false;
                }
            }

            UserInfoDal uid = new UserInfoDal();
            int influenceRow = uid.AddUserInfo(user);
            if(influenceRow>0)
            {
                userList = new UserInfoDal().GetUserInfoList();
                returnMessage = "注册成功，请返回登录";
                return true;
            }
            else
            {
                returnMessage = "数据库异常，注册失败，请稍后重试";
                return false;
            }
        }


        /// <summary>
        /// 检查登录信息，若登录成功，返回UserInfo对象，并out登录信息
        /// </summary>
        /// <param name="user">要登录的UserInfo对象</param>
        /// <param name="returnMessage">登录成功或失败的字符串</param>
        /// <returns></returns>
        public UserInfo CheckUserInfo(UserInfo user, out string returnMessage)
        {
            if (userList.Count > 0)
            {
                foreach (UserInfo u in userList)
                {
                    if (u.Account == user.Account && u.Password == user.Password)
                    {
                        returnMessage = "登录成功！";
                        return u;
                    }

                }
            }
            returnMessage = "账号或用户名错误！";
            return null;        
        }



    }
}
