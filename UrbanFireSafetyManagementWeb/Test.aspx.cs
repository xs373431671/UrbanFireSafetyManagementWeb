using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UFSM_Model;

namespace UrbanFireSafetyManagementWeb
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();
            user.ID = 1;
            user.Authority = "admin";
            user.Account = "xuesong";
            user.Password = "xuesong";
            user.Name = "薛嵩";
            user.AreaNum = 999;
            user.Department = "太原理工大学";
            user.Telephone = "15534598445";
            user.Email = "373431671@qq.com";
            Session["userInfo"] = user;

            Response.Redirect("PersonInfoPage.aspx");
        }
    }
}