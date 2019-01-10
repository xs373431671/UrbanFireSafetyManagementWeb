using System;
using System.Collections.Generic;
using System.IO;
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
            ReturnMessage = string.Empty;
            NormalUser = (UserInfo)Session["userInfo"];   //实际项目中从session中获取*********************************************** 

            if (IsPostBack)
            {
                HttpPostedFile upFile = Request.Files[0];
                if(upFile.ContentLength>0)
                {
                    string filePath = upFile.FileName;//全路径
                    string fileName = Path.GetFileName(filePath);
                    string fileExt = Path.GetExtension(fileName);
                    if(fileExt==".txt"||fileExt==".docx"||fileExt==".doc"||fileExt==".pdf")
                    {
                        upFile.SaveAs(Request.MapPath("/AssessmentReport/" + DateTime.Now.Year.ToString()+"_Area_"+NormalUser.AreaNum+fileExt));
                    }                    
                }

                AreaInfo area = new AreaInfo();
                area.AreaNum = Convert.ToUInt32(NormalUser.AreaNum);
                area.Attribute = Convert.ToByte(Request.Form["attribute"]);
                area.PopQuality = Convert.ToByte(Request.Form["popQuality"]);
                area.BuildingFireResistanceRating = Convert.ToByte(Request.Form["buildingFireResistanceRating"]);
                area.PopDensity = Convert.ToByte(Request.Form["popDensity"]);
                area.BuildingYears = Convert.ToByte(Request.Form["buildingYears"]);
                area.FireSafetyManagement = Convert.ToByte(Request.Form["fireSafetyManagement"]);
                area.AgingOfPowerLines = Convert.ToByte(Request.Form["agingOfPowerLines"]);
                area.FireInspectionOfKeyBuildings = Convert.ToByte(Request.Form["fireInspectionOfKeyBuildings"]);
                area.TimeFactor = 0;
                area.FireSafetyPropaganda = Convert.ToByte(Request.Form["fireSafetyPropaganda"]);
                area.PowerLineLoad = Convert.ToByte(Request.Form["powerLineLoad"]);
                area.EconomicDensity = Convert.ToByte(Request.Form["economicDensity"]);
                area.HighBuildingsNum = Convert.ToByte(Request.Form["highBuildingsNum"]);
                area.UndergroundCrowdedSpace = Convert.ToByte(Request.Form["undergroundCrowdedSpace"]);
                area.DensityOfKeyBuildings = Convert.ToByte(Request.Form["densityOfKeyBuildings"]);
                area.RoadCongestion = Convert.ToByte(Request.Form["roadCongestion"]);
                area.BuildingDensity = Convert.ToByte(Request.Form["buildingDensity"]);
                area.DistributionOfInflammableStorage = Convert.ToByte(Request.Form["distributionOfInflammableStorage"]);
                area.FireStationCapacityCoverage = Convert.ToByte(Request.Form["fireStationCapacityCoverage"]);
                area.FireStationEquipment = Convert.ToByte(Request.Form["fireStationEquipment"]);
                area.PublicFireFacilities = Convert.ToByte(Request.Form["publicFireFacilities"]);
                area.DepartmentalEmergencyResponse = Convert.ToByte(Request.Form["departmentalEmergencyResponse"]);
                area.FireAndRescuePlan = Convert.ToByte(Request.Form["fireAndRescuePlan"]);
                area.KeyBuildingsFirePreventBuilt = Convert.ToByte(Request.Form["keyBuildingsFirePreventBuilt"]);
                area.AreaUploadTime = DateTime.Now;
                area.AreaAssessmentYear = Convert.ToUInt32(DateTime.Now.Year);
                area.AreaRiskGrade = 0;
                area.AreaSize=0;
                area.AreaPop=0;

                AreaInfoService areaService = new AreaInfoService();
                if(areaService.AddAreaInfo(area,out ReturnMessage))
                {
                    Response.Write("<script>alert('" + ReturnMessage + "');window.location = 'CheckAreaInfoPage.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>alert('" + ReturnMessage + "');window.location = 'CheckAreaInfoPage.aspx';</script>");
                }                                  
            }
            else
            {

            }          
        }
    }
}