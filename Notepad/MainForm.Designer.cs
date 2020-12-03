
namespace Notepad
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_GoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Encrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_ForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_BackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_ZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_ZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_DefaultZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Location = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Factor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customRtb = new Notepad.CustomRichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStrip_Format,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(664, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_New,
            this.toolStrip_Open,
            this.toolStrip_Save,
            this.toolStrip_SaveAs,
            this.toolStripMenuItem4,
            this.toolStrip_Exit});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.optionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(76, 30);
            this.optionToolStripMenuItem.Text = "File(&F)";
            // 
            // toolStrip_New
            // 
            this.toolStrip_New.Image = global::Notepad.Properties.Resources.New;
            this.toolStrip_New.Name = "toolStrip_New";
            this.toolStrip_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStrip_New.ShowShortcutKeys = false;
            this.toolStrip_New.Size = new System.Drawing.Size(300, 22);
            this.toolStrip_New.Text = "New          Ctrl + N";
            this.toolStrip_New.Click += new System.EventHandler(this.toolStrip_New_Click);
            // 
            // toolStrip_Open
            // 
            this.toolStrip_Open.Image = global::Notepad.Properties.Resources.Open;
            this.toolStrip_Open.Name = "toolStrip_Open";
            this.toolStrip_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStrip_Open.ShowShortcutKeys = false;
            this.toolStrip_Open.Size = new System.Drawing.Size(300, 22);
            this.toolStrip_Open.Text = "Open         Ctrl + O";
            this.toolStrip_Open.Click += new System.EventHandler(this.toolStrip_Open_Click);
            // 
            // toolStrip_Save
            // 
            this.toolStrip_Save.Image = global::Notepad.Properties.Resources.Save;
            this.toolStrip_Save.Name = "toolStrip_Save";
            this.toolStrip_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStrip_Save.ShowShortcutKeys = false;
            this.toolStrip_Save.Size = new System.Drawing.Size(300, 22);
            this.toolStrip_Save.Text = "Save         Ctrl + S";
            this.toolStrip_Save.Click += new System.EventHandler(this.toolStrip_Save_Click);
            // 
            // toolStrip_SaveAs
            // 
            this.toolStrip_SaveAs.Image = global::Notepad.Properties.Resources.Save_As;
            this.toolStrip_SaveAs.Name = "toolStrip_SaveAs";
            this.toolStrip_SaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.toolStrip_SaveAs.ShowShortcutKeys = false;
            this.toolStrip_SaveAs.Size = new System.Drawing.Size(300, 22);
            this.toolStrip_SaveAs.Text = "Save As      Ctrl + Shift + S";
            this.toolStrip_SaveAs.Click += new System.EventHandler(this.toolStrip_SaveAs_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(297, 6);
            // 
            // toolStrip_Exit
            // 
            this.toolStrip_Exit.Image = global::Notepad.Properties.Resources.Exit;
            this.toolStrip_Exit.Name = "toolStrip_Exit";
            this.toolStrip_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStrip_Exit.ShowShortcutKeys = false;
            this.toolStrip_Exit.Size = new System.Drawing.Size(300, 22);
            this.toolStrip_Exit.Text = "Exit         Alt + F4";
            this.toolStrip_Exit.Click += new System.EventHandler(this.toolStrip_Exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Undo,
            this.toolStrip_Redo,
            this.toolStripMenuItem1,
            this.toolStrip_Cut,
            this.toolStrip_Copy,
            this.toolStrip_Paste,
            this.toolStrip_SelectAll,
            this.toolStripMenuItem2,
            this.toolStrip_Search,
            this.toolStrip_Replace,
            this.toolStrip_GoTo,
            this.toolStrip_Encrypt});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(76, 30);
            this.editToolStripMenuItem.Text = "Edit(&E)";
            // 
            // toolStrip_Undo
            // 
            this.toolStrip_Undo.Image = global::Notepad.Properties.Resources.Undo;
            this.toolStrip_Undo.Name = "toolStrip_Undo";
            this.toolStrip_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolStrip_Undo.ShowShortcutKeys = false;
            this.toolStrip_Undo.Size = new System.Drawing.Size(276, 22);
            this.toolStrip_Undo.Text = "Undo              Ctrl + Z";
            this.toolStrip_Undo.Click += new System.EventHandler(this.toolStrip_Undo_Click);
            // 
            // toolStrip_Redo
            // 
            this.toolStrip_Redo.Image = global::Notepad.Properties.Resources.Redo;
            this.toolStrip_Redo.Name = "toolStrip_Redo";
            this.toolStrip_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.toolStrip_Redo.ShowShortcutKeys = false;
            this.toolStrip_Redo.Size = new System.Drawing.Size(276, 22);
            this.toolStrip_Redo.Text = "Redo              Ctrl + Y";
            this.toolStrip_Redo.Click += new System.EventHandler(this.toolStrip_Redo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(273, 6);
            // 
            // toolStrip_Cut
            // 
            this.toolStrip_Cut.Image = global::Notepad.Properties.Resources.Cut;
            this.toolStrip_Cut.Name = "toolStrip_Cut";
            this.toolStrip_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStrip_Cut.ShowShortcutKeys = false;
            this.toolStrip_Cut.Size = new System.Drawing.Size(276, 22);
            this.toolStrip_Cut.Text = "Cut               Ctrl + X";
            this.toolStrip_Cut.Click += new System.EventHandler(this.toolStrip_Cut_Click);
            // 
            // toolStrip_Copy
            // 
            this.toolStrip_Copy.Image = global::Notepad.Properties.Resources.Copy;
            this.toolStrip_Copy.Name = "toolStrip_Copy";
            this.toolStrip_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStrip_Copy.ShowShortcutKeys = false;
            this.toolStrip_Copy.Size = new System.Drawing.Size(276, 22);
            this.toolStrip_Copy.Text = "Copy              Ctrl + C";
            this.toolStrip_Copy.Click += new System.EventHandler(this.toolStrip_Copy_Click);
            // 
            // toolStrip_Paste
            // 
            this.toolStrip_Paste.Image = global::Notepad.Properties.Resources.Paste;
            this.toolStrip_Paste.Name = "toolStrip_Paste";
            this.toolStrip_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolStrip_Paste.ShowShortcutKeys = false;
            this.toolStrip_Paste.Size = new System.Drawing.Size(276, 22);
            this.toolStrip_Paste.Text = "Paste             Ctrl + V";
            this.toolStrip_Paste.Click += new System.EventHandler(this.toolStrip_Paste_Click);
            // 
            // toolStrip_SelectAll
            // 
            this.toolStrip_SelectAll.Image = global::Notepad.Properties.Resources.Select_All;
            this.toolStrip_SelectAll.Name = "toolStrip_SelectAll";
            this.toolStrip_SelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStrip_SelectAll.ShowShortcutKeys = false;
            this.toolStrip_SelectAll.Size = new System.Drawing.Size(276, 22);
            this.toolStrip_SelectAll.Text = "Select All        Ctrl + A";
            this.toolStrip_SelectAll.Click += new System.EventHandler(this.toolStrip_SelectAll_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(273, 6);
            // 
            // toolStrip_Search
            // 
            this.toolStrip_Search.Image = global::Notepad.Properties.Resources.Search;
            this.toolStrip_Search.Name = "toolStrip_Search";
            this.toolStrip_Search.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.toolStrip_Search.ShowShortcutKeys = false;
            this.toolStrip_Search.Size = new System.Drawing.Size(276, 22);
            this.toolStrip_Search.Text = "Search            Ctrl + F";
            this.toolStrip_Search.Click += new System.EventHandler(this.toolStrip_Form_Click);
            // 
            // toolStrip_Replace
            // 
            this.toolStrip_Replace.Image = global::Notepad.Properties.Resources.Replace;
            this.toolStrip_Replace.Name = "toolStrip_Replace";
            this.toolStrip_Replace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.toolStrip_Replace.ShowShortcutKeys = false;
            this.toolStrip_Replace.Size = new System.Drawing.Size(276, 22);
            this.toolStrip_Replace.Text = "Replace           Ctrl + H";
            this.toolStrip_Replace.Click += new System.EventHandler(this.toolStrip_Form_Click);
            // 
            // toolStrip_GoTo
            // 
            this.toolStrip_GoTo.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_GoTo.Image")));
            this.toolStrip_GoTo.Name = "toolStrip_GoTo";
            this.toolStrip_GoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.toolStrip_GoTo.ShowShortcutKeys = false;
            this.toolStrip_GoTo.Size = new System.Drawing.Size(276, 22);
            this.toolStrip_GoTo.Text = "Go To             Ctrl + G";
            this.toolStrip_GoTo.Click += new System.EventHandler(this.toolStrip_Form_Click);
            // 
            // toolStrip_Encrypt
            // 
            this.toolStrip_Encrypt.Image = global::Notepad.Properties.Resources.Encrypt;
            this.toolStrip_Encrypt.Name = "toolStrip_Encrypt";
            this.toolStrip_Encrypt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.toolStrip_Encrypt.ShowShortcutKeys = false;
            this.toolStrip_Encrypt.Size = new System.Drawing.Size(276, 22);
            this.toolStrip_Encrypt.Text = "Encrypt/Decrypt   Ctrl + P";
            this.toolStrip_Encrypt.Click += new System.EventHandler(this.toolStrip_Form_Click);
            // 
            // toolStrip_Format
            // 
            this.toolStrip_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Font,
            this.toolStrip_ForeColor,
            this.toolStrip_BackColor});
            this.toolStrip_Format.Name = "toolStrip_Format";
            this.toolStrip_Format.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.toolStrip_Format.ShowShortcutKeys = false;
            this.toolStrip_Format.Size = new System.Drawing.Size(92, 30);
            this.toolStrip_Format.Text = "Format(&O)";
            // 
            // toolStrip_Font
            // 
            this.toolStrip_Font.Image = global::Notepad.Properties.Resources.Font;
            this.toolStrip_Font.Name = "toolStrip_Font";
            this.toolStrip_Font.ShowShortcutKeys = false;
            this.toolStrip_Font.Size = new System.Drawing.Size(148, 22);
            this.toolStrip_Font.Text = "Font";
            this.toolStrip_Font.Click += new System.EventHandler(this.toolStrip_Font_Click);
            // 
            // toolStrip_ForeColor
            // 
            this.toolStrip_ForeColor.Image = global::Notepad.Properties.Resources.Color;
            this.toolStrip_ForeColor.Name = "toolStrip_ForeColor";
            this.toolStrip_ForeColor.Size = new System.Drawing.Size(148, 22);
            this.toolStrip_ForeColor.Text = "ForeColor";
            this.toolStrip_ForeColor.Click += new System.EventHandler(this.toolStrip_ForeColor_Click);
            // 
            // toolStrip_BackColor
            // 
            this.toolStrip_BackColor.Image = global::Notepad.Properties.Resources.Fill;
            this.toolStrip_BackColor.Name = "toolStrip_BackColor";
            this.toolStrip_BackColor.Size = new System.Drawing.Size(148, 22);
            this.toolStrip_BackColor.Text = "BackColor";
            this.toolStrip_BackColor.Click += new System.EventHandler(this.toolStrip_BackColor_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.toolStrip_Status});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(76, 30);
            this.viewToolStripMenuItem.Text = "View(&V)";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_ZoomIn,
            this.toolStrip_ZoomOut,
            this.toolStrip_DefaultZoom});
            this.zoomToolStripMenuItem.Image = global::Notepad.Properties.Resources.Zoom;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.ShowShortcutKeys = false;
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // toolStrip_ZoomIn
            // 
            this.toolStrip_ZoomIn.Image = global::Notepad.Properties.Resources.Zoom_In;
            this.toolStrip_ZoomIn.Name = "toolStrip_ZoomIn";
            this.toolStrip_ZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.toolStrip_ZoomIn.ShowShortcutKeys = false;
            this.toolStrip_ZoomIn.Size = new System.Drawing.Size(356, 22);
            this.toolStrip_ZoomIn.Text = "Zoom In                 Ctrl + Plus";
            this.toolStrip_ZoomIn.Click += new System.EventHandler(this.toolStrip_Zoom_Click);
            // 
            // toolStrip_ZoomOut
            // 
            this.toolStrip_ZoomOut.Image = global::Notepad.Properties.Resources.Zoom_Out;
            this.toolStrip_ZoomOut.Name = "toolStrip_ZoomOut";
            this.toolStrip_ZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.toolStrip_ZoomOut.ShowShortcutKeys = false;
            this.toolStrip_ZoomOut.Size = new System.Drawing.Size(356, 22);
            this.toolStrip_ZoomOut.Text = "Zoom Out                Ctrl + Minus";
            this.toolStrip_ZoomOut.Click += new System.EventHandler(this.toolStrip_Zoom_Click);
            // 
            // toolStrip_DefaultZoom
            // 
            this.toolStrip_DefaultZoom.Name = "toolStrip_DefaultZoom";
            this.toolStrip_DefaultZoom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.toolStrip_DefaultZoom.ShowShortcutKeys = false;
            this.toolStrip_DefaultZoom.Size = new System.Drawing.Size(356, 22);
            this.toolStrip_DefaultZoom.Text = "Restore Default Zoom    Ctrl + 0";
            this.toolStrip_DefaultZoom.Click += new System.EventHandler(this.toolStrip_Zoom_Click);
            // 
            // toolStrip_Status
            // 
            this.toolStrip_Status.Checked = true;
            this.toolStrip_Status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStrip_Status.Name = "toolStrip_Status";
            this.toolStrip_Status.ShowShortcutKeys = false;
            this.toolStrip_Status.Size = new System.Drawing.Size(148, 22);
            this.toolStrip_Status.Text = "Status Bar";
            this.toolStrip_Status.Click += new System.EventHandler(this.toolStrip_Status_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Location,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_Factor});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 30);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Location
            // 
            this.toolStripStatusLabel_Location.Name = "toolStripStatusLabel_Location";
            this.toolStripStatusLabel_Location.Size = new System.Drawing.Size(83, 25);
            this.toolStripStatusLabel_Location.Text = "Row 1，Col 1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(26, 25);
            this.toolStripStatusLabel1.Text = "     ";
            // 
            // toolStripStatusLabel_Factor
            // 
            this.toolStripStatusLabel_Factor.Name = "toolStripStatusLabel_Factor";
            this.toolStripStatusLabel_Factor.Size = new System.Drawing.Size(39, 25);
            this.toolStripStatusLabel_Factor.Text = "100%";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.customRtb, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 431);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // customRtb
            // 
            this.customRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customRtb.Location = new System.Drawing.Point(3, 33);
            this.customRtb.Name = "customRtb";
            this.customRtb.Size = new System.Drawing.Size(658, 365);
            this.customRtb.TabIndex = 0;
            this.customRtb.Text = "";
            this.customRtb.Click += new System.EventHandler(this.customRtb_Click);
            this.customRtb.TextChanged += new System.EventHandler(this.customRtb_TextChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Untitled - Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_New;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Open;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Save;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Exit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Search;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Replace;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_GoTo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Location;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Factor;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_ZoomIn;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_ZoomOut;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_DefaultZoom;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Status;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Encrypt;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Undo;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Cut;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Copy;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Paste;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_SelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Redo;
        private CustomRichTextBox customRtb;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Format;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Font;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_ForeColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_BackColor;
    }
}

