using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UFSM_Model;
using UFSM_BusinessLogicLayer;
using UFSM_Tool;

namespace UrbanFireSafetyManagementWeb
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        public int AreaNum  //存放负责地区
        {
            get;
            set;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //判断用户Session["userInfo"]是否存在
            if (Session["userInfo"] == null)
            {
                Response.Redirect("Index.html");
            }
            else
            {
                Session.Timeout = 30;
            }
        }
    }
}