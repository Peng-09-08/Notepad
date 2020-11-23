using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class ReplaceForm : Form
    {
        private static string _SelectedContent = "";

        public delegate void ReplaceTargetDelegate(int startIndex, string oldValue, string newValue);
        private static ReplaceTargetDelegate _replaceTargetHandler;

        public static void RegisterReplaceTargetDelegate(ReplaceTargetDelegate func)
        {
            _replaceTargetHandler = func;
        }

        public static void RemoveReplaceTargetDelegate()
        {
            _replaceTargetHandler = null;
        }

        public static string SetSelectedString
        {
            set { _SelectedContent = value; }
        }

        public ReplaceForm()
        {
            InitializeComponent();
            CancelButton = btn_Cancel;
        }

        public void ReplaceForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.F)
                    CommonFunction.UseEditForm(Owner, typeof(SearchForm), 0);
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
            txt_Target.Focus(); //避免按鈕邊框變厚
            CommonFunction.SearchTarget(false);
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            txt_Target.Focus(); //避免按鈕邊框變厚
            if (_SelectedContent == txt_Target.Text)
                _replaceTargetHandler(CommonFunction._StartIndex, _SelectedContent, txt_Replace.Text);

            CommonFunction.SearchTarget(false);
        }

        private void btn_ReplaceAll_Click(object sender, EventArgs e)
        {
            txt_Target.Focus(); //避免按鈕邊框變厚
            _replaceTargetHandler(-1, txt_Target.Text, txt_Replace.Text);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
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
            CommonFunction.SetTarget = txt_Target.Text;
        }
    }
}
