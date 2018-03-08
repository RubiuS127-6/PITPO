using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public interface IFormManager
    {
        #region Methods

        void CloseForm(BaseForm baseControl);

        void EditForm(Type type, int? id, params object[] args);

        BaseForm NewForm(Type type, int id, params object[] args);

        BaseForm NewStandaloneForm(Type type, int? id, params object[] args);

        void OpenForm(Type type, string filterString = null);

        void OpenForm(Type type, params object[] args);

        #endregion
    }
}
