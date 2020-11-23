using System;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class MainForm : Form
    {
        private string _filePath = "";
        private bool _modify = false;

        public MainForm()
        {
            InitializeComponent();
            CommonFunction.RegisterMarkTargetDelegate(MarkTargetLine);
            ReplaceForm.RegisterReplaceTargetDelegate(ReplaceTarget);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckModify() == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.F:
                        CommonFunction.UseEditForm(this, typeof(SearchForm), richTextBox1.SelectionStart);
                        break;
                    case Keys.H:
                        CommonFunction.UseEditForm(this, typeof(ReplaceForm), richTextBox1.SelectionStart);
                        break;
                    case Keys.N:
                        toolStrip_New_Click(null, null);
                        break;
                    case Keys.O:
                        toolStrip_Open_Click(null, null);
                        break;
                    case Keys.S:
                        toolStrip_Save_Click(null, null);
                        break;
                }
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                toolStrip_SaveAs_Click(null, null);
            }
            else if (e.Modifiers == Keys.Alt)
            {
                (CommonFunction._EditForm as ReplaceForm).ReplaceForm_KeyDown(null, e);
            }
            else
            {
                if (e.KeyCode == Keys.F3)
                    CommonFunction.SearchTarget(e.Modifiers == Keys.Shift);
            }
        }

        #region == RichTextBox Event ==

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            CommonFunction._StartIndex = richTextBox1.SelectionStart;
            ReplaceForm.SetSelectedString = richTextBox1.SelectedText;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 126)
            {
                _modify = true;
                if (!Text.StartsWith("*"))
                    Text = Text.Insert(0, "*");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            CommonFunction.SetContent = richTextBox1.Text;
        }

        #endregion

        #region == ToolStripMenuItem Event ==
        private void toolStrip_New_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _filePath = "";
            _modify = false;
            Text = "Untitled - Notepad";
        }

        private void toolStrip_Open_Click(object sender, EventArgs e)
        {
            if (CheckModify() == DialogResult.Cancel)
                return;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text File|*.txt|All Files|*.*";
                ofd.Title = "Select File";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                _filePath = ofd.FileName;
                richTextBox1.Text = "";

                using (StreamReader reader = new StreamReader(ofd.FileName))
                    richTextBox1.Text = reader.ReadToEnd();

                _modify = false;
                Text = Path.GetFileNameWithoutExtension(ofd.FileName) + " - Notepad";
            }
        }

        private void toolStrip_Save_Click(object sender, EventArgs e)
        {
            if (_filePath == "")
                return;

            using (StreamWriter writer = new StreamWriter(_filePath, false))
                writer.Write(richTextBox1.Text);

            _modify = false;
            Text = Path.GetFileNameWithoutExtension(_filePath) + " - Notepad";
        }

        private void toolStrip_SaveAs_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
                return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text File|*.txt|All Files|*.*";
                sfd.Title = "Save File";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                _filePath = sfd.FileName;
                using (StreamWriter writer = new StreamWriter(sfd.FileName, false))
                    writer.Write(richTextBox1.Text);

                _modify = false;
                Text = Path.GetFileNameWithoutExtension(sfd.FileName) + " - Notepad";
            }
        }

        private void toolStrip_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStrip_Find_Click(object sender, EventArgs e)
        {
            CommonFunction.UseEditForm(this, typeof(SearchForm), richTextBox1.SelectionStart);
        }

        private void toolStrip_Replace_Click(object sender, EventArgs e)
        {
            CommonFunction.UseEditForm(this, typeof(ReplaceForm), richTextBox1.SelectionStart);
        }

        #endregion

        private void MarkTargetLine(int index, int length)
        {
            richTextBox1.Select(index, length);
            richTextBox1.HideSelection = false;
            ReplaceForm.SetSelectedString = richTextBox1.SelectedText;
        }

        private void ReplaceTarget(int startIndex, string oldValue, string newValue)
        {
            if (startIndex == -1)
                richTextBox1.Text = richTextBox1.Text.Replace(oldValue, newValue);
            else
                richTextBox1.Text = ReplaceAt(richTextBox1.Text, startIndex - 1, oldValue.Length, newValue);

            _modify = true;
            if (!Text.StartsWith("*"))
                Text = "*" + Path.GetFileNameWithoutExtension(_filePath) + " - Notepad";
        }

        private DialogResult CheckModify()
        {
            if (!_modify)
                return DialogResult.Yes;

            DialogResult result = MessageBox.Show("Do you want to save changes to " + Path.GetFileNameWithoutExtension(_filePath) + "?",
                "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                toolStrip_Save_Click(null, null);

            return result;
        }

        private string ReplaceAt(string str, int index, int length, string replace)
        {
            return str.Remove(index, Math.Min(length, str.Length - index)).Insert(index, replace);
        }
    }
}
