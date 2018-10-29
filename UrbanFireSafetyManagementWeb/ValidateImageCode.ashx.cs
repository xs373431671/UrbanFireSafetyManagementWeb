using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UFSM_Tool;
using System.IO;

namespace UrbanFireSafetyManagementWeb
{
    /// <summary>
    /// ValidateImageCode 的摘要说明
    /// </summary>
    public class ValidateImageCode : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            ValidateCode validateCode = new ValidateCode();
            string code = validateCode.CreateValidateCode(4);

            //将验证码信息存在 Session 中，供其他地方调用             
            context.Session["validateCode"] = code;

            //下方法内部封装了返回值         
            validateCode.CreateValidateGraphic(code, context);

            
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