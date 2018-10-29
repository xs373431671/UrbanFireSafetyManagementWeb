using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UFSM_BusinessLogicLayer;
using UFSM_Model;

namespace UrbanFireSafetyManagementWeb
{
    /// <summary>
    /// Register 的摘要说明
    /// </summary>
    public class Register : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            try
            {
                if (CheckValidateCode(context))
                {
                    AddUser(context);
                }
                else
                {
                    context.Response.Write("<script>alert('" + "验证码错误！" + "');window.location = 'Register.html';</script>");
                }
            }
            catch
            {
                context.Response.Write("<script>alert('" + "网络异常，请重试！" + "');window.location = 'Register.html';</script>");
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



        protected void AddUser(HttpContext context)
        {
            UserInfo user = new UserInfo();
            UserInfoService userService = new UserInfoService();
            string returnMessage = string.Empty;

            user.Name = context.Request.Form["name"];
            user.Authority = "normal";
            user.AreaNum = Convert.ToInt32( context.Request.Form["areaNum"]);
            user.Department = context.Request.Form["department"];
            user.Account = context.Request.Form["account"];
            user.Password = context.Request.Form["password"];
            user.Email = context.Request.Form["email"];
            user.Telephone = context.Request.Form["telephone"];

            if(userService.AddUserInfo(user,out returnMessage))
            {
                context.Response.Write("<script>alert('" + returnMessage + "');window.location = 'Index.html';</script>");
            }
            else
            {
                context.Response.Write("<script>alert('" + returnMessage + "');window.location = 'Register.html';</script>");
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