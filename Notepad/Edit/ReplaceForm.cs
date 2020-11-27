using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad.Edit
{
    public partial class ReplaceForm : Form
    {
        public delegate void ReplaceTargetDelegate(int startIndex, string oldValue, string newValue);
        private static ReplaceTargetDelegate _replaceTargetHandler;

        public static void RegisterReplaceTargetDelegate(ReplaceTargetDelegate func)
        {
            _replaceTargetHandler = func;
        }

        private static string _SelectedContent = "";

        public static string SetSelectedString
        {
            set { _SelectedContent = value; }
        }

        public ReplaceForm()
        {
            InitializeComponent();
            CancelButton = btn_Cancel;
        }

        private void ReplaceForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                CommonFunction.SwitchForm(Owner, e.KeyCode);

                //if (e.KeyCode == Keys.F)
                //UseEditForm.Edit(Owner, typeof(SearchForm), CommonFunction._StartIndex);
                //else if (e.KeyCode == Keys.G)
                //    UseEditForm.Edit(Owner, typeof(GoToForm), CommonFunction._Content.Split('\n').Length);
                //else if (e.KeyCode == Keys.P)
                //    UseEditForm.Edit(Owner, typeof(EncryptForm), CommonFunction._Content);
            }
            else if (e.Modifiers == Keys.Alt)
            {
                if (e.KeyCode == Keys.R)
                    btn_Replace_Click(null, null);
                else if (e.KeyCode == Keys.A)
                    btn_ReplaceAll_Click(null, null);
            }
            else if (e.KeyCode == Keys.F3)
                CommonFunction.SearchTarget(e.Modifiers == Keys.Shift);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //txt_Target.Focus(); //避免按鈕邊框變厚
            CommonFunction.SearchTarget(false);
        }

        public void btn_Replace_Click(object sender, EventArgs e)
        {
            //txt_Target.Focus(); //避免按鈕邊框變厚
            if (_SelectedContent == txt_Target.Text)
                _replaceTargetHandler(CommonFunction._StartIndex, _SelectedContent, txt_Replace.Text);

            CommonFunction.SearchTarget(false);
        }

        public void btn_ReplaceAll_Click(object sender, EventArgs e)
        {
            //txt_Target.Focus(); //避免按鈕邊框變厚
            _replaceTargetHandler(-1, txt_Target.Text, txt_Replace.Text);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            UseEditForm.CloseForm();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).FlatAppearance.BorderColor = Color.MediumBlue;
            (sender as Button).FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            (sender as Button).FlatAppearance.MouseOverBackColor = SystemColors.Control;
        }

        private void txt_Target_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = btn_Replace.Enabled = btn_ReplaceAll.Enabled = txt_Target.Text != "";
            CommonFunction._Target = txt_Target.Text;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Text.Contains("Match"))
                CommonFunction.SetMatchCase = checkBox.Checked;
            else
                CommonFunction.SetWrapAround = checkBox.Checked;
        }
    }
}
