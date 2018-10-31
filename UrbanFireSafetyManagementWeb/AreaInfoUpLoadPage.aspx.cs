﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UFSM_BusinessLogicLayer;
using UFSM_Model;

namespace UrbanFireSafetyManagementWeb
{
    public partial class AreaInfoUpLoadPage : System.Web.UI.Page
    {
        /// <summary>
        /// 存放表格信息
        /// </summary>
        public string TableContent { get; set; }
        public string ReturnMessage;
        public UserInfo NormalUser { get; set; }
        public AreaInfo Area { get; set; }





        protected void Page_Load(object sender, EventArgs e)
        {
            ReturnMessage = "无";

            NormalUser = new UserInfo() { AreaNum = 999 };     //实际项目中从session中获取***********************************************
           

            AreaInfoService areaService = new AreaInfoService();
            //为Area属性赋值（根据当前用户的AreaNum属性）
            Area = areaService.SelectAreaInfo(NormalUser.AreaNum, out ReturnMessage);

            if(Area==null)
            {
                Area = new AreaInfo();
                Area.AreaNum = (uint)NormalUser.AreaNum;                
            }
           
    

           
            
        }
    }
}