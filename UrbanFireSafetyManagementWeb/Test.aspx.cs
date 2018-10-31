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
            user.AreaNum = 999;
            Session["userInfo"] = user;

            Response.Redirect("Index.ashx");
        }
    }
}