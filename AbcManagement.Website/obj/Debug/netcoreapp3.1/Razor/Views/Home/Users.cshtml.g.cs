#pragma checksum "D:\Projeler\AbcManagement\AbcManagement.Website\Views\Home\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e0665adf9e81b4a2cde17e12a02123318340ba1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
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
#line 1 "D:\Projeler\AbcManagement\AbcManagement.Website\Views\_ViewImports.cshtml"
using AbcManagement.Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projeler\AbcManagement\AbcManagement.Website\Views\_ViewImports.cshtml"
using AbcManagement.Website.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projeler\AbcManagement\AbcManagement.Website\Views\Home\Users.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projeler\AbcManagement\AbcManagement.Website\Views\Home\Users.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e0665adf9e81b4a2cde17e12a02123318340ba1", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd7fd792be828c1420bf7e181fd41558dac8f559", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save_User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Projeler\AbcManagement\AbcManagement.Website\Views\Home\Users.cshtml"
  
    ViewData["Title"] = "Users";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <h5>Users</h5>
        <div class=""card-header-right"">
            <ul class=""list-unstyled card-option text-right"" style=""width: 250px;"">
                <li id=""refresh"" data-placement=""left"" data-toggle=""tooltip"" title=""Yenile""><i class=""fas fa-sync-alt""></i></li>
                <li id=""addUser"" data-placement=""left"" data-toggle=""tooltip"" title=""Ekle""><i class=""fas fa-plus""></i></li>
            </ul>
        </div>
    </div>
    <div class=""card-block"" style=""height:calc(100% - 76px) !important;"">
        <div id=""grid"" class=""full-height"">
            <!--- Datagrid -->
            <div id=""gridContainer""></div>
            <div id=""popup"">
                <div data-options=""dxTemplate: { name: 'template1' }"" style=""overflow-y:scroll"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e0665adf9e81b4a2cde17e12a02123318340ba16407", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""dx-fieldset full-width d-flex flex-column"">
                                <div class=""dx-field d-flex flex-row""></div>
                                <div class=""dx-field-label flex-2"">Kullanıcı Adı</div>
                                <div class=""dx-field-value flex-10"">
                                    <input type=""text"" name=""UserName"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""dx-fieldset full-width d-flex flex-column"">
                                <div class=""dx-field d-flex flex-row""></div>
                                <div class=""dx-field-label flex-2"">Ad</div>
                                <div class=""dx-field-value flex-10"">
                                    <textarea name=""FirstName"" class=""form-control""></textarea>
                                </div>
                            </div>
     ");
                WriteLiteral(@"                       <div class=""dx-fieldset full-width d-flex flex-column"">
                                <div class=""dx-field d-flex flex-row""></div>
                                <div class=""dx-field-label flex-2"">Soyad</div>
                                <div class=""dx-field-value flex-10"">
                                    <input name=""LastName"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""dx-fieldset full-width d-flex flex-column"">
                                <div class=""dx-field d-flex flex-row""></div>
                                <div class=""dx-field-label flex-2"">Email</div>
                                <div class=""dx-field-value flex-10"">
                                    <input type=""email"" name=""Email"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""dx-fieldset full-width d-flex fle");
                WriteLiteral(@"x-column"">
                                <div class=""dx-field d-flex flex-row""></div>
                                <div class=""dx-field-label flex-2"">Şifre</div>
                                <div class=""dx-field-value flex-10"">
                                    <input type=""password"" name=""Password"" class=""form-control"" />
                                </div>
                            </div>
                            <div class=""dx-fieldset full-width d-flex flex-column"">
                                <div class=""dx-field d-flex flex-row""></div>
                                <div class=""dx-field-label flex-2"">Hakkında</div>
                                <div class=""dx-field-value flex-10"">
                                    <textarea name=""UserAbout"" class=""form-control""></textarea>
                                </div>
                            </div>
                            <div class=""dx-fieldset full-width d-flex flex-column"" hidden>
                           ");
                WriteLiteral(@"     <div class=""dx-field d-flex flex-row""hidden></div>
                                <div class=""border-checkbox-group border-checkbox-group-primary""hidden>
                                    <input class=""border-checkbox"" type=""checkbox"" value=""true"" name=""IsActive"" id=""checkbox1""hidden>                                    
                                </div>
                            </div>
                            <div class=""dx-fieldset full-width d-flex flex-column"">
                                <div class=""dx-field d-flex flex-row""></div>
                                <div class=""dx-field-label flex-2"">Kategori</div>
                                <div class=""dx-field-value flex-10"">
                                    <select name=""IsAdmin"" class=""form-control form-control-default"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e0665adf9e81b4a2cde17e12a02123318340ba110818", async() => {
                    WriteLiteral("Rol Seçiniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e0665adf9e81b4a2cde17e12a02123318340ba112201", async() => {
                    WriteLiteral("Admin");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e0665adf9e81b4a2cde17e12a02123318340ba113464", async() => {
                    WriteLiteral("User");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>
                            </div>                           
                        </div>
                        <div class=""col-md-6"" style=""max-inline-size: none;"">
                            <button type=""submit"" class=""btn btn-primary btn-md btn-block waves-effect text-center m-b-20"">Kaydet</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            if (");
#nullable restore
#line 103 "D:\Projeler\AbcManagement\AbcManagement.Website\Views\Home\Users.cshtml"
           Write(ViewBag.process);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" == 1) {
                Swal.fire({
                    html: '<span class=""f-w-600"">İşlem Başarılı</span>',
                    type: 'success',
                    width: 350,
                    showConfirmButton: false,
                    allowOutsideClick: false,
                    timer: 1500
                });
            } else if (");
#nullable restore
#line 112 "D:\Projeler\AbcManagement\AbcManagement.Website\Views\Home\Users.cshtml"
                  Write(ViewBag.process);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" == 2) {
                Swal.fire({
                    position: 'center',
                    type: 'error',
                    title: 'Hata',
                    html: '<span class=""f-16"">Ekleme işlemi sırasında hata oluştu.</span>',
                    showConfirmButton: true,
                    confirmButtonText: 'Tamam',
                    customClass: {
                        confirmButton: 'f-14 bg-inverse'
                    }
                });
            }
        });

        list();
        var userList, popup = null;

        var roles = [{
            ""value"": 0,
            ""text"": ""Admin""
        }, {
            ""value"": 1,
            ""text"": ""User""
        }];

        function list () {
            userList = $(function () {
                $.post(""");
#nullable restore
#line 140 "D:\Projeler\AbcManagement\AbcManagement.Website\Views\Home\Users.cshtml"
                   Write(Url.Action("List_User", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""")
                    .done(function (list) {
                        $(""#gridContainer"").dxDataGrid({
                            dataSource: list,
                            keyExpr: ""userId"",
                            showBorders: true,
                            editing: {
                                useIcons: true,
                                allowDeleting: true,
                                texts: {
                                    confirmDeleteMessage: """"
                                },
                                allowUpdating: true,
                            },
                            paging: {
                                pageSize: 10
                            },
                            pager: {
                                allowedPageSizes: [5, 8, 15, 30],
                                showInfo: true,
                                showNavigationButtons: true,
                                showPageSizeSelector: true,
           ");
                WriteLiteral(@"                     visible: true
                            },
                            columns: [{
                                dataField: ""userName"",
                                caption: ""Kullanıcı Adı""
                            }, {
                                dataField: ""firstName"",
                                caption: ""Ad""
                            },
                            {
                                dataField: ""lastName"",
                                caption: ""Soyad""
                            },
                            {
                                dataField: ""email"",
                                caption: ""E-Posta""
                            },
                            {
                                dataField: ""userAbout"",
                                caption: ""Hakkında""
                            },
                            {
                                dataField: ""isAdmin"",
                                cap");
                WriteLiteral(@"tion: ""Rol"",
                                lookup: {
                                    dataSource: roles,
                                    displayExpr: ""text"",
                                    valueExpr: ""value""
                                }
                            }, {
                                type: ""buttons"",
                                width: 110,
                                buttons: [""edit"" ,""delete""]
                            }],
                            onRowRemoving: function (e) {
                                e.cancel = Swal.fire({
                                    title: 'İşlem Onayı',
                                    html: '<span class=""f-16"">Silmek istediğinizden emin misiniz?</span>',
                                    type: 'question',
                                    allowOutsideClick: false,
                                    showCancelButton: true,
                                    confirmButtonText: 'Evet',
              ");
                WriteLiteral(@"                      cancelButtonText: 'Hayır',
                                    customClass: {
                                        confirmButton: 'f-14 bg-inverse',
                                        cancelButton: 'f-14 bg-default text-inverse'
                                    }
                                }).then((result) => {
                                    if (result.value) {
                                        return false;
                                    }
                                    else {
                                        return true;
                                    }
                                });
                            },
                            onRowRemoved: function (e) {
                                $.post(""");
#nullable restore
#line 219 "D:\Projeler\AbcManagement\AbcManagement.Website\Views\Home\Users.cshtml"
                                   Write(Url.Action("Delete_User", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""", e.data)
                                    .done(function (del) {
                                        if (del == true) {
                                            Swal.fire({
                                                html: '<span class=""f-w-600"">İşlem Başarılı</span>',
                                                type: 'success',
                                                width: 350,
                                                showConfirmButton: false,
                                                allowOutsideClick: false,
                                                timer: 1500
                                            });
                                        } else {
                                            Swal.fire({
                                                position: 'center',
                                                type: 'error',
                                                title: 'Hata',
                                          ");
                WriteLiteral(@"      html: '<span class=""f-16"">Silme işlemi sırasında hata oluştu.</span>',
                                                showConfirmButton: true,
                                                confirmButtonText: 'Tamam',
                                                customClass: {
                                                    confirmButton: 'f-14 bg-inverse'
                                                }
                                            });
                                        }
                                    });

                            },
                            onRowUpdated: function (f) {
                                $.post(""");
#nullable restore
#line 247 "D:\Projeler\AbcManagement\AbcManagement.Website\Views\Home\Users.cshtml"
                                   Write(Url.Action("Update_User", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""", { user: f.data })
                                    .done(function (upd) {
                                        if (upd == true) {
                                            Swal.fire({
                                                html: '<span class=""f-w-600"">İşlem Başarılı</span>',
                                                type: 'success',
                                                width: 350,
                                                showConfirmButton: false,
                                                allowOutsideClick: false,
                                                timer: 1500
                                            });
                                        }
                                        else {
                                            Swal.fire({
                                                position: 'center',
                                                type: 'error',
                                                title: ");
                WriteLiteral(@"'Hata',
                                                html: '<span class=""f-16"">Güncelleme işlemi sırasında hata oluştu.</span>',
                                                showConfirmButton: true,
                                                confirmButtonText: 'Tamam',
                                                customClass: {
                                                    confirmButton: 'f-14 bg-inverse'
                                                }
                                            });
                                        }
                                    });
                            }
                        });
                    });
            });
        }
        $(document).ready(function () {
            $(""#refresh"").click(function () {
                list();
            });
            $(""#addUser"").click(function () {
                popup.show();
            });
        });

        $(function () {
            popup = $(""#pop");
                WriteLiteral(@"up"").dxPopup({
                width: '50%',
                height: '80%',
                showTitle: true,
                title: ""Kullanıcı Ekle"",
                visible: false,
                dragEnabled: false,
                closeOnOutsideClick: true,
                contentTemplate: ""template1""
            }).dxPopup(""instance"");
            popup.visible = false;
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
