#pragma checksum "E:\ECommerceSystem\ECommerceSystem\ECommerceSystem\Views\Product\ShowAllProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b001c8fb329a7fca50ae919ca8fae01790ad8fd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowAllProducts), @"mvc.1.0.view", @"/Views/Product/ShowAllProducts.cshtml")]
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
#line 1 "E:\ECommerceSystem\ECommerceSystem\ECommerceSystem\Views\_ViewImports.cshtml"
using ECommerceSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ECommerceSystem\ECommerceSystem\ECommerceSystem\Views\_ViewImports.cshtml"
using ECommerceSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b001c8fb329a7fca50ae919ca8fae01790ad8fd5", @"/Views/Product/ShowAllProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46169eb9a800799dea293b098656bd0db993d1cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowAllProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeletePopupPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ECommerceSystem\ECommerceSystem\ECommerceSystem\Views\Product\ShowAllProducts.cshtml"
  
    ViewData["Title"] = "ShowAllProducts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Show All Products</h1>\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/admin/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css\">\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
   
   
    <!-- DataTables  & Plugins -->
    <script src=""/admin/plugins/datatables/jquery.dataTables.min.js""></script>
    <script src=""/admin/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js""></script>
   
    <!-- AdminLTE App -->
    <script src=""/admin/js/adminlte.min.js""></script>
    <!-- AdminLTE for demo purposes -->
    <script src=""/admin/js/demo.js""></script>
    <!-- Page specific script -->
    <script>
        $(function () {
            $(""#products"").DataTable({
                ""processing"": true,
                ""serverSide"": true,
                ""ajax"": ""/Product/GetAllProducts"",

                ""columnDefs"": [
                    {
                        ""orderable"": false,
                        ""targets"": 4,
                        ""render"": function (data, type, row) {
                            return ` <button type=""submit"" class=""btn btn-info btn-sm"" onclick=""window.location.href='/Product/edit/${data}'"" value='${data}'>
                        ");
                WriteLiteral(@"        <i class=""fas fa-pencil-alt"">
                                 </i>
                                  Edit
                                  </button>
                                  <button type=""submit"" class=""btn btn-danger btn-sm show-bs-modal"" href=""#"" data-id='${data}' value='${data}'>
                                        <i class=""fas fa-trash"">
                                        </i>
                                        Delete
                                    </button>`;
                                                                       
                        }

                    }
                ]
            });


            $('#products').on('click', '.show-bs-modal', function (event) {
                var id = $(this).data(""id"");
                var modal = $(""#modal-default"");
                modal.find('.modal-body p').text('Are you sure you want to delete this record?')
                $(""#deleteId"").val(id);
                $(""#deleteForm");
                WriteLiteral(@""").attr(""action"", ""/product/delete"")
                modal.modal('show');
            });

            $(""#deleteButton"").click(function () {
                $(""#deleteForm"").submit();
            });


            //$('#products').on('click', '.show-bs-modal', function (event) {
            //    var id = $(this).data(""id"");
            //    var modal = $(""#modal-default"");
            //    modal.find('.modal-body p').text('Are you sure to Delete this Product?')
            //    $(""#deleteId"").val(id);
            //    $(""#deleteForm"").attr(""action"", ""/product/delete"")
            //    modal.modal('show');
            //});
            //$(""#deleteButton"").click(function () {
            //    $(""#deleteForm"").submit();
            //}
            //);
            
        });
       
    </script>

");
            }
            );
            WriteLiteral(@"

        <!-- Content Wrapper. Contains page content -->
  
            <!-- Content Header (Page header) -->
            <section class=""content-header"">
                <div class=""container-fluid"">
                    <div class=""row mb-2"">
                        <div class=""col-sm-6"">
                            <h1>Available Products</h1>
                        </div>
                        <div class=""col-sm-6"">
                            <ol class=""breadcrumb float-sm-right"">
                                <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                                <li class=""breadcrumb-item active"">Products</li>
                            </ol>
                        </div>
                    </div>
                </div><!-- /.container-fluid -->
            </section>

            <!-- Main content -->
            <section class=""content"">
                <div class=""container-fluid"">
                    <div class=""row"">
                  ");
            WriteLiteral(@"      <div class=""col-12"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">All Available Products</h3>
                                </div>
                                <!-- /.card-header -->
                                <div class=""card-body"">
                                    <table id=""products"" class=""table table-bordered table-hover"">
                                        <thead>
                                            <tr>
                                                <th>Product Name</th>
                                                <th>Price</th>
                                                <th>Date</th>
                                                <th>Category Id</th>
                                                <th style=""width:200px"">Action</th>
                                            </tr>
                                        </the");
            WriteLiteral("ad>\r\n");
            WriteLiteral(@"                                        <tfoot>
                                            <tr>
                                                <th>Product Name</th>
                                                <th>Price</th>
                                                <th>Date</th>
                                                <th>Category Id</th>
                                                <th style=""width:200px"">Action</th>
                                            </tr>
                                        </tfoot>
                                    </table>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b001c8fb329a7fca50ae919ca8fae01790ad8fd59936", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    
                                </div>
                                <!-- /.card-body -->
                            </div>
                            <!-- /.card -->   
                        </div>
                        <!-- /.col -->
                    </div>
                    <!-- /.row -->
                </div>
                <!-- /.container-fluid -->
            </section>
            <!-- /.content -->
        
        

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
