using System;
using System.Windows.Forms;
using System.Drawing;

namespace Notepad.Edit
{
    public class CommonFunction
    {
        public static string _Content = "";
        public static int _StartIndex = -1;
        public static string _Target = "";

        private static bool _MatchCase = false;
        private static bool _WrapAround = false;

        public delegate void MarkTargetDelegate(int index, int length);
        private static MarkTargetDelegate _markTargetHandler;

        public static void RegisterMarkTargetDelegate(MarkTargetDelegate func)
        {
            _markTargetHandler = func;
        }

        public static void RemoveMarkTargetDelegate()
        {
            _markTargetHandler = null;
        }

        public static bool SetMatchCase
        {
            set { _MatchCase = value; }
        }

        public static bool SetWrapAround
        {
            set { _WrapAround = value; }
        }

        public static void SwitchForm(Form owner, Keys key)
        {
            switch (key)
            {
                case Keys.F:
                    UseEditForm.Edit(owner, typeof(SearchForm), _StartIndex);
                    break;
                case Keys.G:
                    UseEditForm.Edit(owner, typeof(GoToForm), _Content.Split('\n').Length);
                    break;
                case Keys.H:
                    UseEditForm.Edit(owner, typeof(ReplaceForm), _StartIndex);
                    break;
                case Keys.P:
                    UseEditForm.Edit(owner, typeof(EncryptForm), _Content);
                    break;
            }
        }

        public static void SearchTarget(bool previous)
        {
            if (UseEditForm._EditForm == null)
                return;

            string tempTarget = _MatchCase ? _Target : _Target.ToUpper();
            string tempContent = _MatchCase ? _Content : _Content.ToUpper();

            int index = 0;
            if (previous)
                SearchPrevious(tempTarget, tempContent, ref index);
            else
                SearchNext(tempTarget, tempContent, ref index);

            if (index != -1)
                _markTargetHandler(index, tempTarget.Length);
            else
                MessageBox.Show("Cannot find \"" + _Target + "\"", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SearchPrevious(string target, string content, ref int searchIndex)
        {
            searchIndex = content.LastIndexOf(target, _StartIndex);
            if (searchIndex == -1)
                return;

            _StartIndex = searchIndex - 1;
            if (_WrapAround)
            {
                if (content.LastIndexOf(target, _StartIndex) == -1)
                    _StartIndex = content.Length;
            }
        }

        public static void SearchNext(string target, string content, ref int searchIndex)
        {
            searchIndex = content.IndexOf(target, _StartIndex);
            if (searchIndex == -1)
                return;

            _StartIndex = searchIndex + 1;
            if (_WrapAround)
            {
                if (content.IndexOf(target, _StartIndex) == -1)
                    _StartIndex = 0;
            }
        }
    }
}
