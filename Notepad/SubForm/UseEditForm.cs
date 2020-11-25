using System;
using System.Windows.Forms;
using System.Drawing;

namespace Notepad.SubForm
{
    public class UseEditForm
    {
        public static Form _EditForm;

        public static void Edit(Form parent, Type formType, params object[] param)
        {
            if (_EditForm != null)
            {
                if (_EditForm.GetType() != formType)
                {
                    _EditForm.Close();
                    _EditForm = null;
                }
                else
                {
                    _EditForm.Focus();
                    return;
                }
            }

            SetParameter(formType, param);
            _EditForm = (Form)Activator.CreateInstance(formType);
            _EditForm.Owner = parent;
            _EditForm.Location = new Point(parent.Location.X + 150, parent.Location.Y + 50);
            _EditForm.Show();
        }

        public static void CloseForm()
        {
            _EditForm.Close();
            _EditForm = null;
        }

        private static void SetParameter(Type form, params object[] param)
        {
            if (form == typeof(GoToForm))
                GoToForm.SetLineNumber = Convert.ToInt32(param[0]);
            else if (form == typeof(EncryptForm))
                EncryptForm.SetSource = param[0].ToString();
            else if (form == typeof(SearchForm) || form == typeof(ReplaceForm))
                CommonFunction.StartIndex = Convert.ToInt32(param[0]);
        }
    }
}
