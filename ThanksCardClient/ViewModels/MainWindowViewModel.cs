using Prism.Mvvm;
using Prism.Regions;

namespace ThanksCardClient.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
         private readonly IRegionManager regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.regionManager.RegisterViewWithRegion("ContentRegion", typeof(Views.Logon));
        }
    }
}