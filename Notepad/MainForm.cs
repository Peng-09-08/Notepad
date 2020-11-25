using System;
using System.Windows.Forms;
using System.IO;
using Notepad.SubForm;
using System.Collections.Generic;

namespace Notepad
{
    public partial class MainForm : Form
    {
        private string _filePath = "";
        private bool _modify = false;
        private string _copy = "";
        private Queue _

        public MainForm()
        {
            InitializeComponent();
            CommonFunction.RegisterMarkTargetDelegate(MarkTargetLine);
            ReplaceForm.RegisterReplaceTargetDelegate(ReplaceTarget);
            GoToForm.RegisterGoToLineDelegate(GoToLine);
            EncryptForm.RegisterEncryptDelegate(EncryptText);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckModify() == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt)
            {
                if (UseEditForm._EditForm != null)
                    (UseEditForm._EditForm as ReplaceForm).ReplaceForm_KeyDown(null, e);
            }
            else
            {
                if (e.KeyCode == Keys.F3)
                    CommonFunction.SearchTarget(e.Modifiers == Keys.Shift);
                else if (e.KeyCode == Keys.Escape)
                    richTextBox1.DeselectAll();
            }
        }

        #region == RichTextBox Event ==

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            //Get Row
            int selection = richTextBox1.SelectionStart;
            int row = richTextBox1.GetLineFromCharIndex(selection);

            //Get Column
            int firstChar = richTextBox1.GetFirstCharIndexFromLine(row);
            int column = selection - firstChar;

            toolStripStatusLabel_Location.Text = string.Format("Row {0}，Col {1}", row + 1, column + 1);

            CommonFunction.StartIndex = selection;
            ReplaceForm.SetSelectedString = richTextBox1.SelectedText;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            CommonFunction.SetContent = richTextBox1.Text;
            GoToForm.SetLineNumber = richTextBox1.Text.Split('\n').Length;

            _modify = true;
            if (!Text.StartsWith("*"))
                Text = Text.Insert(0, "*");
        }

        #endregion

        #region == ToolStripMenuItem Event ==
        #region -- File(F) --

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

        private void toolStrip_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region -- Edit(E) --

        private void toolStrip_Undo_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_Redo_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_Cut_Click(object sender, EventArgs e)
        {
            _copy = richTextBox1.SelectedText;

            int start = richTextBox1.SelectionStart;
            richTextBox1.Text = richTextBox1.Text.Remove(start, _copy.Length);
            richTextBox1.SelectionStart = start + _copy.Length;
        }

        private void toolStrip_Copy_Click(object sender, EventArgs e)
        {
            _copy = richTextBox1.SelectedText;
        }

        private void toolStrip_Paste_Click(object sender, EventArgs e)
        {
            if (_copy == "")
                return;

            int start = richTextBox1.SelectionStart;
            richTextBox1.Text = richTextBox1.Text.Insert(start, _copy);
            richTextBox1.SelectionStart = start + _copy.Length;
        }

        private void toolStrip_Find_Click(object sender, EventArgs e)
        {
            UseEditForm.Edit(this, typeof(SearchForm), richTextBox1.SelectionStart);
        }

        private void toolStrip_Replace_Click(object sender, EventArgs e)
        {
            UseEditForm.Edit(this, typeof(ReplaceForm), richTextBox1.SelectionStart);
        }

        private void toolStrip_Goto_Click(object sender, EventArgs e)
        {
            UseEditForm.Edit(this, typeof(GoToForm), richTextBox1.Text.Split('\n').Length);
        }

        private void toolStrip_SelectAll_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void toolStrip_Encrypt_Click(object sender, EventArgs e)
        {
            UseEditForm.Edit(this, typeof(EncryptForm), richTextBox1.Text);
        }

        #endregion

        #region -- View(V) --

        private void toolStrip_ZoomIn_Click(object sender, EventArgs e)
        {
        }

        private void toolStrip_ZoomOut_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip_Status_Click(object sender, EventArgs e)
        {
            toolStrip_Status.Checked = !toolStrip_Status.Checked;
            statusStrip1.Visible = toolStrip_Status.Checked;
        }

        #endregion

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

        private void GoToLine(int line)
        {
            int start = richTextBox1.GetFirstCharIndexFromLine(line);
            richTextBox1.SelectionStart = start;
            richTextBox1_Click(null, null);
        }

        private void EncryptText(string value)
        {
            richTextBox1.Text = value;
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
