#nullable disable
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThanksCardClient.Models;

namespace ThanksCardClient.ViewModels
{
    public class LogonViewModel : BindableBase
    {
        private IRegionManager regionManager;

        #region EmployeeProperty
        private Employee _Employee;
        public Employee Employee
        {
            get { return _Employee; }
            set { SetProperty(ref _Employee, value); }
        }
        #endregion


        #region ErrorMessage
        private string _ErrorMessage;
        public string ErrorMessage
        {
            get { return _ErrorMessage; }
            set { SetProperty(ref _ErrorMessage, value); }
        }
        #endregion
        public LogonViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            this.Employee = new Employee();
            this.Employee.Name = "比嘉哲平";
            this.Employee.Password = "Higa0001";
        }

        #region LogonCommand
        private DelegateCommand _LogonCommand;
        public DelegateCommand LogonCommand =>
            _LogonCommand ?? (_LogonCommand = new DelegateCommand(ExecuteLogonCommandAsync));

        async void ExecuteLogonCommandAsync()
        {
            Employee authorizedEmployee = await this.Employee.LogonAsync();

            if (authorizedEmployee != null)
            {
                this.ErrorMessage = "";
                this.regionManager.RequestNavigate("ContentRegion", nameof(Views.ThanksCardList));
            }
            else
            {
                this.ErrorMessage = "ログオンに失敗しました。";
            }
        }
        #endregion
    }
}
