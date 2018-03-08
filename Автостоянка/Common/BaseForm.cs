using System;
using System.Linq;
using System.Windows.Forms;

namespace Common
{
    public class BaseForm : Form
    {
        #region Constructors

        protected BaseForm(string filterString)
            : this()
        {
            FilterString = filterString;
        }

        protected BaseForm(params object[] args)
            : this()
        {
            Args = args;
        }

        protected BaseForm(int id, params object[] args)
            : this()
        {
            Id = id;
            Args = args;
        }

        protected BaseForm()
        {
        }

        #endregion

        #region Properties

        internal string FilterString
        {
            get;
            private set;
        }

        internal int? Id
        {
            get;
            private set;
        }

        protected object[] Args
        {
            get;
            set;
        }

        public bool HasHeader { get; protected set; }

        #endregion

        #region Methods        

        public virtual void RefreshForm()
        {
        }

        #endregion
    }
}
