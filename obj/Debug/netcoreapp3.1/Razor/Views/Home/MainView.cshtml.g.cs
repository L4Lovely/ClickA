#pragma checksum "C:\Users\lupol\source\repos\ClickA\Views\Home\MainView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "308c444b84b8400523e3db1755a68c08d67ea446"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MainView), @"mvc.1.0.view", @"/Views/Home/MainView.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\lupol\source\repos\ClickA\Views\_ViewImports.cshtml"
using ClickA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lupol\source\repos\ClickA\Views\_ViewImports.cshtml"
using ClickA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lupol\source\repos\ClickA\Views\Home\MainView.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lupol\source\repos\ClickA\Views\Home\MainView.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308c444b84b8400523e3db1755a68c08d67ea446", @"/Views/Home/MainView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"030f26a134178e1a1b0c147015595c84d5dee0ff", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_MainView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/mainView.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "308c444b84b8400523e3db1755a68c08d67ea4464089", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""GameStatusHeader"">
    <label class=""CurrencyInfo"" id=""CurrencyLabel"">
        ENERGY
    </label>
</div>

<div class=""GeneratorTab"">
    <button id=""EnergyButton"" class=""EnergyButton"">⚡</button>
</div>

<div class=""ComponentPanel"">
    <div class=""upgradeparentbox"">
        <div class=""upgradebuttonbox"">
            <button id=""ClickPower_Upgrade"" class=""UpgradeButton ClickPower"">⚡</button>

        </div>
        <div class=""upgradelabelbox"">
            <label");
            BeginWriteAttribute("style", " style=\"", 628, "\"", 636, 0);
            EndWriteAttribute();
            WriteLiteral(">INFO</label>\r\n\r\n        </div>\r\n        <div class=\"upgradecostinfobox\">\r\n            <label");
            BeginWriteAttribute("id", " id=\"", 730, "\"", 735, 0);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 736, "\"", 744, 0);
            EndWriteAttribute();
            WriteLiteral(@">COST</label>

        </div>
    </div>

    <div class=""upgradeparentbox"">
        <div class=""upgradebuttonbox"">
            <button id=""ClickPower_Upgrade"" class=""UpgradeButton ClickPower"">⚡</button>

        </div>
        <div class=""upgradelabelbox"">
            <label");
            BeginWriteAttribute("style", " style=\"", 1032, "\"", 1040, 0);
            EndWriteAttribute();
            WriteLiteral(">INFO</label>\r\n\r\n        </div>\r\n        <div class=\"upgradecostinfobox\">\r\n            <label");
            BeginWriteAttribute("id", " id=\"", 1134, "\"", 1139, 0);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1140, "\"", 1148, 0);
            EndWriteAttribute();
            WriteLiteral(@">COST</label>

        </div>
    </div>
</div>

<script>

    let ENERGY = 0;
    let ENERGY_INCVAL = 1;
    let EnergyButton = document.getElementById(""EnergyButton"");
    let CurrencyLabel = document.getElementById(""CurrencyLabel"");

    let ClickPowerButton = document.getElementById(""ClickPower_Upgrade"");
    let ClickPowerCost = 20;

    EnergyButton.addEventListener('click', () => {
        ENERGY += ENERGY_INCVAL;
        CurrencyLabel.textContent = ENERGY.toString() + ""E"";
    })

    ClickPowerButton.addEventListener('click', () => {
        if (ENERGY >= ClickPowerCost) {
            ENERGY_INCVAL += 1;             // increase click power by 1
            ENERGY -= ClickPowerCost;       // deduct the cost from currency
            ClickPowerCost *= 2;            // increase upgrade cost
            CurrencyLabel.textContent = ENERGY.toString() + ""E""; // update currency info label
        }
    })


    setTimeout(cashout_timer, 300);
    function cashout_timer() {
  ");
            WriteLiteral("      console.log(\'TICK\');\r\n        setTimeout(cashout_timer2, 300);\r\n    }\r\n    function cashout_timer2() {\r\n        console.log(\'TICK2\');\r\n        setTimeout(cashout_timer, 300);\r\n    }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataTable> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
