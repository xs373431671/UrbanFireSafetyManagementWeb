using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UFSM_Model;
using UFSM_BusinessLogicLayer;

namespace UrbanFireSafetyManagementWeb
{
    public partial class PersonInfoPage : System.Web.UI.Page
    {
        public UserInfo WorkUser { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfo userCookie = new UserInfo();
            userCookie.Account = Request.Cookies["userInfo"]["Account"];
            userCookie.Password = Request.Cookies["userInfo"]["Password"];
            string returnMessage2 = string.Empty;
            WorkUser = new UserInfo();
            WorkUser = new UserInfoService().CheckUserInfo(userCookie, out returnMessage2);
            if (IsPostBack)
            {
                UserInfo user = WorkUser;
                UserInfoService userService = new UserInfoService();
                string returnMessage = string.Empty;
                
                user.Name = Request.Form["name"];
                user.Department = Request.Form["department"];
                user.Password = Request.Form["password"];
                user.Email = Request.Form["email"];
                user.Telephone = Request.Form["telephone"];

                if (userService.ChangeUserInfo(user, out returnMessage))
                {
                    //Session["userInfo"] = user;
                    
                    Response.Write("<script>alert('" + returnMessage + "');window.location = 'PersonInfoPage.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>alert('" + returnMessage + "');window.location = 'PersonInfoPage.aspx';</script>");
                }
            }
                      
        }
    }
}