using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.HelloWidget.Components
{
    public class HelloWidgetViewComponent : NopViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            // This maps exactly to the view folder structure we will create next
            return View("~/Plugins/Widgets.HelloWidget/Views/PublicInfo.cshtml");
        }
    }
}