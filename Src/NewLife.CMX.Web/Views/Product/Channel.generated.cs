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
    using NewLife.CMX;
    using NewLife.CMX.Web;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Product/Channel.cshtml")]
    public partial class _Views_Product_Channel_cshtml : System.Web.Mvc.WebViewPage<NewLife.CMX.Channel>
    {
        public _Views_Product_Channel_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Product\Channel.cshtml"
  

            
            #line default
            #line hidden
WriteLiteral("\r\n<h2");

WriteLiteral(" class=\"tith2\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 5 "..\..\Views\Product\Channel.cshtml"
Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n</h2>\r\n");

            
            #line 7 "..\..\Views\Product\Channel.cshtml"
 foreach (var category in Model.Categories)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"widget2 fixed\"");

WriteLiteral(">\r\n        <h2");

WriteLiteral(" class=\"tit\"");

WriteLiteral(">\r\n            <em>");

            
            #line 11 "..\..\Views\Product\Channel.cshtml"
           Write(category.Name);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n            <small");

WriteLiteral(" style=\"float: right;\"");

WriteLiteral(">更多 &gt;&gt;</small>\r\n        </h2>\r\n        <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"list_news_dl fixed\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..\Views\Product\Channel.cshtml"
                
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Product\Channel.cshtml"
                 foreach (var item in category.GetTitles())
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 508), Tuple.Create("\"", 533)
            
            #line 19 "..\..\Views\Product\Channel.cshtml"
, Tuple.Create(Tuple.Create("", 515), Tuple.Create<System.Object, System.Int32>(this.GetUrl(item)
            
            #line default
            #line hidden
, 515), false)
);

WriteLiteral(">\r\n                            <i></i>");

            
            #line 20 "..\..\Views\Product\Channel.cshtml"
                              Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n");

            
            #line 23 "..\..\Views\Product\Channel.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n");

            
            #line 27 "..\..\Views\Product\Channel.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
