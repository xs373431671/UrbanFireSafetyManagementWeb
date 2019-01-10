<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="UrbanFireSafetyManagementWeb.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       h1
       {text-align:center;}
       #sonMainDiv
        {
            width:1100px;
            /*border:solid;*/
            margin-left:50px;
        }
       .aDiv
       {
           position:absolute;
           width:250px;
           height:55px;
           padding-top:17px;
           padding-left:25px;
           
       }
       #renwufabuDiv
       {
           margin-left:170px;
           margin-top:320px;
           border:6px double black;
           padding-left:30px;
           width:200px;
       }
       #quyuhuafenDiv
       {
           margin-left:750px;
           margin-top:850px;
           border:6px double white;
       }
       #zhibiaolianghuaDiv
       {
           margin-left:145px;
           margin-top:1350px;
           border:6px double black;
       }
       .aa{
           text-decoration:none;
           font-size:28px;
           color:black;
           cursor:pointer;
       }
       #a1{

       }
       #a2{
           color:white;
       }
       #a3{

       }
    </style>
    <script type="text/javascript">
        $(function () {
            document.getElementById('renwufabuDiv').onmouseenter = function () {
                this.style.border = '6px double blue'
            };
            document.getElementById('a1').onmouseenter = function () {
                document.getElementById('renwufabuDiv').style.border = '6px double blue'
            };
            document.getElementById('renwufabuDiv').onmouseout = function () {
                this.style.border = '6px double black'
            };

            document.getElementById('quyuhuafenDiv').onmouseenter = function () {
                this.style.border = '6px double blue'
            };
            document.getElementById('a2').onmouseenter = function () {
                document.getElementById('quyuhuafenDiv').style.border = '6px double blue'
            };
            document.getElementById('quyuhuafenDiv').onmouseout = function () {
                this.style.border = '6px double white'
            };

            document.getElementById('zhibiaolianghuaDiv').onmouseenter = function () {
                this.style.border = '6px double blue'
            };
            document.getElementById('a3').onmouseenter = function () {
                document.getElementById('zhibiaolianghuaDiv').style.border = '6px double blue'
            };
            document.getElementById('zhibiaolianghuaDiv').onmouseout = function () {
                this.style.border = '6px double black'
            };
        });
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="sonMainDiv" style="width:1200px;margin-left:0px;margin-top:0px;">
        <div class="aDiv" id="renwufabuDiv">
            <a class="aa" id="a1" href="http:\\www.baidu.com">查看发布信息</a>
        </div>
        <div class="aDiv" id="quyuhuafenDiv">
            <a class="aa" id="a2" href="http:\\www.baidu.com">查看详细区域划分</a>
        </div>   
        <div class="aDiv" id="zhibiaolianghuaDiv">
            <a class="aa" id="a3" href="http:\\www.baidu.com">查看指标量化方法</a>
        </div>      
        <img src="image/任务发布.png" />
        <img src="image/区域划分1.png" />
        <img src="image/指标量化.png" />
        <img src="image/联系我们1.png" />
    </div>
</asp:Content>
