using Acme.Auzor.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Auzor.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AuzorController : AbpController
    {
        protected AuzorController()
        {
            LocalizationResource = typeof(AuzorResource);
        }
    }
}