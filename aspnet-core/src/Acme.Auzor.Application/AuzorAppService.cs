using System;
using System.Collections.Generic;
using System.Text;
using Acme.Auzor.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Auzor
{
    /* Inherit your application services from this class.
     */
    public abstract class AuzorAppService : ApplicationService
    {
        protected AuzorAppService()
        {
            LocalizationResource = typeof(AuzorResource);
        }
    }
}
