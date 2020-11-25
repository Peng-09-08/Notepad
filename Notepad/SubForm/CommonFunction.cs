using System;
using System.Windows.Forms;
using System.Drawing;

namespace Notepad.SubForm
{
    public class CommonFunction
    {
        private static string _Content = "";
        private static int _StartIndex = -1;
        private static string _Target = "";

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

        public static string SetContent
        {
            set { _Content = value; }
        }

        public static int StartIndex
        {
            set { _StartIndex = value; }
            get { return _StartIndex; }
        }

        public static string Target
        {
            set { _Target = value; }
            get { return _Target; }
        }

        public static bool SetMatchCase
        {
            set { _MatchCase = value; }
        }

        public static bool SetWrapAround
        {
            set { _WrapAround = value; }
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
