using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Common
{
    public class FormManager : IFormManager
    {
        #region Static and Readonly Fields

        private static FormManager formManager;

        #endregion

        #region Constructors

        private FormManager()
        {
            var forms = Application.OpenForms;

            MainForm = forms.OfType<Form>().FirstOrDefault(q => q.Name == "MainForm");

            if (MainForm == null)
            {
                throw new ApplicationException("Cannot find MainForm");
            }
        }

        #endregion

        #region Static Properties

        public static IFormManager Instance
        {
            get
            {
                return formManager ?? (formManager = new FormManager());
            }
        }

        #endregion

        #region Properties

        private readonly List<BaseForm> _baseForms = new List<BaseForm>();
        public IEnumerable<BaseForm> BaseForms
        {
            get { return MainForm.MdiChildren.Cast<BaseForm>().Union(_baseForms); }
        }

        internal Form MainForm { get; set; }

        #endregion

        #region Methods

        private IEnumerable<BaseForm> GetChildrenForms(Type type)
        {
            return BaseForms.Where(f => f.GetType() == type);
        }

        #endregion

        #region IFormManager Members

        public void CloseForm(BaseForm baseForm)
        {
            if (baseForm == null)
            {
                throw new ArgumentNullException("baseForm");
            }

            var form = BaseForms.SingleOrDefault(f => f == baseForm);

            if (form == null)
            {
                return;
            }

            form.Close();
        }

        public BaseForm NewForm(Type type, int id, params object[] args)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (!type.IsSubclassOf(typeof(BaseForm)))
            {
                throw new ArgumentException("Type is not inherited from BaseForm");
            }

            var forms = GetChildrenForms(type).Where(f => f.Id == id).ToList();
            BaseForm form;
            switch (forms.Count)
            {
                case 0:
                    form = args.Length == 0 ? (BaseForm)Activator.CreateInstance(type, id) : (BaseForm)Activator.CreateInstance(type, id, args);
                    form.MdiParent = MainForm;
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                    break;
                default:
                    (form = (BaseForm)forms.Last()).Activate();
                    break;
            }

            return form;
        }

        public BaseForm NewStandaloneForm(Type type, int? id, params object[] args)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (!type.IsSubclassOf(typeof(BaseForm)))
            {
                throw new ArgumentException("Type is not inherited from BaseForm");
            }

            var form = args.Length == 0 ? (BaseForm)Activator.CreateInstance(type, id) : (BaseForm)Activator.CreateInstance(type, id, args);

            _baseForms.Add(form);

            return form;
        }

        public void EditForm(Type type, int? id, params object[] args)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (!type.IsSubclassOf(typeof(BaseForm)))
            {
                throw new ArgumentException("Type is not inherited from BaseControl");
            }

            var forms = GetChildrenForms(type).Where(f => f.Id == id).ToList();

            switch (forms.Count)
            {
                case 0:
                    var form = args.Length == 0 ? (BaseForm)Activator.CreateInstance(type, id) : (BaseForm)Activator.CreateInstance(type, id, args);
                    form.MdiParent = MainForm;
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                    break;
                default:
                    ((BaseForm)forms.Last()).Activate();
                    break;
            }
        }

        public void OpenForm(Type type, params object[] args)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (!type.IsSubclassOf(typeof(BaseForm)))
            {
                throw new ArgumentException("Type is not inherited from BaseForm");
            }

            var form = args.Length == 0 ? (BaseForm)Activator.CreateInstance(type) : (BaseForm)Activator.CreateInstance(type, args);
            form.MdiParent = MainForm;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        public void OpenForm(Type type, string filterString)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (!type.IsSubclassOf(typeof(BaseForm)))
            {
                throw new ArgumentException("Type is not inherited from BaseForm");
            }

            var forms = GetChildrenForms(type).Where(f => f.FilterString == filterString).ToList();

            var dialogResult = forms.Count == 0
                                            ? DialogResult.Yes
                                            : MessageBox.Show("Same form is already opened", "Form manager");
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    var form = filterString == null
                                              ? (BaseForm)Activator.CreateInstance(type)
                                              : (BaseForm)Activator.CreateInstance(type, filterString);
                    form.MdiParent = MainForm;
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                    break;
                case DialogResult.No:
                    ((BaseForm)forms.Last()).Activate();
                    break;
                case DialogResult.Cancel:
                    return;
                default:
                    throw new NotImplementedException();
            }
        }

        #endregion
    }
}
