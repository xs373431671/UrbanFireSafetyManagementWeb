﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace UrbanFireSafetyManagementWeb
{
    /// <summary>
    /// Index 的摘要说明
    /// </summary>
    public class Index : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if(context.Request.QueryString["exit"]=="exit"||context.Request.QueryString!=null)
            {
                //context.Session["userInfo"] = null;
                context.Response.Cookies["userInfo"]["AreaNum"] = null;
                context.Response.Redirect("Index.html");
                return;
            }

            ////显示登录页面前先判定是否有Session，如果没有，则跳转到Index.html
            //if (context.Session["userInfo"] == null)
            //{
            //    context.Response.Redirect("Index.html");
            //}
            
            if (context.Request.Cookies["userInfo"]["AreaNum"]!= null)
            {
                //如果有，则跳转到HomePage.aspx
                context.Response.Redirect("HomePage.aspx");              
            }
            else
            {
                context.Response.Redirect("Index.html");
            }          
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}