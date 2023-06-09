#pragma checksum "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1d0619853374eba77fea42ff2d0c38d6c63ace"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owners_Details), @"mvc.1.0.view", @"/Views/Owners/Details.cshtml")]
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
#line 1 "C:\Users\Pinto\workspace\SQL\DogGo\Views\_ViewImports.cshtml"
using DogGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pinto\workspace\SQL\DogGo\Views\_ViewImports.cshtml"
using DogGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b1d0619853374eba77fea42ff2d0c38d6c63ace", @"/Views/Owners/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b50fd1f91f777ae09abf39d99992ea9d25da6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Owners_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DogGo.Models.ViewModels.ProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1 class=\"mb-4\">");
#nullable restore
#line 7 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                Write(Model.Owner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

    <section class=""container"">
        <img style=""width:100px;float:left;margin-right:20px""
             src=""https://upload.wikimedia.org/wikipedia/commons/a/a0/Font_Awesome_5_regular_user-circle.svg"" />
        <div>
            <label class=""font-weight-bold"">Address:</label>
            <span>");
#nullable restore
#line 14 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
             Write(Model.Owner.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <label class=\"font-weight-bold\">Phone:</label>\r\n            <span>");
#nullable restore
#line 18 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
             Write(Model.Owner.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div>\r\n            <label class=\"font-weight-bold\">Email:</label>\r\n            <span>");
#nullable restore
#line 22 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
             Write(Model.Owner.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
        </div>
    </section>

    <hr class=""mt-5"" />
    <div class=""clearfix""></div>

    <div class=""row"">
        <section class=""col-8 container mt-5"">
            <h1 class=""text-left"">Dogs</h1>
            <hr />
            <div class=""clearfix""></div>
            <div class=""row"">
");
#nullable restore
#line 35 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                 foreach (Dog dog in Model.Dogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card m-2\" style=\"width: 18rem;\">\r\n");
#nullable restore
#line 38 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                         if (String.IsNullOrEmpty(dog.ImageUrl))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img src=\"https://cdn.pixabay.com/photo/2018/08/15/13/12/dog-3608037_960_720.jpg\"\r\n                                 class=\"card-img-top\"\r\n                                 alt=\"Doggo\" />\r\n");
#nullable restore
#line 43 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 1617, "\"", 1636, 1);
#nullable restore
#line 46 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
WriteAttributeValue("", 1623, dog.ImageUrl, 1623, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"Doggo\" />\r\n");
#nullable restore
#line 47 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card-body\">\r\n                            <div>\r\n                                <label class=\"font-weight-bold\">Name:</label>\r\n                                <span>");
#nullable restore
#line 51 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                                 Write(dog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div>\r\n                                <label class=\"font-weight-bold\">Breed:</label>\r\n                                <span>");
#nullable restore
#line 55 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                                 Write(dog.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div>\r\n                                <label class=\"font-weight-bold\">Notes:</label>\r\n                                <p>");
#nullable restore
#line 59 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                              Write(dog.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 63 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </section>

        <section class=""col-lg-4 container mt-5"">
            <div>
                <h2>Walkers Near Me</h2>

                <table class=""table"">
                    <thead>
                        <tr>
                            <th>");
#nullable restore
#line 74 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Walker.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 75 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Walker.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 76 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                           Write(Html.DisplayName("Request Walk"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 80 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                         foreach (var item in Model.Walkers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <img class=\"bg-info\"");
            BeginWriteAttribute("src", " src=\"", 3257, "\"", 3277, 1);
#nullable restore
#line 84 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
WriteAttributeValue("", 3263, item.ImageUrl, 3263, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"avatar\" />\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 86 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 87 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                               Write(Html.ActionLink("Request Walk", "RequestWalk", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 89 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>                
            </div>

            <div class=""mt-5"">
                <h2>Upcoming Walks</h2>

                <table class=""table"">
                    <thead>
                        <tr>
                            <th>");
#nullable restore
#line 100 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Walker.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 101 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Dog.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 102 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Walk.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 103 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Walk.WalkStatus.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>                    \r\n");
#nullable restore
#line 107 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                         foreach (var item in Model.Walks)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 110 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Walker.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 111 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Dog.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 112 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 113 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.WalkStatus.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 115 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Owners\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </section>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DogGo.Models.ViewModels.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
