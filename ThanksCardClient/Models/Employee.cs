#nullable disable
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanksCardClient.Services;

namespace ThanksCardClient.Models
{
    public class Employee : BindableBase
    {
        #region IdProperty
        private long _Id;
        public long Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }
        #endregion

        #region CdProperty
        private long _Cd;
        public long Cd
        {
            get { return _Cd; }
            set { SetProperty(ref _Cd, value); }
        }
        #endregion

        #region NameProperty
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }
        #endregion

        #region PasswordProperty
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { SetProperty(ref _Password, value); }
        }
        #endregion

        #region Sonzai_IdProperty
        private long _Sonzai_Id;
        public long Sonzai_Id
        {
            get { return _Sonzai_Id; }
            set { SetProperty(ref _Sonzai_Id, value); }
        }
        #endregion

        #region Belongs_IdProperty
        private long _Belongs_Id;
        public long Belongs_Id
        {
            get { return _Belongs_Id; }
            set { SetProperty(ref _Belongs_Id, value); }
        }
        #endregion

        #region BelongsProperty
        private Belong _Belongs;
        public virtual Belong Belongs
        {
            get { return _Belongs; }
            set { SetProperty(ref _Belongs, value); }
        }
        #endregion

        #region IsEmployeeProperty
        private bool _IsEmployee;
        public bool IsEmployee
        {
            get { return _IsEmployee; }
            set { SetProperty(ref _IsEmployee, value); }
        }
        #endregion

        public async Task<Employee> LogonAsync()
        {
            IRestService rest = new RestService();
            Employee authorizedEmployee = await rest.LogonAsync(this);
            return authorizedEmployee;
        }


    }
}
