using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFSM_Model
{
    public class AreaInfo
    {
        private int id;
        private int areaNum;
        private int attribute;
        private int popQuality;
        private int buildingFireResistanceRating;
        private int popDensity;
        private int buildingYears;
        private int fireSafetyPropaganda;
        private int powerLineLoad;
        private int fireSafetyManagement;
        private int agingOfPowerLines;
        private int fireInspectionOfKeyBuildings;
        private int timeFactor;
        private int economicDensity;
        private int highBuildingsNum;
        private int undergroundCrowdedSpace;
        private int densityOfKeyBuildings;
        private int roadCongestion;
        private int buildingDensity;
        private int distributionOfInflammableStorage;
        private int fireStationCapacityCoverage;
        private int fireStationEquipment;
        private int publicFireFacilities;
        private int departmentalEmergencyResponse;
        private int fireAndRescuePlan;
        private int keyBuildingsFirePreventBuilt;
        private DateTime areaUploadTime;
        private int areaAssessmentYear;
        private int areaRiskGrade;
        private int areaSize;
        private int areaPop;

        public int ID
        {
            get { return id; }
            set { if (value < 0 || value > 100) { value = 0; } else { id = value; } }
        }

        public int AreaNum
        {
            get { return areaNum; }
            set { if (value < 0 || value > 100) { value = 0; } else { areaNum = value; } }
        }
        public int Attribute
        {
            get { return attribute; }
            set { if (value < 0 || value > 100) { value = 0; } else { attribute = value; } }
        }
        public int PopQuality
        {
            get { return popQuality; }
            set { if (value < 0 || value > 100) { value = 0; } else { popQuality = value; } }
        }
        public int BuildingFireResistanceRating
        {
            get { return buildingFireResistanceRating; }
            set { if (value < 0 || value > 100) { value = 0; } else { buildingFireResistanceRating = value; } }
        }
        public int PopDensity
        {
            get { return popDensity; }
            set { if (value < 0 || value > 100) { value = 0; } else { popDensity = value; } }
        }
        public int BuildingYears
        {
            get { return buildingYears; }
            set { if (value < 0 || value > 100) { value = 0; } else { buildingYears = value; } }
        }
        public int FireSafetyPropaganda
        {
            get { return fireSafetyPropaganda; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireSafetyPropaganda = value; } }
        }
        public int PowerLineLoad
        {
            get { return powerLineLoad; }
            set { if (value < 0 || value > 100) { value = 0; } else { powerLineLoad = value; } }
        }
        public int FireSafetyManagement
        {
            get { return fireSafetyManagement; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireSafetyManagement = value; } }
        }
        public int AgingOfPowerLines
        {
            get { return agingOfPowerLines; }
            set { if (value < 0 || value > 100) { value = 0; } else { agingOfPowerLines = value; } }
        }
        public int FireInspectionOfKeyBuildings
        {
            get { return fireInspectionOfKeyBuildings; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireInspectionOfKeyBuildings = value; } }
        }
        public int TimeFactor
        {
            get { return timeFactor; }
            set { if (value < 0 || value > 100) { value = 0; } else { timeFactor = value; } }
        }
        public int EconomicDensity
        {
            get { return economicDensity; }
            set { if (value < 0 || value > 100) { value = 0; } else { economicDensity = value; } }
        }
        public int HighBuildingsNum
        {
            get { return highBuildingsNum; }
            set { if (value < 0 || value > 100) { value = 0; } else { highBuildingsNum = value; } }
        }
        public int UndergroundCrowdedSpace
        {
            get { return undergroundCrowdedSpace; }
            set { if (value < 0 || value > 100) { value = 0; } else { undergroundCrowdedSpace = value; } }
        }
        public int DensityOfKeyBuildings
        {
            get { return densityOfKeyBuildings; }
            set { if (value < 0 || value > 100) { value = 0; } else { densityOfKeyBuildings = value; } }
        }
        public int RoadCongestion
        {
            get { return roadCongestion; }
            set { if (value < 0 || value > 100) { value = 0; } else { roadCongestion = value; } }
        }
        public int BuildingDensity
        {
            get { return buildingDensity; }
            set { if (value < 0 || value > 100) { value = 0; } else { buildingDensity = value; } }
        }
        public int DistributionOfInflammableStorage
        {
            get { return distributionOfInflammableStorage; }
            set { if (value < 0 || value > 100) { value = 0; } else { distributionOfInflammableStorage = value; } }
        }
        public int FireStationCapacityCoverage
        {
            get { return fireStationCapacityCoverage; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireStationCapacityCoverage = value; } }
        }
        public int FireStationEquipment
        {
            get { return fireStationEquipment; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireStationEquipment = value; } }
        }
        public int PublicFireFacilities
        {
            get { return publicFireFacilities; }
            set { if (value < 0 || value > 100) { value = 0; } else { publicFireFacilities = value; } }
        }
        public int DepartmentalEmergencyResponse
        {
            get { return departmentalEmergencyResponse; }
            set { if (value < 0 || value > 100) { value = 0; } else { departmentalEmergencyResponse = value; } }
        }
        public int FireAndRescuePlan
        {
            get { return fireAndRescuePlan; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireAndRescuePlan = value; } }
        }
        public int KeyBuildingsFirePreventBuilt
        {
            get { return keyBuildingsFirePreventBuilt; }
            set { if (value < 0 || value > 100) { value = 0; } else { keyBuildingsFirePreventBuilt = value; } }
        }
        public DateTime AreaUploadTime
        {
            get { return areaUploadTime; }
            set { areaUploadTime = value;  }
        }
        public int AreaAssessmentYear
        {
            get { return areaAssessmentYear; }
            set { areaAssessmentYear = value;}
        }
        public int AreaRiskGrade
        {
            get { return areaRiskGrade; }
            set { if (value < 0 || value > 5) { value = 0; } else { areaRiskGrade = value; } }
        }
        public int AreaSize{ get; set; }
        public int AreaPop{ get; set; }
    }
}
