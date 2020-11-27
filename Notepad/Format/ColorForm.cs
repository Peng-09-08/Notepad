using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad.Format
{
    public partial class ColorForm : Form
    {
        public delegate void ColorDelegate(Color foreColor, Color backColor);
        private static ColorDelegate _colorHandler;

        public static void RegisterColorDelegate(ColorDelegate func)
        {
            _colorHandler = func;
        }

        public ColorForm(Color foreColor, Color backColor)
        {
            InitializeComponent();
            AcceptButton = btn_OK;
            CancelButton = btn_Cancel;

            pictureBox_ForeColor.BackColor = foreColor;
            pictureBox_BackColor.BackColor = backColor;

            lbl_ForeColor.Text = foreColor.Name;
            lbl_BackColor.Text = backColor.Name;

            KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            foreach (KnownColor color in colors)
            {
                comboBox_ForeColor.Items.Add(color.ToString());
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            _colorHandler(pictureBox_ForeColor.BackColor, pictureBox_BackColor.BackColor);
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string name = (sender as Button).Name.Split('_')[1];
            PictureBox pictureBox = Controls.Find("pictureBox_" + name, true)[0] as PictureBox;
            Label label = Controls.Find("lbl_" + name, true)[0] as Label;

            pictureBox.BackColor = colorDialog1.Color;
            label.Text = colorDialog1.Color.Name;
        }

        private void comboBox_ForeColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            e.DrawBackground();

            Color color = Color.FromName(comboBox.Items[e.Index].ToString());
            string hexColor = "#FF" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");

            e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds);
            e.Graphics.DrawString(hexColor, e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }
    }
}
