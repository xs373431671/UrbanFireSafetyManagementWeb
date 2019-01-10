using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using UFSM_BusinessLogicLayer;
using UFSM_Model;

namespace UrbanFireSafetyManagementWeb
{
    /// <summary>
    /// 处理登录页面发来的用户信息
    /// </summary>
    public class SignIn : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType ="text/html";
            if(CheckValidateCode(context))
            {
                CheckUserInfo(context);
            }
            else
            {
                context.Response.Write("<script>alert('" + "验证码错误！" + "');window.location = 'Index.html';</script>");
            }
        }


        protected bool CheckValidateCode(HttpContext context)
        {
            bool isSucess = false;
            if (context.Session["validateCode"] != null)//在使用 Session 时一定要校验是否为空    
            {
                string yzm = context.Request.Form["yzm"].Trim();//获取用户输入的验证码。
                string sessionYzm = context.Session["validateCode"].ToString().Trim();
                //比较时忽略大小写                  
                if (sessionYzm.Equals(yzm, StringComparison.InvariantCultureIgnoreCase))
                {
                    isSucess = true;
                    context.Session["validateCode"] = null;//清空 session，防止再次被使用              
                }
            }
            return isSucess;
        }


        protected void CheckUserInfo(HttpContext context)
        {
            UserInfo user = new UserInfo();
            //获取用户输入的用户名和密码.       
            user.Account = context.Request.Form["account"];
            user.Password = context.Request.Form["password"];

            //校验用户名密码.             
            UserInfoService userInfoService = new UserInfoService();
            string returnMessage = string.Empty;

            //判断用户名与密码
            UserInfo signUser = userInfoService.CheckUserInfo(user, out returnMessage);
            try
            {
                if(signUser.Authority=="admin")
                {
                    context.Response.Write("<script>alert('" + "登录失败，您的权限为管理员权限，此系统仅允许普通权限工作人员登录！" + "');window.location = 'Index.html';</script>");
                    return;
                }
                if (signUser.ID > 0)
                {
                    context.Session["userInfo"] = signUser;
                    context.Response.Write("<script>alert('" + "登录成功！" + "');window.location = 'HomePage.aspx';</script>");
                }
                else
                {
                    context.Response.Write("<script>alert('" + "帐号或密码错误！" + "');window.location = 'Index.html';</script>");
                }
            }
            catch
            {
                context.Response.Write("<script>alert('" + "帐号或密码错误！" + "');window.location = 'Index.html';</script>");
            }           
         }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}