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
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //以下这段代码用来判别用户在登录网站的时候是否已经登录（在部署项目时取消注释）
            
            //try
            //{
            //    if (Session["userInfo"] != null)
            //    {
                                    
            //    }
            //    else
            //    {
            //        Response.Write("<script>alert('" + "请先登录！" + "');window.location = 'Index.html';</script>");
            //    }
            //}
            //catch
            //{
            //    Response.Write("<script>alert('" + "请先登录！" + "');window.location = 'Index.html';</script>");
            //}
            

            
        }
    }
}