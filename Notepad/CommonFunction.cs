using System;
using System.Windows.Forms;
using System.Drawing;

namespace Notepad
{
    public class CommonFunction
    {
        public static Form _EditForm;

        private static string _Content = "";
        public static int _StartIndex = -1;
        private static string _Target = "";

        public delegate void MarkTargetDelegate(int index, int length);
        public static MarkTargetDelegate _markTargetHandler;

        public static void RegisterMarkTargetDelegate(MarkTargetDelegate func)
        {
            _markTargetHandler = func;
        }

        public static void RemoveMarkTargetDelegate()
        {
            _markTargetHandler = null;
        }

        public static string SetContent
        {
            set { _Content = value; }
        }

        public static string SetTarget
        {
            set { _Target = value; }
        }

        public static void UseEditForm(Form parent, Type formType, int start)
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

            _StartIndex = start;
            _EditForm = (Form)Activator.CreateInstance(formType);
            _EditForm.Owner = parent;
            _EditForm.Location = new Point(parent.Location.X + 150, parent.Location.Y + 50);
            _EditForm.Show();
        }

        public static void SearchTarget(bool previous)//, ref int index)
        {
            if (_EditForm == null)
                return;

            //Match case##

            int index = 0;
            if (previous)
                SearchPrevious(_Target, _Content, ref index);
            else
                SearchNext(_Target, _Content, ref index);

            if (index != -1)
                _markTargetHandler(index, _Target.Length);
            else
                MessageBox.Show("Cannot find \"" + _Target + "\"", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SearchPrevious(string target, string content, ref int searchIndex)
        {
            searchIndex = content.LastIndexOf(target, _StartIndex);
            if (searchIndex == -1)
                return;

            _StartIndex = searchIndex - 1;
            //if (checkBox_WrapAround.Checked)##
            //{
            //    if (content.LastIndexOf(target, _StartIndex) == -1)
            //        _StartIndex = content.Length;
            //}
        }

        public static void SearchNext(string target, string content, ref int searchIndex)
        {
            searchIndex = content.IndexOf(target, _StartIndex);
            if (searchIndex == -1)
                return;

            _StartIndex = searchIndex + 1;
            //if (checkBox_WrapAround.Checked)##
            //{
            //    if (content.IndexOf(target, _StartIndex) == -1)
            //        _StartIndex = 0;
            //}
        }
    }
}
