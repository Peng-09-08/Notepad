using System;
using System.Drawing;
using System.Windows.Forms;
//using System.Windows;
//using FontStyle = System.Drawing.FontStyle;

namespace Notepad.Format
{
    public partial class FontForm : Form
    {
        //Reference
        //https://dotblogs.com.tw/yc421206/2011/12/19/62615

        public delegate void FontDelegate(FontFamily font, float size, FontStyle style);
        private static FontDelegate _fontHandler;

        public static void RegisterFontDelegate(FontDelegate func)
        {
            _fontHandler = func;
        }

        private FontFamily _fontFamily;
        private FontStyle _fontStyle;
        private float _fontSize;

        public FontForm(FontFamily family, float size, FontStyle style)
        {
            InitializeComponent();
            AcceptButton = btn_OK;
            CancelButton = btn_Cancel;

            FontFamily[] fontArr = FontFamily.Families;
            foreach (FontFamily font in fontArr)
                listBox_Font.Items.Add(font.Name);

            listBox_Font.SelectedItem = family.Name;
            listBox_Style.SelectedItem = style.ToString();
            listBox_Size.SelectedItem = size.ToString();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            FontStyle temp = _fontStyle;
            if (checkBox_Strikeout.Checked)
                temp |= FontStyle.Strikeout;
            if (checkBox_Underline.Checked)
                temp |= FontStyle.Underline;

            _fontHandler(_fontFamily, _fontSize, _fontStyle);
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (listBox.Items.Count == 0)
                return;

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(Color.PaleGreen), e.Bounds);

            string family = listBox.Name.Contains("Font") ? listBox.Items[e.Index].ToString() : e.Font.Name;
            FontStyle style = FontStyle.Regular;
            float size = 12f;

            if (listBox.Name.Contains("Style"))
            {
                foreach (string str in listBox.Items[e.Index].ToString().Split(' '))
                    style |= (FontStyle)Enum.Parse(typeof(FontStyle), str);
            }

            e.Graphics.DrawString(listBox.Items[e.Index].ToString(),
                new Font(family, size, style),
                    Brushes.Black, e.Bounds, StringFormat.GenericDefault);

            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Font.SelectedItem == null || listBox_Style.SelectedItem == null || listBox_Size.SelectedItem == null)
                return;

            txt_Font.Text = listBox_Font.SelectedItem.ToString();
            _fontFamily = new FontFamily(txt_Font.Text);

            txt_Style.Text = listBox_Style.SelectedItem.ToString();
            _fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), txt_Style.Text);

            txt_Size.Text = listBox_Size.SelectedItem.ToString();
            _fontSize = float.Parse(txt_Size.Text);

            lbl_Sample.Font = new Font(_fontFamily, _fontSize, _fontStyle);
            lbl_Sample.Location = new Point(groupBox2.Width / 2 - lbl_Sample.Width / 2,
                groupBox2.Height / 2 - lbl_Sample.Height / 2 + 3);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle temp = _fontStyle;
            if (checkBox_Strikeout.Checked)
                temp |= FontStyle.Strikeout;

            if (checkBox_Underline.Checked)
                temp |= FontStyle.Underline;

            lbl_Sample.Font = new Font(_fontFamily, _fontSize, _fontStyle | temp);
        }
    }
}
