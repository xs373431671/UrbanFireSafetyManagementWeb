﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="ProjectInfoPage.aspx.cs" Inherits="UrbanFireSafetyManagementWeb.ProjectInfoPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        h1
        {
            text-align:center;
        }
        p
        {
            text-align:justify;text-justify:inter-word;text-justify:inter-ideograph;
            line-height:40px;
            text-indent:2em;
            font-family:"微软雅黑",sans-serif,SimHei;
            font-size:17px;
            margin-top:0px;
            margin-bottom:0px;
        }
        .textSpan
        {
            line-height:40px;
            text-indent:2em;
            font-family:"微软雅黑",SimHei，sans-serif;
            font-size:17px;
            text-indent:2em;
            margin-left:2em;
        }
        
        .ProjImage
        {
            width:800px;
            margin-left:100px;
        }
        #textDiv
        {
            padding:20px 50px 20px 50px;
        }
    </style>
    <script type="text/javascript">

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="sonMainDiv">   
    <div id="textDiv">   
        <h1>项目简介</h1>
        <h2>一.立项依据</h2>
        <h3>1.项目意义：</h3>
        <p>
            智慧城市就是运用信息和通信技术手段感测、分析、整合城市运行核心系统的各项关键信息，从而对包括民生、环保、公共安全、城市服务、工商业活动在内的各种需求做出智能响应，通过新一代信息技术以及全媒体融    合通信终端等工具的应用，实现城市智慧式管理和运行，进而为城市中的居民创造更美好的生活，促进城市的和谐、可持续成长。
        </p>
        <p>
            随着各地区城市的不断发展，火灾作为城市中最具常发性与破坏性的灾害之一日趋频发。城市的发展使得城市区域在人员的大量聚集、区域财富的高度集中的同时，也面临着区域中致灾因素普遍存在，用火、用电、用气    日趋频繁的问题，存在发生群死群伤或巨额财产损失等恶性事故的可能性。频发的城市火灾，在造成严重财产损失和人员伤亡的同时，很大程度降低了城市居民的安全感，严重影响了经济建设和社会政治稳定。国家主 席习近平提出：“要坚决遏制重特大事故频发势头，对易发重特大事故的领域采取风险分级管控、隐患排查治理双重预防性工作机制，推动安全关口前移，最大限度减少人员伤亡和财产损失。”中共中央办公厅、国务院 办公厅于2018年1月印发了《关于推进城市安全发展的意见》，对加强城市公共安全提出了进一步的要求，意见提出要加强基础设施安全管理、健全城市安全防控机制、提升城市安全监管效能、强化城市安全保障能力    等要求，达到强化城市运行安全保障、有效防范事故发生、推进城市安全发展的目的。
        </p>
        <p>
            此项目以太原市火灾消防安全管理为研究载体，借助地理信息系统、云服务、大数据、物联网等先进技术，对城市火灾消防安全管理体系进行深入研究，并对智慧城市火灾安全管理系统进行开发与应用研究，着力于解放    消防资源、降低消防成本、创新消防模式、优化消防流程、提高消防工作效率、增强消防工作成效，以达到推动消防工作火灾防控自动化、智能化、系统化、精细化的实际需求。在消防领域开展智慧城市火灾安全管理 系统开发与应用研究，是本着贯彻《中华人民共和国消防法》、《关于推进城市安全发展意见》与国家公安部61号令中所提出的“向科技要警力” ，逐步实现“科技消防”和“智能消防”目标精神的重要一步。
        </p>
            <p>我国目前的城市消防安全管理水平还较为薄弱，传统消防单位与高新企业之间对先进科学信息技术的应用存在着较大的“贫富差距”，消防管理水平的薄弱限制了消防有效覆盖区域，使得城市消防发展远远跟不上城市  的发展速度。目前消防管理工作存在着以下几点问题：</p>
            <span class="textSpan">①消防部门在机构设置以及人员配置方面存在一定的不合理问题，导致消防安全的监督以及检查工作不能很好的开展；</span><br />
            <span class="textSpan">②消防基础设施不足，个别企业为了可以降低工程的建设成本，使得很多的消防基础上设施严重缺失；</span><br />
            <span class="textSpan">③消防设施管理水平低下，存在着大量失效的消防设施，消防设施无法得到科学的管理；</span><br />
            <span class="textSpan">④消防知识的宣贯以及培训工作基本上都是流于表面，重形式不重效果，当发生火灾以后无法有效的进行自救。</span>
        
        <h3>2.项目独创性:</h3>
        <p>
            本项目提处智慧城市火灾安全管理系统开发与应用研究，创新传统火灾消防安全管理方法，并在其基础上，充分发挥大数据、物联网、云服务与地理信息系统等现代信息技术的作用。结合近几年的火灾原因调查分析来 看，火灾发生的原因始终围绕着人、机（物）、环境、管理4种因素，将风险分级管控与隐患排查治理双重预防机制引入城市消防安全管理工作中：从系统论的角度出发，对城市进行网格化划分，围绕这4个因素进行城 市消防安全风险辨识，对各网格进行火灾风险评估，划分风险等级，进行分级管控，并以网格为单位进行隐患排查治理研究，构建城市火灾风险分级管控与隐患排查双重预防机制；同时，对城市消防基础设施管理与消  防知识宣传培训方法进行研究，制定科学的消防设施管理办法与消防知识宣传手段。对降低城市火灾风险，实现精准消防，有重要意义。随后，借助地理信息系统、云服务、大数据、物联网等先进技术，进行城市火灾   安全管理系统开发。城市火灾安全管理系统借助云服务，建立城市云端消防数据库（包含城市各区域的火灾风险信息、消防设施信息等）；借助物联网基础，研究传感器在消防数据收集上的应用，实现数据收集的准确    性与实时性；借助大数据技术，对消防数据进行挖掘分析，进行城市区域火灾风险评估与火灾预测；而地理信息系统作为一种由计算机程序和地理数据组织而成的地理空间分析模型，在对各类空间属性和非空间属性数 据的管理、操作、空间数据分析和显示方面具有很大的优势，借助地理信息系统，通过云端消防数据库信息，进行空间数据分析，实现城市消防数据分析可视化，如城市风险可视化、城市消防设施信息可视化等，使消  防部门能够获得更丰富、更直观的数据，实现“科技消防”和“智能消防”。
        </p>

        <h2>二.研究目标、研究内容和拟解决的关键问题</h2>
        <h3>1.研究目标</h3>
        <p>创新传统火灾消防安全管理方法、实现以评促建、分级管控、排查补充的智慧消防管理模式，搭配现代信息技术，开发配套城市火灾安全管理系统，实现“科技消防”和“智能消防”的目的，使得城市火灾预防工作科学化、   全面化、规范化、智能化。</p>
        <h3>2.研究内容</h3>
        <span class="textSpan">（1）现有的城市火灾消防安全管理方法与智慧消防模式的研究与分析；</span><br />
        <span class="textSpan">（2）城市区域火灾风险评估技术与双重预防机制的研究；</span><br />
        <span class="textSpan">（3）城市消防设施管理模式与消防知识宣传手段研究；</span><br />
        <span class="textSpan">（4）大数据模型建立，多属性决策方法与数据挖掘技术的研究；</span><br />
        <span class="textSpan">（5）云端服务器搭建与SQL Server数据库的搭建研究；</span><br />
        <span class="textSpan">（6）物联网传感器技术与信号传输技术的研究；</span><br />
        <span class="textSpan">（7）网络通信技术与.NET Framwork环境下C/S模式编程技术研究；</span><br />
        <span class="textSpan">（8）地理信息系统与ArcGIS Engine二次开发技术研究</span><br />
        <h3>3.拟解决的关键问题</h3>
        <span class="textSpan">（1）建立先进科学的城市火灾消防安全管理方法与手段；</span><br />
        <span class="textSpan">（2）实现由传统消防到智慧消防的转变</span><br />
        <span class="textSpan">（3）建立城市云端消防信息数据库，实现所有信息共享与调用</span><br />
        <span class="textSpan">（4）运用大数据技术，实现数据的挖掘与分析，使数据库中的信息充分利用</span><br />
        <span class="textSpan">（5）基于（GIS）实现城市火灾安全管理系统的信息可视化</span><br />

        <h2>三.项目的研究方法、技术路线、实验方案（含创新性）及其可行性分析</h2>
        <h3>1.研究方法</h3>
        <p>
            本项目主要采用理论分析、建立模型、数据库的搭建、程序开发，不同模型条件下计算效果对比分析、计算结论参照消防工作实际的研究方法。为了明确新型城市火灾消防管理方法的实际工作效果，本项目首先对其进行    理论分析，再分别进行区域性试验，将城市火灾消防安全管理体系与智慧城市火灾安全管理系统的运用与传统消防工作效果对比，得出研究结论。
        </p>
        <h3>2.技术路线</h3>
        <span class="textSpan">本项目的技术路线见下图：</span><br /><br />
        <img class="ProjImage" src="image/JiShuLuXian.png" />
        <h3>3.项目方案</h3>
        <p>为了实现本项目的研究目标，项目方案如下：（1）首先结合双重预防机制与网格化管理理念，对城市火灾消防安全管理体系进行研究，研究内容包括城市区域火灾风险分级管控、隐患排查治理、城市消防设施数字化管 理、消防知识数字化宣传；（2）基于城市火灾消防安全管理体系研究，以.NET Framwork为开发平台，开发智慧城市火灾安全管理系统客户端，实现火灾风险指标信息的上传录入、城市消防设施信息的上传录入与建立消防 知识宣传模块；（3）基于SQL Server数据库技术，建立云端消防空间信息数据库，实现客户端或传感器信息的上传录入与查询调取；（4）基于城市火灾消防安全管理体系研究，开发智慧城市火灾安全管理系统服务端，进  行大数据处理编程，对数据库中数据进行数据挖掘，建立数据处理层，同时对ArcGIS Engine进行二次开发，实现数据处理的空间可视化，最终实现实现方法与系统的配套使用。（5）对项目成果进行区域应用，并与传统消  防安全管理工作进行分析和对比，并得出相应的结论。</p>
        <span class="textSpan">系统框架如下图2所示:</span><br /><br />
        <img class="ProjImage" style="width:500px;margin-left:250px;" src="image/TiXi.png" />
    </div> 
        </div>  
</asp:Content>
