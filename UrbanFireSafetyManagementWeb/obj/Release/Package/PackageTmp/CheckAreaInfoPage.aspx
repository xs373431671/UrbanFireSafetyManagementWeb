<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="CheckAreaInfoPage.aspx.cs" Inherits="UrbanFireSafetyManagementWeb.CheckAreaInfoPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
         table
        {
            width:600px;
            margin-left:250px;
            text-align:center;
            line-height:40px;
            border:2px solid white;
        }
        .th1
        {
            width:100px;
        }
        .th3
        {
            width:100px;
        }
        
        .text0-100
        {
            width:80px;
        }
     
    </style>
    <script type="text/javascript">


    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="text-align:center"><%= NormalUser.AreaNum%>号地区消防云端数据库信息表</h2>
    <h3 style="text-align:center">主要信息表（<%=returnMessage %>）</h3>
    <table border="1">
        <tr>
            <th class="th1">指标编号</th>
            <th class="th2">名指标称</th>
            <th class="th3">指标信息</th>
        </tr>
        <tr>
            <td class="th1">1</td>
            <td class="th2">地区编号</td>
            <td class="th3"><%=Area.AreaNum %></td>
        </tr>
        <tr>
            <td class="th1">2</td>
            <td class="th2">消防安全得分</td>
            <td class="th3"><%=Area.AreaRiskGrade %></td>
        </tr>
        <tr>
            <td class="th1">3</td>
            <td class="th2">信息上传时间</td>
            <td class="th3"><%=Area.AreaUploadTime %></td>
        </tr>
        <tr>
            <td class="th1">4</td>
            <td class="th2">评估年度</td>
            <td class="th3"><%=Area.AreaAssessmentYear %></td>
        </tr>
        <tr>
            <td class="th1">5</td>
            <td class="th2">地区面积（平方公里）</td>
            <td class="th3"><%=Area.AreaSize %></td>
        </tr>
        <tr>
            <td class="th1">6</td>
            <td class="th2">地区人口（万人）</td>
            <td class="th3"><%=Area.AreaPop %></td>
        </tr>
    </table>

    <h3 style="text-align:center">详细指标信息表</h3>
    <table border="1">
        <tr>
            <th class="th1">指标编号</th>
            <th class="th2">指标名称</th>
            <th class="th3">指标评分</th>
        </tr>
        <tr>
            <td class="th1">1</td>
            <td class="th2">地区编号</td>
            <td class="th3"><%=Area.AreaNum %></td>
        </tr>
        <tr>
            <td class="th1">2</td>
            <td class="th2">地区用地属性</td>
            <td class="th3"><%=Area.Attribute %></td>
        </tr>
        <tr>
            <td class="th1">3</td>
            <td class="th2">地区人口素质</td>
            <td class="th3"><%=Area.PopQuality %></td>
        </tr>
        <tr>
            <td class="th1">4</td>
            <td class="th2">地区建筑防火等级</td>
            <td class="th3"><%=Area.BuildingFireResistanceRating %></td>
        </tr>
        <tr>
            <td class="th1">5</td>
            <td class="th2">地区人口密度</td>
            <td class="th3"><%=Area.PopDensity %></td>
        </tr>
        <tr>
            <td class="th1">6</td>
            <td class="th2">地区建筑建设年限</td>
            <td class="th3"><%=Area.BuildingYears %></td>
        </tr>
        <tr>
            <td class="th1">7</td>
            <td class="th2">消防安全宣传</td>
            <td class="th3"><%=Area.FireSafetyPropaganda %></td>
        </tr>
        <tr>
            <td class="th1">8</td>
            <td class="th2">地区用电线路负荷</td>
            <td class="th3"><%=Area.PowerLineLoad %></td>
        </tr>
        <tr>
            <td class="th1">9</td>
            <td class="th2">地区消防安全巡检</td>
            <td class="th3"><%=Area.FireSafetyManagement %></td>
        </tr>
        <tr>
            <td class="th1">10</td>
            <td class="th2">地区用电线路老化情况</td>
            <td class="th3"><%=Area.AgingOfPowerLines %></td>
        </tr>
       
        <tr>
            <td class="th1">11</td>
            <td class="th2">地区经济密度</td>
            <td class="th3"><%=Area.EconomicDensity %></td>
        </tr>
        <tr>
            <td class="th1">12</td>
            <td class="th2">地区高层建筑情况</td>
            <td class="th3"><%=Area.HighBuildingsNum %></td>
        </tr>
        <tr>
            <td class="th1">13</td>
            <td class="th2">地区地下人流密集空间情况</td>
            <td class="th3"><%=Area.UndergroundCrowdedSpace %></td>
        </tr>
        <tr>
            <td class="th1">14</td>
            <td class="th2">地区重点防火单位密度</td>
            <td class="th3"><%=Area.DensityOfKeyBuildings %></td>
        </tr>
        <tr>
            <td class="th1">15</td>
            <td class="th2">地区道路繁忙程度</td>
            <td class="th3"><%=Area.RoadCongestion %></td>
        </tr>
        <tr>
            <td class="th1">16</td>
            <td class="th2">地区建筑密度</td>
            <td class="th3"><%=Area.BuildingDensity %></td>
        </tr>
        <tr>
            <td class="th1">17</td>
            <td class="th2">易燃易爆仓储分布情况</td>
            <td class="th3"><%=Area.DistributionOfInflammableStorage %></td>
        </tr>
        <tr>
            <td class="th1">18</td>
            <td class="th2">消防站能力覆盖情况</td>
            <td class="th3"><%=Area.FireStationCapacityCoverage %></td>
        </tr>
        <tr>
            <td class="th1">19</td>
            <td class="th2">消防站装备配备情况</td>
            <td class="th3"><%=Area.FireStationEquipment %></td>
        </tr>
        <tr>
            <td class="th1">20</td>
            <td class="th2">公共消防设施建设情况</td>
            <td class="th3"><%=Area.PublicFireFacilities %></td>
        </tr>
        <tr>
            <td class="th1">21</td>
            <td class="th2">灭火救援预案情况</td>
            <td class="th3"><%=Area.FireAndRescuePlan %></td>
        </tr>
        <tr>
            <td class="th1">22</td>
            <td class="th2">消防、医疗与交通部门应急联动情况</td>
            <td class="th3"><%=Area.DepartmentalEmergencyResponse %></td>
        </tr>
        <tr>
            <td class="th1">23</td>
            <td class="th2">重点消防单位消防自建情况</td>
            <td class="th3"><%=Area.KeyBuildingsFirePreventBuilt %></td>
        </tr>
         <tr>
            <td class="th1">24</td>
            <td class="th2">地区重点防火单位监督情况</td>
            <td class="th3"><%=Area.FireInspectionOfKeyBuildings %></td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
   
</asp:Content>

