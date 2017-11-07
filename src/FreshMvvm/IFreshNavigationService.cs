using Xamarin.Forms;
using System.Threading.Tasks;
using FreshMvvm.Base;

namespace FreshMvvm
{
    public interface IFreshNavigationService
    {
        Task PopToRoot(bool animate = true);

        Task PushPage(Page page, bool modal = false, bool animate = true);

        Task PushPageModel<TPageModel>(bool modal = false, bool animate = true) where TPageModel : FreshPageModel;

        Task Pop(bool modal = false, bool animate = true);

        /// <summary>
        /// This method switches the selected main page, TabbedPage the selected tab or if MasterDetail, works with custom pages also
        /// </summary>
        /// <returns>The BagePageModel, allows you to PopToRoot, Pass Data</returns>
        Task<FreshPageModel> SwitchSelectedRootPageModel<TPageModel>() where TPageModel : FreshPageModel;

        void NotifyChildrenPageWasPopped();

        string NavigationServiceName { get; }
    }
}

