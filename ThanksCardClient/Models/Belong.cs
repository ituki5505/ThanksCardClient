#nullable disable
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThanksCardClient.Models
{
    public class Belong : BindableBase
    {
        #region IdProperty
        private long _Id;
        public long Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
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

        #region SonzaiIdProperty
        private long _SonzaiId;
        public long SonzaiId
        {
            get { return _SonzaiId; }
            set { SetProperty(ref _SonzaiId, value); }
        }
        #endregion

        #region Parent_IdProperty
        private long? _Parent_Id;
        public long? Parent_Id
        {
            get { return _Parent_Id; }
            set { SetProperty(ref _Parent_Id, value); }
        }
        #endregion

        #region BelongParentProperty
        private Belong _Parent;
        public Belong Parent
        {
            get { return _Parent; }
            set { SetProperty(ref _Parent, value); }
        }
        #endregion

        #region ChildrenProperty
        private ICollection<Belong> _Children;
        public virtual ICollection<Belong> Children
        {
            get { return _Children; }
            set { SetProperty(ref _Children, value); }
        }
        #endregion
    }
}
