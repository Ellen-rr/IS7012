#pragma checksum "D:\github\IS7012\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc537e0b44dee3dd45f9c1039660ab7b915bf8c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecruitCatYumy.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace RecruitCatYumy.Pages
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
#line 1 "D:\github\IS7012\Week3\RecruitCatYumy\RecruitCatYumy\Pages\_ViewImports.cshtml"
using RecruitCatYumy;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc537e0b44dee3dd45f9c1039660ab7b915bf8c1", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f96cda475c5169eb3e768a2a69171f7e65c919", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-light-grey"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\github\IS7012\Week3\RecruitCatYumy\RecruitCatYumy\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc537e0b44dee3dd45f9c1039660ab7b915bf8c14587", async() => {
                WriteLiteral("\r\n    <style>\r\n        body, h1, h2, h3, h4, h5, h6 {\r\n            font-family: \"Raleway\", Arial, Helvetica, sans-serif\r\n        }\r\n\r\n        .myLink {\r\n            display: none\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc537e0b44dee3dd45f9c1039660ab7b915bf8c15780", async() => {
                WriteLiteral(@"

        <!-- Navigation Bar -->
        <div class=""w3-bar w3-white w3-border-bottom w3-xlarge"">
            <a href=""#"" class=""w3-bar-item w3-button w3-text-red w3-hover-red""><b><i class=""fa fa-map-marker w3-margin-right""></i>Logo</b></a>
            <a href=""#"" class=""w3-bar-item w3-button w3-right w3-hover-red w3-text-grey""><i class=""fa fa-search""></i></a>
        </div>

        <!-- Header -->
        <header class=""w3-display-container w3-content w3-hide-small"" style=""max-width:1500px"">
            <img class=""w3-image"" src=""/w3images/london2.jpg"" alt=""London"" width=""1500"" height=""700"">
            <div class=""w3-display-middle"" style=""width:65%"">
                <div class=""w3-bar w3-black"">
                    <button class=""w3-bar-item w3-button tablink"" onclick=""openLink(event, 'Flight');""><i class=""fa fa-plane w3-margin-right""></i>Flight</button>
                    <button class=""w3-bar-item w3-button tablink"" onclick=""openLink(event, 'Hotel');""><i class=""fa fa-bed w3-margin-right""");
                WriteLiteral(@"></i>Hotel</button>
                    <button class=""w3-bar-item w3-button tablink"" onclick=""openLink(event, 'Car');""><i class=""fa fa-car w3-margin-right""></i>Rental</button>
                </div>

                <!-- Tabs -->
                <div id=""Flight"" class=""w3-container w3-white w3-padding-16 myLink"">
                    <h3>Travel the world with us</h3>
                    <div class=""w3-row-padding"" style=""margin:0 -16px;"">
                        <div class=""w3-half"">
                            <label>From</label>
                            <input class=""w3-input w3-border"" type=""text"" placeholder=""Departing from"">
                        </div>
                        <div class=""w3-half"">
                            <label>To</label>
                            <input class=""w3-input w3-border"" type=""text"" placeholder=""Arriving at"">
                        </div>
                    </div>
                    <p><button class=""w3-button w3-dark-grey"">Search and find dates<");
                WriteLiteral(@"/button></p>
                </div>

                <div id=""Hotel"" class=""w3-container w3-white w3-padding-16 myLink"">
                    <h3>Find the best hotels</h3>
                    <p>Book a hotel with us and get the best fares and promotions.</p>
                    <p>We know hotels - we know comfort.</p>
                    <p><button class=""w3-button w3-dark-grey"">Search Hotels</button></p>
                </div>

                <div id=""Car"" class=""w3-container w3-white w3-padding-16 myLink"">
                    <h3>Best car rental in the world!</h3>
                    <p><span class=""w3-tag w3-deep-orange"">DISCOUNT!</span> Special offer if you book today: 25% off anywhere in the world with CarServiceRentalRUs</p>
                    <input class=""w3-input w3-border"" type=""text"" placeholder=""Pick-up point"">
                    <p><button class=""w3-button w3-dark-grey"">Search Availability</button></p>
                </div>
            </div>
        </header>

        <!-- ");
                WriteLiteral(@"Page content -->
        <div class=""w3-content"" style=""max-width:1100px;"">

            <!-- Good offers -->
            <div class=""w3-container w3-margin-top"">
                <h3>Good Offers Right Now</h3>
                <h6>Up to <strong>50%</strong> discount.</h6>
            </div>
            <div class=""w3-row-padding w3-text-white w3-large"">
                <div class=""w3-half w3-margin-bottom"">
                    <div class=""w3-display-container"">
                        <img src=""/w3images/cinqueterre.jpg"" alt=""Cinque Terre"" style=""width:100%"">
                        <span class=""w3-display-bottomleft w3-padding"">Cinque Terre</span>
                    </div>
                </div>
                <div class=""w3-half"">
                    <div class=""w3-row-padding"" style=""margin:0 -16px"">
                        <div class=""w3-half w3-margin-bottom"">
                            <div class=""w3-display-container"">
                                <img src=""/w3images/newyork2.jp");
                WriteLiteral(@"g"" alt=""New York"" style=""width:100%"">
                                <span class=""w3-display-bottomleft w3-padding"">New York</span>
                            </div>
                        </div>
                        <div class=""w3-half w3-margin-bottom"">
                            <div class=""w3-display-container"">
                                <img src=""/w3images/sanfran.jpg"" alt=""San Francisco"" style=""width:100%"">
                                <span class=""w3-display-bottomleft w3-padding"">San Francisco</span>
                            </div>
                        </div>
                    </div>
                    <div class=""w3-row-padding"" style=""margin:0 -16px"">
                        <div class=""w3-half w3-margin-bottom"">
                            <div class=""w3-display-container"">
                                <img src=""/w3images/pisa.jpg"" alt=""Pisa"" style=""width:100%"">
                                <span class=""w3-display-bottomleft w3-padding"">Pisa</span>
   ");
                WriteLiteral(@"                         </div>
                        </div>
                        <div class=""w3-half w3-margin-bottom"">
                            <div class=""w3-display-container"">
                                <img src=""/w3images/paris.jpg"" alt=""Paris"" style=""width:100%"">
                                <span class=""w3-display-bottomleft w3-padding"">Paris</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Explore Nature -->
            <div class=""w3-container"">
                <h3>Explore Nature</h3>
                <p>Travel with us and see nature at its finest.</p>
            </div>
            <div class=""w3-row-padding"">
                <div class=""w3-half w3-margin-bottom"">
                    <img src=""/w3images/ocean2.jpg"" alt=""Norway"" style=""width:100%"">
                    <div class=""w3-container w3-white"">
                        <h3>West Coast, Norway</h3>");
                WriteLiteral(@"
                        <p class=""w3-opacity"">Roundtrip from $79</p>
                        <p>Praesent tincidunt sed tellus ut rutrum sed vitae justo.</p>
                        <button class=""w3-button w3-margin-bottom"">Buy Tickets</button>
                    </div>
                </div>
                <div class=""w3-half w3-margin-bottom"">
                    <img src=""/w3images/mountains2.jpg"" alt=""Austria"" style=""width:100%"">
                    <div class=""w3-container w3-white"">
                        <h3>Mountains, Austria</h3>
                        <p class=""w3-opacity"">One-way from $39</p>
                        <p>Praesent tincidunt sed tellus ut rutrum sed vitae justo.</p>
                        <button class=""w3-button w3-margin-bottom"">Buy Tickets</button>
                    </div>
                </div>
            </div>

            <!-- Newsletter -->
            <div class=""w3-container"">
                <div class=""w3-panel w3-padding-16 w3-black w3-opacity w3");
                WriteLiteral(@"-card w3-hover-opacity-off"">
                    <h2>Get the best offers first!</h2>
                    <p>Join our newsletter.</p>
                    <label>E-mail</label>
                    <input class=""w3-input w3-border"" type=""text"" placeholder=""Your Email address"">
                    <button type=""button"" class=""w3-button w3-red w3-margin-top"">Subscribe</button>
                </div>
            </div>

            <!-- Contact -->
            <div class=""w3-container"">
                <h2>Contact</h2>
                <p>Let us book your next trip!</p>
                <i class=""fa fa-map-marker"" style=""width:30px""></i> Chicago, US<br>
                <i class=""fa fa-phone"" style=""width:30px""></i> Phone: +00 151515<br>
                <i class=""fa fa-envelope"" style=""width:30px""> </i> Email: mail@mail.com<br>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc537e0b44dee3dd45f9c1039660ab7b915bf8c114554", async() => {
                    WriteLiteral(@"
                    <p><input class=""w3-input w3-padding-16 w3-border"" type=""text"" placeholder=""Name"" required name=""Name""></p>
                    <p><input class=""w3-input w3-padding-16 w3-border"" type=""text"" placeholder=""Email"" required name=""Email""></p>
                    <p><input class=""w3-input w3-padding-16 w3-border"" type=""text"" placeholder=""Message"" required name=""Message""></p>
                    <p><button class=""w3-button w3-black w3-padding-large"" type=""submit"">SEND MESSAGE</button></p>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            </div>

            <!-- End page content -->
        </div>

        <!-- Footer -->
        <footer class=""w3-container w3-center w3-opacity w3-margin-bottom"">
            <h5>Find Us On</h5>
            <div class=""w3-xlarge w3-padding-16"">
                <i class=""fa fa-facebook-official w3-hover-opacity""></i>
                <i class=""fa fa-instagram w3-hover-opacity""></i>
                <i class=""fa fa-snapchat w3-hover-opacity""></i>
                <i class=""fa fa-pinterest-p w3-hover-opacity""></i>
                <i class=""fa fa-twitter w3-hover-opacity""></i>
                <i class=""fa fa-linkedin w3-hover-opacity""></i>
            </div>
            <p>Powered by <a href=""https://www.w3schools.com/w3css/default.asp"" target=""_blank"" class=""w3-hover-text-green"">w3.css</a></p>
        </footer>

        <script>
            // Tabs
            function openLink(evt, linkName) {
                var i, x, tablinks;
                x = document.getElementsByClassNam");
                WriteLiteral(@"e(""myLink"");
                for (i = 0; i < x.length; i++) {
                    x[i].style.display = ""none"";
                }
                tablinks = document.getElementsByClassName(""tablink"");
                for (i = 0; i < x.length; i++) {
                    tablinks[i].className = tablinks[i].className.replace("" w3-red"", """");
                }
                document.getElementById(linkName).style.display = ""block"";
                evt.currentTarget.className += "" w3-red"";
            }

            // Click on the first tablink on load
            document.getElementsByClassName(""tablink"")[0].click();
        </script>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
