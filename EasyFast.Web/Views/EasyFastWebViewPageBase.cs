using Abp.Web.Mvc.Views;

namespace EasyFast.Web.Views
{
    public abstract class EasyFastWebViewPageBase : EasyFastWebViewPageBase<dynamic>
    {

    }

    public abstract class EasyFastWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected EasyFastWebViewPageBase()
        {
            LocalizationSourceName = EasyFastConsts.LocalizationSourceName;
        }
    }
}