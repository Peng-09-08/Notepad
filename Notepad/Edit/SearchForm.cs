using System;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad.Edit
{
    public partial class SearchForm : Form
    {
        //Reference: 
        //https://stackoverflow.com/questions/29389384/linq-dynamic-condition
        //https://stackoverflow.com/questions/445984/convert-anonymous-type-to-class

        public SearchForm()
        {
            InitializeComponent();
            AcceptButton = btn_Search;
            CancelButton = btn_Cancel;
        }

        private void SearchForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
                CommonFunction.SwitchForm(Owner, e.KeyCode);
            else if (e.KeyCode == Keys.F3)
                CommonFunction.SearchTarget(e.Modifiers == Keys.Shift);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //txt_Target.Focus(); //避免按鈕邊框變厚
            CommonFunction.SearchTarget(radioBtn_Previous.Checked);
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
            btn_Search.Enabled = txt_Target.Text != "";
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

        private void radioBtn_Next_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_Next.Checked)
                CommonFunction._StartIndex += CommonFunction._Target.Length;
        }

        //private Dictionary<string, Func<int, bool>> _criteriaIndex = new Dictionary<string, Func<int, bool>>();
        //private Dictionary<string, Func<string, bool>> _criteriaValue = new Dictionary<string, Func<string, bool>>();
        //private dynamic DynamicCondition()
        //{
        //    _criteriaIndex.Clear();
        //    _criteriaIndex.Add("Condition1", x => x > _StartIndex);
        //    _criteriaIndex.Add("Condition2", x => x < _StartIndex);

        //    _criteriaValue.Clear();
        //    _criteriaValue.Add("Condition1", x => x.Contains(txt_Target.Text));
        //    _criteriaValue.Add("Condition2", x => x.ToUpper().Contains(txt_Target.Text.ToUpper()));

        //    dynamic temp = DynamicCondition();
        //    dynamic result;
        //    string item1 = radioBtn_Next.Checked ? "1" : "2";
        //    string item2 = checkBox_IgnoreCase.Checked ? "1" : "2";

        //    result = _Content.Split('\n').Select((v, i) => new { Index = i, Value = v })
        //        .Where(p => _criteriaIndex["Condition" + item1](p.Index) &&
        //                    _criteriaValue["Condition" + item2](p.Value)).ToList();

        //    return result;
        //}
    }
}
