<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="PersonInfoPage.aspx.cs" Inherits="UrbanFireSafetyManagementWeb.PersonInfoPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        table
        {
            text-align:center;
            line-height:50px;
            width:500px;
            margin-left:300px;
        }
        .td1
        {
            width:150px;
        }
         #btlogin1
        {
        	margin:50px 600px;
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
        #btlogin1:hover { background:#385f9e; }
        #btlogin2,#btlogin3 
        {
            background:#2f435e;
        	color:#f2f2f2;   	
        	padding: 10px 30px 10px 30px;
        	font-size:16px;
        	font-family: 微软雅黑,宋体,Arial,Helvetica,Verdana,sans-serif;
        	font-weight:bold;
        	border-radius:3px;
            width:150px;
        	
        	-webkit-transition:all linear 0.30s;
        	-moz-transition:all linear 0.30s;
        	transition:all linear 0.30s;
	    }
        #btlogin2:hover,#btlogin3:hover { background:#385f9e; }
        #bgDiv               
        {               
            position: absolute;      
            top:-100px;
            left:-500px;       
            background-color: black;                 
            opacity: 0.8;                                              
            display: none;   
            width: 2500px;
            height:1200px;
        } 
        #fgDiv            
        {                
            top:250px;
            left:350px;
            position: absolute;                
            width: 500px;                 
            height: 600px;                 
            border: 1px solid red;                 
            background-color: #2f435e;                 
            display: none;           
        }
        .sineTable
        {
            width:400px;
            margin-left:50px;
            margin-top:20px;
        }   
    </style>
    <script type="text/javascript">
        $(function ()
        {
            $('#btlogin1').click(function () {
                $('#bgDiv').css('display', 'block');
                $('#fgDiv').css('display', 'block');                             
                $('#fgDiv :text').val('');             
            });
            $('#btlogin3').click(function () {
                $('#bgDiv').css('display', 'none');
                $('#fgDiv').css('display', 'none');
                $('#fgDiv :text').val('');
            });
            

            $('#btlogin2').click(function () {
                var password = document.getElementById("password");
                var telephone = document.getElementById("telephone");

                if (password.value == null || telephone.value == null) {
                    alert("必填项不能为空");
                    return false;
                }
                if (password.value == 0 ||  telephone.value == 0) {
                    alert("必填项不能为空");
                    return false;
                }               
            });

        });
        
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="sonMainDiv">   
    <br />
    <br />
    <h2 style="text-align:center">用户个人信息</h2>
    <br />
    <br />
    <table border="1" id="table1">
        <tr>
            <td class="td1">I&nbsp;&nbsp;&nbsp;&nbsp;D</td>
            <td class="td2"><%=WorkUser.ID %></td>
        </tr>
        <tr>
            <td class="td1">用户账号</td>
            <td class="td2"><%=WorkUser.Account %></td>
        </tr>
         <tr>
            <td class="td1">用户密码</td>
            <td class="td2"><%=WorkUser.Password %></td>
        </tr>
         <tr>
            <td class="td1">负责地区编号</td>
            <td class="td2"><%=WorkUser.AreaNum %></td>
        </tr>
        <tr>
            <td class="td1">本人姓名</td>
            <td class="td2"><%=WorkUser.Name %></td>
        </tr>
        <tr>
            <td class="td1">用户权限</td>
            <td class="td2"><%=WorkUser.Authority %></td>
        </tr>
        <tr>
            <td class="td1">联系电话</td>
            <td class="td2"><%=WorkUser.Telephone %></td>
        </tr>
        <tr>
            <td class="td1">电子邮箱</td>
            <td class="td2"><%=WorkUser.Email %></td>
        </tr>
    </table>
    <div id="login_click1">
        <input type="button" id="btlogin1" value="编辑用户信息" />
    </div>
    <div id="bgDiv"></div>                    
    <div id="fgDiv">
        <br />
        <h2 style="text-align:center">更改用户信息</h2>
        <table class="sineTable" border="1" >
            <tr>
                <td>帐&nbsp;&nbsp;&nbsp;&nbsp;号:</td>
                <td><%=WorkUser.Account %></td>
            </tr>
            <tr>
                <td>密&nbsp;&nbsp;&nbsp;&nbsp;码:</td>
                <td><input type="password" id="password" name="password" /><small>*</small></td>
            </tr>
            <tr>
                <td>本人姓名:</td>
                <td><input type="text" id="name" name="name"/></td>
            </tr>
            <tr>
                <td>负责地区编号:</td>
                <td><%=WorkUser.AreaNum %></td>
            </tr>
            <tr>
                <td>本人单位信息:</td>
                <td><input type="text" name="department" /></td>
            </tr>
            <tr>
                <td>手&nbsp;&nbsp;&nbsp;&nbsp;机:</td>
                <td><input type="text" id="telephone" name="telephone" /><small>*</small></td>
            </tr>
            <tr>
                <td>电子邮箱:</td>
                <td><input type="text" name="email" /></td>
            </tr>
            <tr>
                <td style="height:50px;" >
                    <div id="login_click2">
                        <input type="submit" id="btlogin2" value="确定更改" />
                    </div>
                </td>
                <td style="height:50px;">
                    <div id="login_click3">
                        <input type="button" id="btlogin3" value="取消" />
                    </div>
                </td>
            </tr>           
        </table>       
    </div>   
</div>

</asp:Content>
