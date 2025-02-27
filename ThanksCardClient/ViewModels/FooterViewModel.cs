﻿#nullable disable
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using ThanksCardClient.Models;
using ThanksCardClient.Services;


namespace ThanksCardClient.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        private User _AuthorizedUser;
        public User AuthorizedUser
        {
            get { return _AuthorizedUser; }
            set { SetProperty(ref _AuthorizedUser, value); }
        }

        public FooterViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.AuthorizedUser = SessionService.Instance.AuthorizedUser;

        }


        #region ShowThanksCardCreateCommand
        private DelegateCommand _ShowThanksCardCreateCommand;
        public DelegateCommand ShowThanksCardCreateCommand =>
            _ShowThanksCardCreateCommand ?? (_ShowThanksCardCreateCommand = new DelegateCommand(ExecuteShowThanksCardCreateCommand));

        void ExecuteShowThanksCardCreateCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.ThanksCardCreate));
        }
        #endregion

        #region ShowThanksCardListCommand
        private DelegateCommand _ShowThanksCardListCommand;
        public DelegateCommand ShowThanksCardListCommand =>
            _ShowThanksCardListCommand ?? (_ShowThanksCardListCommand = new DelegateCommand(ExecuteShowThanksCardListCommand));

        void ExecuteShowThanksCardListCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.ThanksCardList));
        }
        #endregion

        #region ShowUserCreateCommand
        private DelegateCommand _ShowUserCreateCommand;
        public DelegateCommand ShowUserCreateCommand =>
            _ShowUserCreateCommand ?? (_ShowUserCreateCommand = new DelegateCommand(ExecuteShowUserCreateCommandCommand));

        void ExecuteShowUserCreateCommandCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.UserCreate));
        }
        #endregion

        #region ShowDepartmentCreateCommand
        private DelegateCommand _ShowDepartmentCreateCommand;
        public DelegateCommand ShowDepartmentCreateCommand =>
            _ShowDepartmentCreateCommand ?? (_ShowDepartmentCreateCommand = new DelegateCommand(ExecuteShowDepartmentCreateCommand));

        void ExecuteShowDepartmentCreateCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.DepartmentCreate));
        }
        #endregion

        #region ShowTagMstCommand
        private DelegateCommand _ShowTagMstCommand;
        public DelegateCommand ShowTagMstCommand =>
            _ShowTagMstCommand ?? (_ShowTagMstCommand = new DelegateCommand(ExecuteShowTagMstCommand));

        void ExecuteShowTagMstCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.TagMst));
        }
        #endregion

        #region LogoffCommand
        private DelegateCommand _logoffCommand;
        public DelegateCommand LogoffCommand =>
            _logoffCommand ?? (_logoffCommand = new DelegateCommand(ExecuteLogoffCommand));

        void ExecuteLogoffCommand()
        {
            SessionService.Instance.AuthorizedUser = null;
            SessionService.Instance.IsAuthorized = false;

            // HeaderRegion, FooterRegion を破棄して、ContentRegion をログオン画面に遷移させる。
            this.regionManager.Regions["HeaderRegion"].RemoveAll();
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.Logon));
            this.regionManager.Regions["FooterRegion"].RemoveAll();
        }
        #endregion

        #region ShowgusikenCommand
        private DelegateCommand _ShowgusikenCommand;
        public DelegateCommand ShowgusikenCommand =>
            _ShowgusikenCommand ?? (_ShowgusikenCommand = new DelegateCommand(ExecuteShowgusikenCommand));
        void ExecuteShowgusikenCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.Syukei));
        }
        #endregion

        #region ShowTemplateCommand
        private DelegateCommand _ShowTemplateCommand;
        public DelegateCommand ShowTemplateCommand =>
            _ShowTemplateCommand ?? (_ShowTemplateCommand = new DelegateCommand(ExecuteShowTemplateCommand));
        void ExecuteShowTemplateCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.Template));
        }
        #endregion

        #region ShowUserMstCommand
        private DelegateCommand _ShowUserMstCommand;
        public DelegateCommand ShowUserMstCommand =>
            _ShowUserMstCommand ?? (_ShowUserMstCommand = new DelegateCommand(ExecuteShowUserMstCommand));
        void ExecuteShowUserMstCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.UserMst));
        }
        # endregion

        #region ShowDepartmentEditCommand
        private DelegateCommand _ShowDepartmentEditCommand;
        public DelegateCommand ShowDepartmentEditCommand =>
            _ShowDepartmentEditCommand ?? (_ShowDepartmentEditCommand = new DelegateCommand(ExecuteShowDepartmentEditCommand));
        void ExecuteShowDepartmentEditCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.DepartmentEdit));
        }
        # endregion
    }

}
