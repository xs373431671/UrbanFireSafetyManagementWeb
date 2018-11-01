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
    public partial class CheckAreaInfoPage : System.Web.UI.Page
    {
        /// <summary>
        /// 存放表格信息
        /// </summary>
        public UserInfo NormalUser { get; set; }
        public AreaInfo Area { get; set; }
        public string returnMessage;


        protected void Page_Load(object sender, EventArgs e)
        {
            NormalUser = new UserInfo() { AreaNum = 999 };     //实际项目中从session中获取***********************************************
            returnMessage = string.Empty;
            AreaInfoService areaService = new AreaInfoService();
            //为Area属性赋值（根据当前用户的AreaNum属性）
            Area = areaService.SelectAreaInfo(NormalUser.AreaNum,out returnMessage);         
        }
    }
}