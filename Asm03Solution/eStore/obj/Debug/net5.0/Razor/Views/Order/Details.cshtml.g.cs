#pragma checksum "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "31491efd7d0d494c79ed8d8f12690a80fde4d4ba13e392872eb0598a54b997df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\_ViewImports.cshtml"
using eStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\_ViewImports.cshtml"
using eStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"31491efd7d0d494c79ed8d8f12690a80fde4d4ba13e392872eb0598a54b997df", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"075db933fc649c671183c6525454b3de5089adf20bc2cfdf2d13f36fa43cb60d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eStore.ViewModels.OrderDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Order</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 15 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 18 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n           ");
#nullable restore
#line 21 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
      Write(Html.DisplayNameFor(model => model.Order.MemberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 24 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.MemberId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n           ");
#nullable restore
#line 27 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
      Write(Html.DisplayNameFor(model => model.Order.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 30 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n             ");
#nullable restore
#line 33 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
        Write(Html.DisplayNameFor(model => model.Order.RequireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n           ");
#nullable restore
#line 36 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
      Write(Html.DisplayFor(model => model.Order.RequireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 39 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 42 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n             ");
#nullable restore
#line 45 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
        Write(Html.DisplayNameFor(model => model.Order.Freight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n             ");
#nullable restore
#line 48 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
        Write(Html.DisplayFor(model => model.Order.Freight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n         <dt class = \"col-sm-2\">\n             ");
#nullable restore
#line 51 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
        Write(Html.DisplayNameFor(model => model.Order.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n             ");
#nullable restore
#line 54 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
        Write(Html.DisplayFor(model => model.Order.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        \n         <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 59 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDetail.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 62 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderDetail.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 65 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDetail.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 68 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderDetail.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 71 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDetail.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 74 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderDetail.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 77 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDetail.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 80 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderDetail.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31491efd7d0d494c79ed8d8f12690a80fde4d4ba13e392872eb0598a54b997df11540", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "D:\Downloads\Ass03Solution-main\Ass03Solution-main\eStore\Views\Order\Details.cshtml"
                           WriteLiteral(Model.Order.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31491efd7d0d494c79ed8d8f12690a80fde4d4ba13e392872eb0598a54b997df13721", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eStore.ViewModels.OrderDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
