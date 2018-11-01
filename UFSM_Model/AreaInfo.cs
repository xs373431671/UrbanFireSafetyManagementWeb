using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFSM_Model
{
    public class AreaInfo
    {
        

        private uint id;
        private uint areaNum;
        private byte attribute;
        private byte popQuality;
        private byte buildingFireResistanceRating;
        private byte popDensity;
        private byte buildingYears;
        private byte fireSafetyPropaganda;
        private byte powerLineLoad;
        private byte fireSafetyManagement;
        private byte agingOfPowerLines;
        private byte fireInspectionOfKeyBuildings;
        private byte timeFactor;
        private byte economicDensity;
        private byte highBuildingsNum;
        private byte undergroundCrowdedSpace;
        private byte densityOfKeyBuildings;
        private byte roadCongestion;
        private byte buildingDensity;
        private byte distributionOfInflammableStorage;
        private byte fireStationCapacityCoverage;
        private byte fireStationEquipment;
        private byte publicFireFacilities;
        private byte departmentalEmergencyResponse;
        private byte fireAndRescuePlan;
        private byte keyBuildingsFirePreventBuilt;
        private DateTime areaUploadTime;
        private uint areaAssessmentYear;
        private byte areaRiskGrade;

        public AreaInfo()
        {
            this.AreaNum = 0;
            this.Attribute = 0;
            this.PopQuality = 0;
            this.BuildingFireResistanceRating = 0;
            this.PopDensity = 0;
            this.BuildingYears = 0;
            this.FireSafetyPropaganda = 0;
            this.PowerLineLoad = 0;
            this.FireSafetyManagement = 0;
            this.AgingOfPowerLines = 0;
            this.FireInspectionOfKeyBuildings = 0;
            this.TimeFactor = 0;
            this.EconomicDensity = 0;
            this.HighBuildingsNum = 0;
            this.UndergroundCrowdedSpace = 0;
            this.DensityOfKeyBuildings = 0;
            this.RoadCongestion = 0;
            this.BuildingDensity = 0;
            this.DistributionOfInflammableStorage = 0;
            this.FireStationCapacityCoverage = 0;
            this.FireStationEquipment = 0;
            this.PublicFireFacilities = 0;
            this.DepartmentalEmergencyResponse = 0;
            this.FireAndRescuePlan = 0;
            this.KeyBuildingsFirePreventBuilt = 0;
            this.AreaUploadTime = DateTime.Now;
            this.AreaAssessmentYear = (uint)DateTime.Now.Year;
            this.AreaRiskGrade = 0;
            this.AreaSize = 0;
            this.AreaPop = 0;
        }


        public uint ID
        {
            get { return id; }
            set { if (value < 0 || value > 100) { value = 0; } else { id = value; } }
        }

        public uint AreaNum
        {
            get { return areaNum; }
            set { if (value < 0 || value > 1000) { value = 0; } else { areaNum = value; } }
        }
        public byte Attribute
        {
            get { return attribute; }
            set { if (value < 0 || value > 100) { value = 0; } else { attribute = value; } }
        }
        public byte PopQuality
        {
            get { return popQuality; }
            set { if (value < 0 || value > 100) { value = 0; } else { popQuality = value; } }
        }
        public byte BuildingFireResistanceRating
        {
            get { return buildingFireResistanceRating; }
            set { if (value < 0 || value > 100) { value = 0; } else { buildingFireResistanceRating = value; } }
        }
        public byte PopDensity
        {
            get { return popDensity; }
            set { if (value < 0 || value > 100) { value = 0; } else { popDensity = value; } }
        }
        public byte BuildingYears
        {
            get { return buildingYears; }
            set { if (value < 0 || value > 100) { value = 0; } else { buildingYears = value; } }
        }
        public byte FireSafetyPropaganda
        {
            get { return fireSafetyPropaganda; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireSafetyPropaganda = value; } }
        }
        public byte PowerLineLoad
        {
            get { return powerLineLoad; }
            set { if (value < 0 || value > 100) { value = 0; } else { powerLineLoad = value; } }
        }
        public byte FireSafetyManagement
        {
            get { return fireSafetyManagement; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireSafetyManagement = value; } }
        }
        public byte AgingOfPowerLines
        {
            get { return agingOfPowerLines; }
            set { if (value < 0 || value > 100) { value = 0; } else { agingOfPowerLines = value; } }
        }
        public byte FireInspectionOfKeyBuildings
        {
            get { return fireInspectionOfKeyBuildings; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireInspectionOfKeyBuildings = value; } }
        }
        public byte TimeFactor
        {
            get { return timeFactor; }
            set { if (value < 0 || value > 100) { value = 0; } else { timeFactor = value; } }
        }
        public byte EconomicDensity
        {
            get { return economicDensity; }
            set { if (value < 0 || value > 100) { value = 0; } else { economicDensity = value; } }
        }
        public byte HighBuildingsNum
        {
            get { return highBuildingsNum; }
            set { if (value < 0 || value > 100) { value = 0; } else { highBuildingsNum = value; } }
        }
        public byte UndergroundCrowdedSpace
        {
            get { return undergroundCrowdedSpace; }
            set { if (value < 0 || value > 100) { value = 0; } else { undergroundCrowdedSpace = value; } }
        }
        public byte DensityOfKeyBuildings
        {
            get { return densityOfKeyBuildings; }
            set { if (value < 0 || value > 100) { value = 0; } else { densityOfKeyBuildings = value; } }
        }
        public byte RoadCongestion
        {
            get { return roadCongestion; }
            set { if (value < 0 || value > 100) { value = 0; } else { roadCongestion = value; } }
        }
        public byte BuildingDensity
        {
            get { return buildingDensity; }
            set { if (value < 0 || value > 100) { value = 0; } else { buildingDensity = value; } }
        }
        public byte DistributionOfInflammableStorage
        {
            get { return distributionOfInflammableStorage; }
            set { if (value < 0 || value > 100) { value = 0; } else { distributionOfInflammableStorage = value; } }
        }
        public byte FireStationCapacityCoverage
        {
            get { return fireStationCapacityCoverage; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireStationCapacityCoverage = value; } }
        }
        public byte FireStationEquipment
        {
            get { return fireStationEquipment; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireStationEquipment = value; } }
        }
        public byte PublicFireFacilities
        {
            get { return publicFireFacilities; }
            set { if (value < 0 || value > 100) { value = 0; } else { publicFireFacilities = value; } }
        }
        public byte DepartmentalEmergencyResponse
        {
            get { return departmentalEmergencyResponse; }
            set { if (value < 0 || value > 100) { value = 0; } else { departmentalEmergencyResponse = value; } }
        }
        public byte FireAndRescuePlan
        {
            get { return fireAndRescuePlan; }
            set { if (value < 0 || value > 100) { value = 0; } else { fireAndRescuePlan = value; } }
        }
        public byte KeyBuildingsFirePreventBuilt
        {
            get { return keyBuildingsFirePreventBuilt; }
            set { if (value < 0 || value > 100) { value = 0; } else { keyBuildingsFirePreventBuilt = value; } }
        }
        public DateTime AreaUploadTime
        {
            get { return areaUploadTime; }
            set { areaUploadTime = value;  }
        }
        public uint AreaAssessmentYear
        {
            get { return areaAssessmentYear; }
            set { areaAssessmentYear = value;}
        }
        public byte AreaRiskGrade
        {
            get { return areaRiskGrade; }
            set { if (value < 0 || value > 5) { value = 0; } else { areaRiskGrade = value; } }
        }
        public uint AreaSize{ get; set; }
        public uint AreaPop{ get; set; }
    }
}
