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


        //注册UserInfo，返回成功或失败字符串
        public string AddUserInfo(UserInfo user)
        {
            UserInfoDal uid = new UserInfoDal();
            int influenceRow = uid.AddUserInfo(user);
            if(influenceRow>0)
            {
                userList = new UserInfoDal().GetUserInfoList();
                return "注册成功";
            }
            else
            {
                return "注册失败";
            }
        }
    }
}
