﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Areas\CMS\Views\Shared\_UserTime.cshtml"
    using NewLife.CMX;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/CMS/Views/Shared/_UserTime.cshtml")]
    public partial class _Areas_CMS_Views_Shared__UserTime_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_CMS_Views_Shared__UserTime_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\CMS\Views\Shared\_UserTime.cshtml"
  
    var user = Model as IUserInfo;
    var time = Model as ITimeInfo;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">创建</label>\r\n    <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"text-primary\"");

WriteLiteral(">");

            
            #line 9 "..\..\Areas\CMS\Views\Shared\_UserTime.cshtml"
                              Write(user.CreateUserName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <span");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 10 "..\..\Areas\CMS\Views\Shared\_UserTime.cshtml"
                              Write(time.CreateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </div>\r\n    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">更新</label>\r\n    <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"text-primary\"");

WriteLiteral(">");

            
            #line 14 "..\..\Areas\CMS\Views\Shared\_UserTime.cshtml"
                              Write(user.UpdateUserName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <span");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 15 "..\..\Areas\CMS\Views\Shared\_UserTime.cshtml"
                              Write(time.UpdateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
