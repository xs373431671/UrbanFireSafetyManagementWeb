using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFSM_Model;

namespace UFSM_DataAccessLayer
{
    public class AreaInfoDal
    {
        /// <summary>
        /// 根据内存表的行，返回对应的AreaInfo对象
        /// </summary>
        /// <param name="dr">内存表的行</param>
        /// <returns></returns>
        private AreaInfo GetAreaInfoFromDataRow(DataRow dr)
        {
            AreaInfo areaInfo = new AreaInfo();
            areaInfo.ID = Convert.ToUInt32(dr["ID"]);
            areaInfo.AreaNum = Convert.ToUInt32(dr["AreaNum"]);

            areaInfo.Attribute = dr["Attribute"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["Attribute"]);
            areaInfo.PopQuality = dr["PopQuality"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["PopQuality"]);
            areaInfo.BuildingFireResistanceRating= dr["BuildingFireResistanceRating"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["BuildingFireResistanceRating"]);
            areaInfo.PopDensity = dr["PopDensity"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["PopDensity"]);
            areaInfo.BuildingYears = dr["BuildingYears"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["BuildingYears"]);
            areaInfo.FireSafetyPropaganda= dr["FireSafetyPropaganda"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["FireSafetyPropaganda"]);
            areaInfo.AgingOfPowerLines = dr["AgingOfPowerLines"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["AgingOfPowerLines"]);
            areaInfo.FireInspectionOfKeyBuildings= dr["FireInspectionOfKeyBuildings"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["FireInspectionOfKeyBuildings"]); 
            areaInfo.TimeFactor= dr["TimeFactor"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["TimeFactor"]);

            areaInfo.EconomicDensity= dr["EconomicDensity"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["EconomicDensity"]);
            areaInfo.HighBuildingsNum= dr["HighBuildingsNum"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["HighBuildingsNum"]); 
            areaInfo.UndergroundCrowdedSpace= dr["UndergroundCrowdedSpace"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["UndergroundCrowdedSpace"]);
            areaInfo.DensityOfKeyBuildings= dr["DensityOfKeyBuildings"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["DensityOfKeyBuildings"]);
            areaInfo.RoadCongestion= dr["RoadCongestion"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["RoadCongestion"]);
            areaInfo.BuildingDensity= dr["BuildingDensity"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["BuildingDensity"]);
            areaInfo.DistributionOfInflammableStorage= dr["DistributionOfInflammableStorage"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["DistributionOfInflammableStorage"]);
            areaInfo.FireStationCapacityCoverage= dr["FireStationCapacityCoverage"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["FireStationCapacityCoverage"]);
            areaInfo.FireStationEquipment= dr["FireStationEquipment"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["FireStationEquipment"]); 
            areaInfo.KeyBuildingsFirePreventBuilt= dr["KeyBuildingsFirePreventBuilt"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["KeyBuildingsFirePreventBuilt"]);
            areaInfo.PublicFireFacilities=dr["PublicFireFacilities"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["PublicFireFacilities"]);
            areaInfo.FireAndRescuePlan = dr["FireAndRescuePlan"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["FireAndRescuePlan"]);
            areaInfo.DepartmentalEmergencyResponse= dr["DepartmentalEmergencyResponse"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["DepartmentalEmergencyResponse"]);
            areaInfo.PowerLineLoad= dr["PowerLineLoad"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["PowerLineLoad"]);
            areaInfo.FireSafetyManagement= dr["FireSafetyManagement"] == DBNull.Value ? (byte)0 : Convert.ToByte(dr["FireSafetyManagement"]);

            areaInfo.AreaUploadTime = dr["AreaUploadTime"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(dr["AreaUploadTime"]);
            areaInfo.AreaAssessmentYear = dr["AreaAssessmentYear"] == DBNull.Value ? 0 : Convert.ToUInt32(dr["AreaAssessmentYear"]);
            areaInfo.AreaRiskGrade = dr["AreaRiskGrade"] == DBNull.Value ? (byte)0:Convert.ToByte(dr["AreaRiskGrade"]);
            areaInfo.AreaSize = dr["AreaSize"]== DBNull.Value ? 0:Convert.ToUInt32(dr["AreaSize"]);
            areaInfo.AreaPop = dr["AreaPop"]==DBNull.Value?0:Convert.ToUInt32(dr["AreaPop"]);

            return areaInfo;
        }



        /// <summary>
        /// 查询：根据数据库的UFSM_AreaInfo表，获取AreaInfo对象集合
        /// </summary>
        /// <returns></returns>
        public List<AreaInfo> GetAreaInfoList()
        {
            string sql = "select * from UFSM_AreaInfo";
            DataTable dataTable = SqlHelper.GetDataTable(sql);
            List<AreaInfo> areaInfoList = null;

            if(dataTable.Rows.Count>0)
            {
                areaInfoList = new List<AreaInfo>();
                AreaInfo areaInfo;
                foreach (DataRow dr in dataTable.Rows)
                {
                    areaInfo = GetAreaInfoFromDataRow(dr);
                    areaInfoList.Add(areaInfo);
                }
                return areaInfoList;
            }
            else
            {
                return new List<AreaInfo>();
            }
        }


        /// <summary>
        ///  添加：根据AreaInfo对象，向数据库添加信息
        /// </summary>
        /// <param name="ai">要添加的UserInfo对象</param>
        /// <returns></returns>
        public int AddAreaInfo(AreaInfo ai)
        {
            string sql = @"insert into UFSM_AreaInfo
                               ([AreaNum]
                              ,[Attribute]
                              ,[PopQuality]
                              ,[BuildingFireResistanceRating]
                              ,[PopDensity]
                              ,[BuildingYears]
                              ,[FireSafetyPropaganda]
                              ,[PowerLineLoad]
                              ,[FireSafetyManagement]
                              ,[AgingOfPowerLines]
                              ,[FireInspectionOfKeyBuildings]
                              ,[TimeFactor]
                              ,[EconomicDensity]
                              ,[HighBuildingsNum]
                              ,[UndergroundCrowdedSpace]
                              ,[DensityOfKeyBuildings]
                              ,[RoadCongestion]
                              ,[BuildingDensity]
                              ,[DistributionOfInflammableStorage]
                              ,[FireStationCapacityCoverage]
                              ,[FireStationEquipment]
                              ,[PublicFireFacilities]
                              ,[DepartmentalEmergencyResponse]
                              ,[FireAndRescuePlan]
                              ,[KeyBuildingsFirePreventBuilt]
                              ,[AreaUploadTime]
                              ,[AreaAssessmentYear]
                              ,[AreaRiskGrade]
                              ,[AreaSize]
                              ,[AreaPop])
                        values
                            (@AreaNum
                            ,@Attribute
                            ,@PopQuality
                            ,@BuildingFireResistanceRating
                            ,@PopDensity
                            ,@BuildingYears
                            ,@FireSafetyPropaganda
                            ,@PowerLineLoad
                            ,@FireSafetyManagement
                            ,@AgingOfPowerLines
                            ,@FireInspectionOfKeyBuildings
                            ,@TimeFactor
                            ,@EconomicDensity
                            ,@HighBuildingsNum
                            ,@UndergroundCrowdedSpace
                            ,@DensityOfKeyBuildings
                            ,@RoadCongestion
                            ,@BuildingDensity
                            ,@DistributionOfInflammableStorage
                            ,@FireStationCapacityCoverage
                            ,@FireStationEquipment
                            ,@PublicFireFacilities
                            ,@DepartmentalEmergencyResponse
                            ,@FireAndRescuePlan
                            ,@KeyBuildingsFirePreventBuilt
                            ,@AreaUploadTime
                            ,@AreaAssessmentYear
                            ,@AreaRiskGrade
                            ,@AreaSize
                            ,@AreaPop)";
            SqlParameter[] pars =
            {
                new SqlParameter("@AreaNum",SqlDbType.Int),
                new SqlParameter("@Attribute",SqlDbType.TinyInt),
                new SqlParameter("@PopQuality",SqlDbType.TinyInt),
                new SqlParameter("@BuildingFireResistanceRating",SqlDbType.TinyInt),
                new SqlParameter("@PopDensity",SqlDbType.TinyInt),
                new SqlParameter("@BuildingYears",SqlDbType.TinyInt),
                new SqlParameter("@FireSafetyPropaganda",SqlDbType.TinyInt),
                new SqlParameter("@PowerLineLoad",SqlDbType.TinyInt),
                new SqlParameter("@FireSafetyManagement",SqlDbType.TinyInt),
                new SqlParameter("@AgingOfPowerLines",SqlDbType.TinyInt),
                new SqlParameter("@FireInspectionOfKeyBuildings",SqlDbType.TinyInt),
                new SqlParameter("@TimeFactor",SqlDbType.TinyInt),
                new SqlParameter("@EconomicDensity",SqlDbType.TinyInt),
                new SqlParameter("@HighBuildingsNum",SqlDbType.TinyInt),
                new SqlParameter("@UndergroundCrowdedSpace",SqlDbType.TinyInt),
                new SqlParameter("@DensityOfKeyBuildings",SqlDbType.TinyInt),
                new SqlParameter("@RoadCongestion",SqlDbType.TinyInt),
                new SqlParameter("@BuildingDensity",SqlDbType.TinyInt),
                new SqlParameter("@DistributionOfInflammableStorage",SqlDbType.TinyInt),
                new SqlParameter("@FireStationCapacityCoverage",SqlDbType.TinyInt),
                new SqlParameter("@FireStationEquipment",SqlDbType.TinyInt),
                new SqlParameter("@PublicFireFacilities",SqlDbType.TinyInt),
                new SqlParameter("@DepartmentalEmergencyResponse",SqlDbType.TinyInt),
                new SqlParameter("@FireAndRescuePlan",SqlDbType.TinyInt),
                new SqlParameter("@KeyBuildingsFirePreventBuilt",SqlDbType.TinyInt),
                new SqlParameter("@AreaUploadTime",SqlDbType.DateTime),
                new SqlParameter("@AreaAssessmentYear",SqlDbType.Int),
                new SqlParameter("@AreaRiskGrade",SqlDbType.TinyInt),
                new SqlParameter("@AreaSize",SqlDbType.Int),
                new SqlParameter("@AreaPop",SqlDbType.Int),
            };
            pars[0].Value = ai.AreaNum;
            pars[1].Value = ai.Attribute;
            pars[2].Value = ai.PopQuality;
            pars[3].Value = ai.BuildingFireResistanceRating;
            pars[4].Value = ai.PopDensity;
            pars[5].Value = ai.BuildingYears;
            pars[6].Value = ai.FireSafetyPropaganda;
            pars[7].Value = ai.PowerLineLoad;
            pars[8].Value = ai.FireSafetyManagement;
            pars[9].Value = ai.AgingOfPowerLines;
            pars[10].Value =ai.FireInspectionOfKeyBuildings;
            pars[11].Value =ai.TimeFactor;
            pars[12].Value = ai.EconomicDensity;
            pars[13].Value = ai.HighBuildingsNum;
            pars[14].Value = ai.UndergroundCrowdedSpace;
            pars[15].Value = ai.DensityOfKeyBuildings;
            pars[16].Value = ai.RoadCongestion;
            pars[17].Value = ai.BuildingDensity;
            pars[18].Value = ai.DistributionOfInflammableStorage;
            pars[19].Value = ai.FireStationCapacityCoverage;
            pars[20].Value = ai.FireStationEquipment;
            pars[21].Value = ai.PublicFireFacilities;
            pars[22].Value = ai.DepartmentalEmergencyResponse;
            pars[23].Value = ai.FireAndRescuePlan;
            pars[24].Value = ai.KeyBuildingsFirePreventBuilt;
            pars[25].Value = ai.AreaUploadTime;
            pars[26].Value = ai.AreaAssessmentYear;
            pars[27].Value = ai.AreaRiskGrade;
            pars[28].Value = ai.AreaSize;
            pars[29].Value = ai.AreaPop;

            return SqlHelper.ExecuteNonQuery(sql, pars);
        }



        /// <summary>
        /// 更改：根据AreaInfo对象的AreaNum属性，更改数据库对应行
        /// </summary>
        /// <param name="ai">要更改的AreaInfo对象</param>
        /// <returns></returns>
        public bool ChangeAreaInfoByAreaNum(AreaInfo ai)
        {
            string sql = @"UPDATE UFSM_AreaInfo
                SET [Attribute] = @Attribute
                   ,[PopQuality] = @PopQuality
                   ,[BuildingFireResistanceRating] = @BuildingFireResistanceRating
                   ,[PopDensity] = @PopDensity
                   ,[BuildingYears] = @BuildingYears
                   ,[FireSafetyPropaganda] = @FireSafetyPropaganda
                   ,[PowerLineLoad] = @PowerLineLoad
                   ,[FireSafetyManagement] = @FireSafetyManagement
                   ,[AgingOfPowerLines] = @AgingOfPowerLines
                   ,[FireInspectionOfKeyBuildings] = @FireInspectionOfKeyBuildings
                   ,[TimeFactor] = @TimeFactor
                   ,[EconomicDensity] = @EconomicDensity
                   ,[HighBuildingsNum] = @HighBuildingsNum
                   ,[UndergroundCrowdedSpace] = @UndergroundCrowdedSpace
                   ,[DensityOfKeyBuildings] = @DensityOfKeyBuildings
                   ,[RoadCongestion] = @RoadCongestion
                   ,[BuildingDensity] = @BuildingDensity
                   ,[DistributionOfInflammableStorage] = @DistributionOfInflammableStorage
                   ,[FireStationCapacityCoverage] = @FireStationCapacityCoverage
                   ,[FireStationEquipment] = @FireStationEquipment
                   ,[PublicFireFacilities] = @PublicFireFacilities
                   ,[DepartmentalEmergencyResponse] = @DepartmentalEmergencyResponse
                   ,[FireAndRescuePlan] = @FireAndRescuePlan
                   ,[KeyBuildingsFirePreventBuilt] = @KeyBuildingsFirePreventBuilt
                   ,[AreaUploadTime] = @AreaUploadTime
                   ,[AreaAssessmentYear] = @AreaAssessmentYear
                   ,[AreaRiskGrade] = @AreaRiskGrade
                   ,[AreaSize] = @AreaSize
                   ,[AreaPop] = @AreaPop
                WHERE [AreaNum] = @AreaNum";

            SqlParameter[] pars =
           {
                new SqlParameter("@AreaNum",SqlDbType.Int),
                new SqlParameter("@Attribute",SqlDbType.TinyInt),
                new SqlParameter("@PopQuality",SqlDbType.TinyInt),
                new SqlParameter("@BuildingFireResistanceRating",SqlDbType.TinyInt),
                new SqlParameter("@PopDensity",SqlDbType.TinyInt),
                new SqlParameter("@BuildingYears",SqlDbType.TinyInt),
                new SqlParameter("@FireSafetyPropaganda",SqlDbType.TinyInt),
                new SqlParameter("@PowerLineLoad",SqlDbType.TinyInt),
                new SqlParameter("@FireSafetyManagement",SqlDbType.TinyInt),
                new SqlParameter("@AgingOfPowerLines",SqlDbType.TinyInt),
                new SqlParameter("@FireInspectionOfKeyBuildings",SqlDbType.TinyInt),
                new SqlParameter("@TimeFactor",SqlDbType.TinyInt),
                new SqlParameter("@EconomicDensity",SqlDbType.TinyInt),
                new SqlParameter("@HighBuildingsNum",SqlDbType.TinyInt),
                new SqlParameter("@UndergroundCrowdedSpace",SqlDbType.TinyInt),
                new SqlParameter("@DensityOfKeyBuildings",SqlDbType.TinyInt),
                new SqlParameter("@RoadCongestion",SqlDbType.TinyInt),
                new SqlParameter("@BuildingDensity",SqlDbType.TinyInt),
                new SqlParameter("@DistributionOfInflammableStorage",SqlDbType.TinyInt),
                new SqlParameter("@FireStationCapacityCoverage",SqlDbType.TinyInt),
                new SqlParameter("@FireStationEquipment",SqlDbType.TinyInt),
                new SqlParameter("@PublicFireFacilities",SqlDbType.TinyInt),
                new SqlParameter("@DepartmentalEmergencyResponse",SqlDbType.TinyInt),
                new SqlParameter("@FireAndRescuePlan",SqlDbType.TinyInt),
                new SqlParameter("@KeyBuildingsFirePreventBuilt",SqlDbType.TinyInt),
                new SqlParameter("@AreaUploadTime",SqlDbType.DateTime),
                new SqlParameter("@AreaAssessmentYear",SqlDbType.Int),
                new SqlParameter("@AreaRiskGrade",SqlDbType.TinyInt),
                new SqlParameter("@AreaSize",SqlDbType.Int),
                new SqlParameter("@AreaPop",SqlDbType.Int),
            };
            pars[0].Value = ai.AreaNum;
            pars[1].Value = ai.Attribute;
            pars[2].Value = ai.PopQuality;
            pars[3].Value = ai.BuildingFireResistanceRating;
            pars[4].Value = ai.PopDensity;
            pars[5].Value = ai.BuildingYears;
            pars[6].Value = ai.FireSafetyPropaganda;
            pars[7].Value = ai.PowerLineLoad;
            pars[8].Value = ai.FireSafetyManagement;
            pars[9].Value = ai.AgingOfPowerLines;
            pars[10].Value = ai.FireInspectionOfKeyBuildings;
            pars[11].Value = ai.TimeFactor;
            pars[12].Value = ai.EconomicDensity;
            pars[13].Value = ai.HighBuildingsNum;
            pars[14].Value = ai.UndergroundCrowdedSpace;
            pars[15].Value = ai.DensityOfKeyBuildings;
            pars[16].Value = ai.RoadCongestion;
            pars[17].Value = ai.BuildingDensity;
            pars[18].Value = ai.DistributionOfInflammableStorage;
            pars[19].Value = ai.FireStationCapacityCoverage;
            pars[20].Value = ai.FireStationEquipment;
            pars[21].Value = ai.PublicFireFacilities;
            pars[22].Value = ai.DepartmentalEmergencyResponse;
            pars[23].Value = ai.FireAndRescuePlan;
            pars[24].Value = ai.KeyBuildingsFirePreventBuilt;
            pars[25].Value = ai.AreaUploadTime;
            pars[26].Value = ai.AreaAssessmentYear;
            pars[27].Value = ai.AreaRiskGrade;
            pars[28].Value = ai.AreaSize;
            pars[29].Value = ai.AreaPop;

            if(SqlHelper.ExecuteNonQuery(sql, pars) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 通过AreaNum属性删除数据库中的AreaInfo对象
        /// </summary>
        /// <param name="ai">设置好AreaNum属性的AreaInfo对象</param>
        /// <returns></returns>
        public bool DeleteAreaInfoByAreaNum(AreaInfo ai)
        {
            string sql = "delete from UFSM_AreaInfo where AreaNum=@AreaNum";
            SqlParameter p = new SqlParameter("@AreaNum", ai.AreaNum);
            if(SqlHelper.ExecuteNonQuery(sql,p)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
