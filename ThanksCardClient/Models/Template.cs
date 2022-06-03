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
    internal class Template : BindableBase
    {
        #region IdProperty
        private long _Id;
        public long Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }
        #endregion

        #region TemplateNameProperty
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }
        #endregion

        #region TemplateContentProperty
        private string _Content;
        public string Content
        {
            get { return _Content; }
            set { SetProperty(ref _Content, value); }
        }
        #endregion
    }
}
