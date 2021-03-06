#pragma checksum "C:\Users\DELL\source\repos\ASP .Net Core\DemoSession5_WebApplication1\DemoSession5_WebApplication1\Areas\Vendor\Views\Chart\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15fd22e2a20ec6ba5003bb020005609259d2b831"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Vendor_Views_Chart_index), @"mvc.1.0.view", @"/Areas/Vendor/Views/Chart/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15fd22e2a20ec6ba5003bb020005609259d2b831", @"/Areas/Vendor/Views/Chart/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/_ViewImports.cshtml")]
    public class Areas_Vendor_Views_Chart_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\DELL\source\repos\ASP .Net Core\DemoSession5_WebApplication1\DemoSession5_WebApplication1\Areas\Vendor\Views\Chart\index.cshtml"
  
    ViewData["Title"] = "index";
    Layout = "~/Areas/Vendor/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1>ChartJS</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                    <li class=""breadcrumb-item active"">ChartJS</li>
                </ol>
            </div>
        </div>
    </div><!-- /.container-fluid -->
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-6"">
                <!-- AREA CHART -->
                <div class=""card card-primary"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Area Chart</h3>

                        <div class=""card-tools"">
                            <button type=""button");
            WriteLiteral(@""" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""chart"">
                            <canvas id=""areaChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;""></canvas>
                        </div>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
                <!-- DONUT CHART -->
                <div class=""card card-danger"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Donut Chart</h3>

                     ");
            WriteLiteral(@"   <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <canvas id=""donutChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;""></canvas>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
                <!-- PIE CHART -->
                <div class=""card card-danger"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Pie Chart</h3>

                        <div");
            WriteLiteral(@" class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <canvas id=""pieChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;""></canvas>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->

            </div>
            <!-- /.col (LEFT) -->
            <div class=""col-md-6"">
                <!-- LINE CHART -->
                <div class=""card card-info"">
                    <div class=""card-header"">
          ");
            WriteLiteral(@"              <h3 class=""card-title"">Line Chart</h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""chart"">
                            <canvas id=""lineChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;""></canvas>
                        </div>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
                <!-- BAR CHART -->
                <div class=""car");
            WriteLiteral(@"d card-success"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Bar Chart</h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""chart"">
                            <canvas id=""barChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;""></canvas>
                        </div>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card");
            WriteLiteral(@" -->
                <!-- STACKED BAR CHART -->
                <div class=""card card-success"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Stacked Bar Chart</h3>

                        <div class=""card-tools"">
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                                <i class=""fas fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                                <i class=""fas fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""chart"">
                            <canvas id=""stackedBarChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;""></canvas>
                        </div>
                    </div");
            WriteLiteral(@">
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->

            </div>
            <!-- /.col (RIGHT) -->
        </div>
        <!-- /.row -->
    </div><!-- /.container-fluid -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
