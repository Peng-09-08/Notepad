using System;
using System.Windows.Forms;

namespace Notepad.Edit
{
    public partial class GoToForm : Form
    {
        public delegate void GoToLineDelegate(int line);
        private static GoToLineDelegate _GoToLineHandler;

        public static void RegisterGoToLineDelegate(GoToLineDelegate func)
        {
            _GoToLineHandler = func;
        }

        private static int _lineNumber;

        public static int SetLineNumber
        {
            set { _lineNumber = value; }
        }

        public GoToForm()
        {
            InitializeComponent();
            AcceptButton = btn_GoTo;
            CancelButton = btn_Cancel;
        }

        private void GoToForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
                CommonFunction.SwitchForm(Owner, e.KeyCode);
        }

        private void btn_GoTo_Click(object sender, EventArgs e)
        {
            if (txt_LineNumber.Text == "")
                return;

            int line = Convert.ToInt32(txt_LineNumber.Text);
            if (line > _lineNumber || line == 0)
            {
                MessageBox.Show("Line number is out of range", "Notepad - GoTo", MessageBoxButtons.OK);
                return;
            }

            _GoToLineHandler(line - 1);
            UseEditForm.CloseForm();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            UseEditForm.CloseForm();
        }
    }
}
