using StatePatterns.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StatePatterns.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StatePatternsController : AbpControllerBase
{
    protected StatePatternsController()
    {
        LocalizationResource = typeof(StatePatternsResource);
    }
}
