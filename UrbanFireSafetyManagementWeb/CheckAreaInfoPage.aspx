<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="CheckAreaInfoPage.aspx.cs" Inherits="UrbanFireSafetyManagementWeb.CheckAreaInfoPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        table
        {
            width:500px;
            margin-left:300px;
            text-align:center;
        }
        .th1
        {
            width:80px;
        }
        .th3,text
        {
            width:100px;
        }

        input
        {
            margin-left:500px;
        }

    </style>
    <script type="text/javascript">


    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>您负责的区域为：<%=NormalUser.AreaNum%></h2>
    <table>
        <tr>
            <th class="th1">指标编号</th>
            <th class="th2">名指标称</th>
            <th class="th3">评指标分</th>
        </tr>
        <tr>
            <td class="th1">1</td>
            <td class="th2">地区用地属性</td>
            <td class="th3"><input type="text" class="text0-100" name="attribute" value="<%=Area.Attribute %>"  /></td>
        </tr>
        <tr>
            <td class="th1">2</td>
            <td class="th2">地区人口素质</td>
            <td class="th3"><input type="text" class="text0-100" name="popQuality" value="<%=Area.PopQuality %>" /></td>
        </tr>
        <tr>
            <td class="th1">3</td>
            <td class="th2">地区建筑防火等级</td>
            <td class="th3"><input type="text" class="text0-100" name="buildingFireResistanceRating" value="<%=Area.BuildingFireResistanceRating %>" /></td>
        </tr>
        <tr>
            <td class="th1">4</td>
            <td class="th2">地区人口密度</td>
            <td class="th3"><input type="text" class="text0-100" name="popDensity" value="<%=Area.PopDensity %>" /></td>
        </tr>
        <tr>
            <td class="th1">5</td>
            <td class="th2">地区建筑建设年限</td>
            <td class="th3"><input type="text" class="text0-100" name="buildingYears" value="<%=Area.BuildingYears %>" /></td>
        </tr>
        <tr>
            <td class="th1">6</td>
            <td class="th2">消防安全宣传</td>
            <td class="th3"><input type="text" class="text0-100" name="fireSafetyPropaganda" value="<%=Area.FireSafetyPropaganda %>" /></td>
        </tr>
        <tr>
            <td class="th1">7</td>
            <td class="th2">地区用电线路负荷</td>
            <td class="th3"><input type="text" class="text0-100" name="powerLineLoad" value="<%=Area.PowerLineLoad %>" /></td>
        </tr>
        <tr>
            <td class="th1">8</td>
            <td class="th2">地区消防安全巡检</td>
            <td class="th3"><input type="text" class="text0-100" name="fireSafetyManagement" value="<%=Area.FireSafetyManagement %>" /></td>
        </tr>
        <tr>
            <td class="th1">9</td>
            <td class="th2">地区用电线路老化情况</td>
            <td class="th3"><input type="text" class="text0-100" name="agingOfPowerLines" value="<%=Area.AgingOfPowerLines %>" /></td>
        </tr>
        <tr>
            <td class="th1">10</td>
            <td class="th2">地区重点防火单位监督情况</td>
            <td class="th3"><input type="text" class="text0-100" name="fireInspectionOfKeyBuildings" value="<%=Area.FireInspectionOfKeyBuildings %>" /></td>
        </tr>
        <tr>
            <td class="th1">11</td>
            <td class="th2">地区经济密度</td>
            <td class="th3"><input type="text" class="text0-100" name="economicDensity" value="<%=Area.EconomicDensity %>" /></td>
        </tr>
        <tr>
            <td class="th1">12</td>
            <td class="th2">地区高层建筑情况</td>
            <td class="th3"><input type="text" class="text0-100" name="highBuildingsNum" value="<%=Area.HighBuildingsNum %>" /></td>
        </tr>
        <tr>
            <td class="th1">13</td>
            <td class="th2">地区地下人流密集空间情况</td>
            <td class="th3"><input type="text" class="text0-100" name="undergroundCrowdedSpace" value="<%=Area.UndergroundCrowdedSpace %>" /></td>
        </tr>
        <tr>
            <td class="th1">14</td>
            <td class="th2">地区重点防火单位密度</td>
            <td class="th3"><input type="text" class="text0-100" name="densityOfKeyBuildings" value="<%=Area.DensityOfKeyBuildings %>" /></td>
        </tr>
        <tr>
            <td class="th1">15</td>
            <td class="th2">地区道路繁忙程度</td>
            <td class="th3"><input type="text" class="text0-100" name="roadCongestion" value="<%=Area.RoadCongestion %>" /></td>
        </tr>
        <tr>
            <td class="th1">16</td>
            <td class="th2">地区建筑密度</td>
            <td class="th3"><input type="text" class="text0-100" name="buildingDensity" value="<%=Area.BuildingDensity %>" /></td>
        </tr>
        <tr>
            <td class="th1">17</td>
            <td class="th2">易燃易爆仓储分布情况</td>
            <td class="th3"><input type="text" class="text0-100" name="distributionOfInflammableStorage" value="<%=Area.DistributionOfInflammableStorage %>" /></td>
        </tr>
        <tr>
            <td class="th1">18</td>
            <td class="th2">消防站能力覆盖情况</td>
            <td class="th3"><input type="text" class="text0-100" name="fireStationCapacityCoverage" value="<%=Area.FireStationCapacityCoverage %>" /></td>
        </tr>
        <tr>
            <td class="th1">19</td>
            <td class="th2">消防站装备配备情况</td>
            <td class="th3"><input type="text" class="text0-100" name="fireStationEquipment" value="<%=Area.FireStationEquipment %>" /></td>
        </tr>
        <tr>
            <td class="th1">20</td>
            <td class="th2">公共消防设施建设情况</td>
            <td class="th3"><input type="text" class="text0-100" name="publicFireFacilities" value="<%=Area.PublicFireFacilities %>" /></td>
        </tr>
        <tr>
            <td class="th1">21</td>
            <td class="th2">灭火救援预案情况</td>
            <td class="th3"><input type="text" class="text0-100" name="fireAndRescuePlan" value="<%=Area.FireAndRescuePlan %>" /></td>
        </tr>
        <tr>
            <td class="th1">22</td>
            <td class="th2">消防、医疗与交通部门应急联动情况</td>
            <td class="th3"><input type="text" class="text0-100" name="departmentalEmergencyResponse"  value="<%=Area.DepartmentalEmergencyResponse %>"/></td>
        </tr>
        <tr>
            <td class="th1">23</td>
            <td class="th2">重点消防单位消防自建情况</td>
            <td class="th3"><input type="text" class="text0-100" name="keyBuildingsFirePreventBuilt" value="<%=Area.KeyBuildingsFirePreventBuilt %>" /></td>
        </tr>
        <tr>
            <td colspan="3"><%="数据库信息："+ReturnMessage %></td>
        </tr>
    </table>
   
</asp:Content>

