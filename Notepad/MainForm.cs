using System;
using System.Windows.Forms;
using System.IO;
using Notepad.Edit;
using Notepad.Format;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;

namespace Notepad
{
    public partial class MainForm : Form
    {
        private string _filePath = "Untitled";
        private bool _modify = false;

        private bool _push = true;
        private Stack<KeyValuePair<int, string>> _redo = new Stack<KeyValuePair<int, string>>();
        private Stack<KeyValuePair<int, string>> _undo = new Stack<KeyValuePair<int, string>>();

        public MainForm()
        {
            InitializeComponent();
            CommonFunction.RegisterMarkTargetDelegate(MarkTargetLine);
            ReplaceForm.RegisterReplaceTargetDelegate(ReplaceTarget);
            GoToForm.RegisterGoToLineDelegate(GoToLine);
            EncryptForm.RegisterEncryptDelegate(EncryptText);
            FontForm.RegisterFontDelegate(ChangeFont);
            ColorForm.RegisterColorDelegate(ChangeColor);

            ContextMenuStrip cms = new ContextMenuStrip();

            ToolStripMenuItem undo = new ToolStripMenuItem("Undo");
            undo.Name = undo.Text;
            undo.Click += new EventHandler(toolStrip_Undo_Click);
            cms.Items.Add(undo);
            ToolStripMenuItem redo = new ToolStripMenuItem("Redo");
            redo.Name = redo.Text;
            redo.Click += new EventHandler(toolStrip_Redo_Click);
            cms.Items.Add(redo);
            cms.Items.Add(new ToolStripSeparator());

            ToolStripMenuItem cut = new ToolStripMenuItem("Cut");
            cut.Name = cut.Text;
            cut.Click += new EventHandler(toolStrip_Cut_Click);
            cms.Items.Add(cut);
            ToolStripMenuItem copy = new ToolStripMenuItem("Copy");
            copy.Name = copy.Text;
            copy.Click += new EventHandler(toolStrip_Copy_Click);
            cms.Items.Add(copy);
            ToolStripMenuItem paste = new ToolStripMenuItem("Paste");
            paste.Name = paste.Text;
            paste.Click += new EventHandler(toolStrip_Paste_Click);
            cms.Items.Add(paste);
            cms.Items.Add(new ToolStripSeparator());

            ToolStripMenuItem selectAll = new ToolStripMenuItem("Select All");
            selectAll.Name = selectAll.Text;
            selectAll.Click += new EventHandler(toolStrip_SelectAll_Click);
            cms.Items.Add(selectAll);

            cms.Opening += new CancelEventHandler(ContextMenuStrip_Opening);
            customRtb.ContextMenuStrip = cms;
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
                if (UseEditForm._EditForm is ReplaceForm)
                {
                    if (e.KeyCode == Keys.R)
                        (UseEditForm._EditForm as ReplaceForm).btn_Replace_Click(null, null);
                    else if (e.KeyCode == Keys.A)
                        (UseEditForm._EditForm as ReplaceForm).btn_ReplaceAll_Click(null, null);
                }
            }
            else if (e.Modifiers == Keys.Control)
            {
                bool nonSelection = customRtb.SelectedText == "";
                if (e.KeyCode == Keys.B)
                {
                    bool enable = nonSelection ? customRtb.Font.Bold : customRtb.SelectionFont.Bold;
                    MakeStyle(nonSelection, FontStyle.Bold, enable);
                }
                else if (e.KeyCode == Keys.I)
                {
                    bool enable = nonSelection ? customRtb.Font.Italic : customRtb.SelectionFont.Italic;
                    MakeStyle(nonSelection, FontStyle.Italic, enable);
                }
                else if (e.KeyCode == Keys.U)
                {
                    bool enable = nonSelection ? customRtb.Font.Underline : customRtb.SelectionFont.Underline;
                    MakeStyle(nonSelection, FontStyle.Underline, enable);
                }
            }
            else
            {
                if (e.KeyCode == Keys.F3)
                    CommonFunction.SearchTarget(e.Modifiers == Keys.Shift);
                else if (e.KeyCode == Keys.Escape)
                    customRtb.DeselectAll();
            }
        }

        #region == CustomRichTextBox Event ==

        private void customRtb_Click(object sender, EventArgs e)
        {
            //Get Row
            int selection = customRtb.SelectionStart;
            int row = customRtb.GetLineFromCharIndex(selection);

            //Get Column
            int firstChar = customRtb.GetFirstCharIndexFromLine(row);
            int column = selection - firstChar;

            toolStripStatusLabel_Location.Text = string.Format("Row {0}，Col {1}", row + 1, column + 1);

            CommonFunction._StartIndex = selection;
            ReplaceForm.SetSelectedString = customRtb.SelectedText;
        }

        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip cms = sender as ContextMenuStrip;
            cms.Items["Undo"].Enabled = customRtb.CanUndo;
            cms.Items["Redo"].Enabled = customRtb.CanRedo;
            cms.Items["Cut"].Enabled = cms.Items["Copy"].Enabled = customRtb.SelectionLength > 0;
            cms.Items["Paste"].Enabled = Clipboard.ContainsText();
            cms.Items["Select All"].Enabled = true;
        }

        private void customRtb_TextChanged(object sender, EventArgs e)
        {
            if (_push)
                _undo.Push(new KeyValuePair<int, string>(customRtb.SelectionStart, customRtb.PreviousText));

            CommonFunction._Content = customRtb.Text;
            GoToForm.SetLineNumber = customRtb.Text.Split('\n').Length;

            _modify = true;
            if (!Text.StartsWith("*"))
                Text = Text.Insert(0, "*");
        }

        #endregion

        #region == ToolStripMenuItem Event ==
        #region -- File(F) --

        private void toolStrip_New_Click(object sender, EventArgs e)
        {
            if (CheckModify() == DialogResult.Cancel)
                return;

            customRtb.Text = "";
            _filePath = "Untitled";

            _push = true;
            _modify = false;
            _redo.Clear();
            _undo.Clear();

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
                customRtb.SelectionStart = 0;
                customRtb.Text = "";

                using (StreamReader reader = new StreamReader(ofd.FileName))
                    customRtb.Text = reader.ReadToEnd();

                _push = true;
                _modify = false;
                _redo.Clear();
                _undo.Clear();

                Text = Path.GetFileNameWithoutExtension(_filePath) + " - Notepad";
            }
        }

        private void toolStrip_Save_Click(object sender, EventArgs e)
        {
            if (_filePath == "")
                return;

            using (StreamWriter writer = new StreamWriter(_filePath, false))
                writer.Write(customRtb.Text);

            _push = true;
            _modify = false;
            Text = Path.GetFileNameWithoutExtension(_filePath) + " - Notepad";
        }

        private void toolStrip_SaveAs_Click(object sender, EventArgs e)
        {
            if (customRtb.Text == "")
                return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text File|*.txt|All Files|*.*";
                sfd.Title = "Save File";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                _filePath = sfd.FileName;
                using (StreamWriter writer = new StreamWriter(sfd.FileName, false))
                    writer.Write(customRtb.Text);

                _push = true;
                _modify = false;
                Text = Path.GetFileNameWithoutExtension(_filePath) + " - Notepad";
            }
        }

        private void toolStrip_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region -- Edit(E) --

        private void toolStrip_Undo_Click(object sender, EventArgs e) //Ctrl + Z
        {
            //if (_undo.Count == 0)
            //    return;

            //_redo.Push(new KeyValuePair<int, string>(customRtb.SelectionStart, customRtb.Text));
            //_push = false;

            //KeyValuePair<int, string> temp = _undo.Pop();
            //customRtb.Text = temp.Value;
            //customRtb.SelectionStart = temp.Key;

            //if (_undo.Count == 0)
            //{
            //    _modify = false;
            //    Text = Path.GetFileNameWithoutExtension(_filePath) + " - Notepad";
            //}

            customRtb.Undo();
        }

        private void toolStrip_Redo_Click(object sender, EventArgs e) //Ctrl + Y
        {
            //if (_redo.Count == 0)
            //    return;

            //_undo.Push(new KeyValuePair<int, string>(customRtb.SelectionStart, customRtb.Text));
            //_push = false;

            //KeyValuePair<int, string> temp = _redo.Pop();
            //customRtb.Text = temp.Value;
            //customRtb.SelectionStart = temp.Key;

            customRtb.Redo();
        }

        private void toolStrip_Cut_Click(object sender, EventArgs e)
        {
            if (customRtb.SelectedText == "")
                return;

            //_push = true;
            //Clipboard.SetText(customRtb.SelectedText);
            //int start = customRtb.SelectionStart;
            //customRtb.Text = customRtb.Text.Remove(customRtb.SelectionStart, customRtb.SelectedText.Length);
            //customRtb.SelectionStart = start + customRtb.SelectedText.Length;

            customRtb.Cut();
        }

        private void toolStrip_Copy_Click(object sender, EventArgs e)
        {
            if (customRtb.SelectedText == "")
                return;

            Clipboard.SetText(customRtb.SelectedText);
        }

        private void toolStrip_Paste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() == "")
                return;

            //string copy = Clipboard.GetText();
            //bool newLine = copy.Contains("\n");

            //_push = true;
            //int start = customRtb.SelectionStart;
            //customRtb.Text = customRtb.Text.Insert(customRtb.SelectionStart, copy);
            //customRtb.SelectionStart = newLine ? start + copy.Length - 2 : start + copy.Length;

            customRtb.Paste();
        }

        private void toolStrip_SelectAll_Click(object sender, EventArgs e)
        {
            customRtb.SelectAll();
        }

        private void toolStrip_Form_Click(object sender, EventArgs e)
        {
            string name = (sender as ToolStripMenuItem).Name.Split('_')[1];
            object obj = "";
            if (name == "Search" || name == "Replace")
                obj = customRtb.SelectionStart;
            else if (name == "GoTo")
                obj = customRtb.Text.Split('\n').Length;
            else if (name == "Encrypt")
                obj = customRtb.Text;

            Type type = Type.GetType("Notepad.SubForm." + name + "Form");
            if (type != null)
                UseEditForm.Edit(this, type, obj);
        }

        #endregion

        #region -- Format --

        private void toolStrip_Font_Click(object sender, EventArgs e)
        {
            customRtb.TextChanged -= new EventHandler(customRtb_TextChanged);

            //-----FontForm-----//
            FontForm fontForm = new FontForm(customRtb.Font.FontFamily, customRtb.Font.Size, customRtb.Font.Style)
            {
                Owner = this,
                Location = new Point(Location.X + 250, Location.Y + 50),
            };

            fontForm.ShowDialog();
            //-----//

            //-----FontDialog-----//
            //bool nonSelection = customRtb.SelectedText == "";
            //fontDialog1.Font = nonSelection ? customRtb.Font : customRtb.SelectionFont;

            //if (fontDialog1.ShowDialog() == DialogResult.Cancel)
            //    return;

            //if (nonSelection)
            //    customRtb.Font = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
            //else
            //    customRtb.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
            //-----//

            customRtb.TextChanged += new EventHandler(customRtb_TextChanged);
        }

        private void toolStrip_ForeColor_Click(object sender, EventArgs e)
        {
            customRtb.TextChanged -= new EventHandler(customRtb_TextChanged);

            bool nonSelection = customRtb.SelectedText == "";
            Color fore = nonSelection ? customRtb.ForeColor : customRtb.SelectionColor;

            //-----ColorForm-----// //ForeColor + BackColor
            //Color back = nonSelection ? customRtb.BackColor : customRtb.SelectionBackColor;
            //ColorForm colorForm = new ColorForm(fore, back)
            //{
            //    Owner = this,
            //    Location = new Point(Location.X + 250, Location.Y + 50),
            //};

            //colorForm.ShowDialog();
            //-----//

            //-----ColorDialog-----//
            colorDialog1.Color = fore;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            if (nonSelection)
                customRtb.ForeColor = colorDialog1.Color;
            else
                customRtb.SelectionColor = colorDialog1.Color;
            //-----//

            customRtb.TextChanged += new EventHandler(customRtb_TextChanged);
        }

        private void toolStrip_BackColor_Click(object sender, EventArgs e)
        {
            customRtb.TextChanged -= new EventHandler(customRtb_TextChanged);

            bool nonSelection = customRtb.SelectedText == "";
            Color back = nonSelection ? customRtb.BackColor : customRtb.SelectionBackColor;
            colorDialog1.Color = back;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            if (nonSelection)
                customRtb.BackColor = colorDialog1.Color;
            else
                customRtb.SelectionBackColor = colorDialog1.Color;

            customRtb.TextChanged += new EventHandler(customRtb_TextChanged);
        }

        #endregion

        #region -- View(V) --

        private void toolStrip_Zoom_Click(object sender, EventArgs e)
        {
            if (customRtb.ZoomFactor > 0.01f && customRtb.ZoomFactor < 5.0f)
            {
                string name = (sender as ToolStripMenuItem).Name;
                if (name.Contains("In"))
                    customRtb.ZoomFactor += 0.1f;
                else if (name.Contains("Out"))
                    customRtb.ZoomFactor -= 0.1f;
                else
                    customRtb.ZoomFactor = 1.0f;

                toolStripStatusLabel_Factor.Text = string.Format("{0}%", customRtb.ZoomFactor * 100);
            }
        }

        private void toolStrip_Status_Click(object sender, EventArgs e)
        {
            toolStrip_Status.Checked = !toolStrip_Status.Checked;
            statusStrip1.Visible = toolStrip_Status.Checked;
        }

        #endregion

        #endregion

        #region == Callback Function ==

        private void MarkTargetLine(int index, int length)
        {
            customRtb.Select(index, length);
            customRtb.HideSelection = false;
            ReplaceForm.SetSelectedString = customRtb.SelectedText;
        }

        private void ReplaceTarget(int startIndex, string oldValue, string newValue)
        {
            _push = true;
            if (startIndex == -1)
                customRtb.Text = customRtb.Text.Replace(oldValue, newValue);
            else
                customRtb.Text = ReplaceAt(customRtb.Text, startIndex - 1, oldValue.Length, newValue);
        }

        private string ReplaceAt(string str, int index, int length, string replace)
        {
            //return str.Remove(index, Math.Min(length, str.Length - index)).Insert(index, replace);
            return str.Remove(index, length).Insert(index, replace);
        }

        private void GoToLine(int line)
        {
            int start = customRtb.GetFirstCharIndexFromLine(line);
            customRtb.SelectionStart = start;
            customRtb_Click(null, null);
        }

        private void EncryptText(string value)
        {
            _push = true;
            customRtb.Text = value;
        }

        private void ChangeFont(FontFamily family, float size, FontStyle style)
        {
            if (customRtb.SelectedText == "")
                customRtb.Font = new Font(family, size, style);
            else
                customRtb.SelectionFont = new Font(family, size, style);
        }

        private void ChangeColor(Color foreColor, Color backColor)
        {
            if (customRtb.SelectedText == "")
            {
                customRtb.ForeColor = foreColor;
                customRtb.BackColor = backColor;
            }
            else
            {
                customRtb.SelectionColor = foreColor;
                customRtb.SelectionBackColor = backColor;
            }
        }

        #endregion

        private void MakeStyle(bool nonSelection, FontStyle style, bool enable)
        {
            customRtb.TextChanged -= new EventHandler(customRtb_TextChanged);

            if (nonSelection)
            {
                customRtb.Font = enable ?
                    new Font(customRtb.Font, customRtb.Font.Style & ~style) :
                    new Font(customRtb.Font, customRtb.Font.Style | style);
            }
            else
            {
                customRtb.SelectionFont = enable ?
                    new Font(customRtb.SelectionFont, customRtb.SelectionFont.Style & ~style) :
                    new Font(customRtb.SelectionFont, customRtb.SelectionFont.Style | style);
            }

            customRtb.TextChanged += new EventHandler(customRtb_TextChanged);
        }

        private DialogResult CheckModify()
        {
            if (!_modify)
                return DialogResult.Yes;

            DialogResult result = MessageBox.Show("Do you want to save changes to " + Path.GetFileNameWithoutExtension(_filePath) + "?",
                "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (_filePath == "Untitled")
                    toolStrip_SaveAs_Click(null, null);
                else
                    toolStrip_Save_Click(null, null);
            }

            return result;
        }
    }
}
