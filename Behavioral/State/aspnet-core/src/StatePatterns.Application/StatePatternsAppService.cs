using System;
using System.Collections.Generic;
using System.Text;
using StatePatterns.Localization;
using Volo.Abp.Application.Services;

namespace StatePatterns;

/* Inherit your application services from this class.
 */
public abstract class StatePatternsAppService : ApplicationService
{
    protected StatePatternsAppService()
    {
        LocalizationResource = typeof(StatePatternsResource);
    }
}
