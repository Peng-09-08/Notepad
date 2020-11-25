using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad.SubForm
{
    public partial class GoToForm : Form
    {
        private static int _lineNumber;

        public delegate void GoToLineDelegate(int line);
        private static GoToLineDelegate _GoToLineHandler;

        public static void RegisterGoToLineDelegate(GoToLineDelegate func)
        {
            _GoToLineHandler = func;
        }

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
