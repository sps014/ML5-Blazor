#pragma checksum "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\Pages\ImageClassifier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8d3dd6e7073a9682152c99cc403497a2712dc8"
// <auto-generated/>
#pragma warning disable 1591
namespace SampleApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\_Imports.razor"
using SampleApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\_Imports.razor"
using SampleApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\Pages\ImageClassifier.razor"
using ML5;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ImageClassifier")]
    public partial class ImageClassifier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "center");
            __builder.AddMarkupContent(1, "\r\n        ");
            __builder.AddMarkupContent(2, "<p>Expected Image is :</p>\r\n        ");
            __builder.OpenElement(3, "p");
            __builder.AddAttribute(4, "style", "font-weight:bolder");
            __builder.AddContent(5, 
#nullable restore
#line 7 "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\Pages\ImageClassifier.razor"
                                       Res

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n        ");
            __builder.OpenElement(7, "video");
            __builder.AddAttribute(8, "width", "90%");
            __builder.AddAttribute(9, "height", "60%");
            __builder.AddAttribute(10, "crossorigin", "anonymous");
            __builder.AddAttribute(11, "autoplay", true);
            __builder.AddAttribute(12, "src", "http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/WeAreGoingOnBullrun.mp4");
            __builder.AddElementReferenceCapture(13, (__value) => {
#nullable restore
#line 9 "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\Pages\ImageClassifier.razor"
                                              video = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Shivendra\Desktop\test\ML5ForBlazor\SampleApplication\Pages\ImageClassifier.razor"
 
    ElementReference video;
    ML5.ImageClassifier classifier;
    private string Res;
    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            classifier = new ML5.ImageClassifier(Runtime, ImageModel.MobileNet);
            classifier.OnModelLoad += ModelLoad;
            classifier.OnClassification += GetClassfy;
        }
        else
        {
            classifier.Classify(video);
        }

        base.OnAfterRender(firstRender);

    }

    private void ModelLoad()
    {
        classifier.Classify(video);
    }
    private void GetClassfy(string err, CResult[] res)
    {
        Res = res[0].label;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Runtime { get; set; }
    }
}
#pragma warning restore 1591