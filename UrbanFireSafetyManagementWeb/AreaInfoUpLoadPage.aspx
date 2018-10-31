<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="AreaInfoUpLoadPage.aspx.cs" Inherits="UrbanFireSafetyManagementWeb.AreaInfoUpLoadPage" %>
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
            width:80px;
        }
        .th3
        {
            width:100px;
        }
        
        .text0-100
        {
            width:80px;
        }
        #submit
        {
            height:30px;
        }

        #login_click{ margin-left:680px; height:50px;}
        #btlogin 
        {
        	background:#2f435e;
        	color:#f2f2f2;   	
        	padding: 10px 30px 10px 30px;
        	font-size:16px;
        	font-family: 微软雅黑,宋体,Arial,Helvetica,Verdana,sans-serif;
        	font-weight:bold;
        	border-radius:3px;
        	
        	-webkit-transition:all linear 0.30s;
        	-moz-transition:all linear 0.30s;
        	transition:all linear 0.30s;
	    }
        #btlogin:hover { background:#385f9e; }


    </style>
    <script type="text/javascript">


    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="text-align:center">欢迎使用火灾风险指标评分录入系统</h2>
    <span style="margin-left:250px;">您负责的区域为：<%= NormalUser.AreaNum%></span>
    <table border="1">
        <tr>
            <th class="th1">指标编号</th>
            <th class="th2">名指标称</th>
            <th class="th3">评指标分</th>
        </tr>
        <tr>
            <td class="th1">1</td>
            <td class="th2">地区用地属性</td>
            <td class="th3"><input type="text" class="text0-100" name="attribute" value="0"  /></td>
        </tr>
        <tr>
            <td class="th1">2</td>
            <td class="th2">地区人口素质</td>
            <td class="th3"><input type="text" class="text0-100" name="popQuality" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">3</td>
            <td class="th2">地区建筑防火等级</td>
            <td class="th3"><input type="text" class="text0-100" name="buildingFireResistanceRating" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">4</td>
            <td class="th2">地区人口密度</td>
            <td class="th3"><input type="text" class="text0-100" name="popDensity" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">5</td>
            <td class="th2">地区建筑建设年限</td>
            <td class="th3"><input type="text" class="text0-100" name="buildingYears" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">6</td>
            <td class="th2">消防安全宣传</td>
            <td class="th3"><input type="text" class="text0-100" name="fireSafetyPropaganda" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">7</td>
            <td class="th2">地区用电线路负荷</td>
            <td class="th3"><input type="text" class="text0-100" name="powerLineLoad" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">8</td>
            <td class="th2">地区消防安全巡检</td>
            <td class="th3"><input type="text" class="text0-100" name="fireSafetyManagement" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">9</td>
            <td class="th2">地区用电线路老化情况</td>
            <td class="th3"><input type="text" class="text0-100" name="agingOfPowerLines" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">10</td>
            <td class="th2">地区重点防火单位监督情况</td>
            <td class="th3"><input type="text" class="text0-100" name="fireInspectionOfKeyBuildings" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">11</td>
            <td class="th2">地区经济密度</td>
            <td class="th3"><input type="text" class="text0-100" name="economicDensity" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">12</td>
            <td class="th2">地区高层建筑情况</td>
            <td class="th3"><input type="text" class="text0-100" name="highBuildingsNum" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">13</td>
            <td class="th2">地区地下人流密集空间情况</td>
            <td class="th3"><input type="text" class="text0-100" name="undergroundCrowdedSpace" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">14</td>
            <td class="th2">地区重点防火单位密度</td>
            <td class="th3"><input type="text" class="text0-100" name="densityOfKeyBuildings" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">15</td>
            <td class="th2">地区道路繁忙程度</td>
            <td class="th3"><input type="text" class="text0-100" name="roadCongestion" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">16</td>
            <td class="th2">地区建筑密度</td>
            <td class="th3"><input type="text" class="text0-100" name="buildingDensity" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">17</td>
            <td class="th2">易燃易爆仓储分布情况</td>
            <td class="th3"><input type="text" class="text0-100" name="distributionOfInflammableStorage" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">18</td>
            <td class="th2">消防站能力覆盖情况</td>
            <td class="th3"><input type="text" class="text0-100" name="fireStationCapacityCoverage" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">19</td>
            <td class="th2">消防站装备配备情况</td>
            <td class="th3"><input type="text" class="text0-100" name="fireStationEquipment" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">20</td>
            <td class="th2">公共消防设施建设情况</td>
            <td class="th3"><input type="text" class="text0-100" name="publicFireFacilities" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">21</td>
            <td class="th2">灭火救援预案情况</td>
            <td class="th3"><input type="text" class="text0-100" name="fireAndRescuePlan" value="0" /></td>
        </tr>
        <tr>
            <td class="th1">22</td>
            <td class="th2">消防、医疗与交通部门应急联动情况</td>
            <td class="th3"><input type="text" class="text0-100" name="departmentalEmergencyResponse"  value="0"/></td>
        </tr>
        <tr>
            <td class="th1">23</td>
            <td class="th2">重点消防单位消防自建情况</td>
            <td class="th3"><input type="text" class="text0-100" name="keyBuildingsFirePreventBuilt" value="0" /></td>
        </tr>
    </table>
    <br />
    <br />

    <div id="login_click">
        <input type="submit" id="btlogin" value="提交到数据库" />
    </div>
    <br />
    <br />
</asp:Content>
