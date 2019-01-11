using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UFSM_Model;
using UFSM_BusinessLogicLayer;
using System.IO;

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
        public string fileExist;


        protected void Page_Load(object sender, EventArgs e)
        {
            //NormalUser =(UserInfo)Session["userInfo"];     //实际项目中从session中获取
            NormalUser = new UserInfo();
            NormalUser.AreaNum = int.Parse(Request.Cookies["userInfo"]["AreaNum"]);
            returnMessage = string.Empty;
            AreaInfoService areaService = new AreaInfoService();
            //为Area属性赋值（根据当前用户的AreaNum属性）
            Area = areaService.SelectAreaInfo(NormalUser.AreaNum,out returnMessage);  
            if(File.Exists(Request.MapPath("/AssessmentReport/" + DateTime.Now.Year.ToString() + "_Area_" + NormalUser.AreaNum+".txt"))|| File.Exists(Request.MapPath("/AssessmentReport/" + DateTime.Now.Year.ToString() + "_Area_" + NormalUser.AreaNum + ".pdf"))|| File.Exists(Request.MapPath("/AssessmentReport/" + DateTime.Now.Year.ToString() + "_Area_" + NormalUser.AreaNum + ".doc"))|| File.Exists(Request.MapPath("/AssessmentReport/" + DateTime.Now.Year.ToString() + "_Area_" + NormalUser.AreaNum + ".docx")))
            {
                fileExist = "评估报告已上传成功！";
            }    
            else
            {
                fileExist = "评估报告未上传！";
            }  
        }
    }
}