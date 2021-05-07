using DemoReactiveUi.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoReactiveUi
{
    public class AppBootstrapper
    {
        public AppBootstrapper()
        {
            RegisterServices();
        }

        private void RegisterServices()
        {
            Splat.Locator.CurrentMutable.Register(() => new StaticContactsService(), typeof(IContactsService));
        }
    }
}
