using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Services.Cms;
using Nop.Plugin.Widgets.HelloWidget.Components;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.HelloWidget
{
    public class HelloWidgetPlugin : BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => false;

        public Task<IList<string>> GetWidgetZonesAsync()
        {
            // Directs the widget to load on the top of the store homepage
            return Task.FromResult<IList<string>>(new List<string> { PublicWidgetZones.HomepageTop });
        }

        public Type GetWidgetViewComponent(string widgetZone)
        {
            // We will build this view component next
            return typeof(Components.HelloWidgetViewComponent);
        }

        public override async Task InstallAsync()
        {
            await base.InstallAsync();
        }

        public override async Task UninstallAsync()
        {
            await base.UninstallAsync();
        }
    }
}