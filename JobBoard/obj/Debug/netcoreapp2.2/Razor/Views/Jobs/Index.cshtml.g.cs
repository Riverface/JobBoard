#pragma checksum "C:\Users\sonos\Documents\Classwork\JobBoard\JobBoard\Views\Jobs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "808526ee5e33dda9099a5f0a3f6b3c2cf87deeb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jobs_Index), @"mvc.1.0.view", @"/Views/Jobs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jobs/Index.cshtml", typeof(AspNetCore.Views_Jobs_Index))]
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
#line 1 "C:\Users\sonos\Documents\Classwork\JobBoard\JobBoard\Views\Jobs\Index.cshtml"
using JobBoard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"808526ee5e33dda9099a5f0a3f6b3c2cf87deeb7", @"/Views/Jobs/Index.cshtml")]
    public class Views_Jobs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 62, true);
            WriteLiteral("<h1>Welcome to Planet Express. Yes, we ship dogs.</h1>\r\n<ul>\r\n");
            EndContext();
#line 4 "C:\Users\sonos\Documents\Classwork\JobBoard\JobBoard\Views\Jobs\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(114, 44, true);
            WriteLiteral("  <p>There are no Parcels in the list.</p>\r\n");
            EndContext();
#line 7 "C:\Users\sonos\Documents\Classwork\JobBoard\JobBoard\Views\Jobs\Index.cshtml"
}

#line default
#line hidden
            BeginContext(161, 6, true);
            WriteLiteral("<ul>\r\n");
            EndContext();
#line 9 "C:\Users\sonos\Documents\Classwork\JobBoard\JobBoard\Views\Jobs\Index.cshtml"
   foreach (JobOpening opening in Model)
  {

#line default
#line hidden
            BeginContext(214, 19, true);
            WriteLiteral("    <li><a href=\"\">");
            EndContext();
            BeginContext(234, 12, false);
#line 11 "C:\Users\sonos\Documents\Classwork\JobBoard\JobBoard\Views\Jobs\Index.cshtml"
              Write(opening.Name);

#line default
#line hidden
            EndContext();
            BeginContext(246, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 12 "C:\Users\sonos\Documents\Classwork\JobBoard\JobBoard\Views\Jobs\Index.cshtml"
  } 

#line default
#line hidden
            BeginContext(263, 53, true);
            WriteLiteral("</ul>\r\n\r\n<a href=\"/parcel/new\">Add a new Parcel.</a> ");
            EndContext();
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