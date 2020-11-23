
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 262);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
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
            this.toolStrip_Close});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.optionToolStripMenuItem.Text = "File";
            // 
            // toolStrip_New
            // 
            this.toolStrip_New.Name = "toolStrip_New";
            this.toolStrip_New.Size = new System.Drawing.Size(243, 22);
            this.toolStrip_New.Text = "New                    Ctrl + N";
            this.toolStrip_New.Click += new System.EventHandler(this.toolStrip_New_Click);
            // 
            // toolStrip_Open
            // 
            this.toolStrip_Open.Name = "toolStrip_Open";
            this.toolStrip_Open.Size = new System.Drawing.Size(243, 22);
            this.toolStrip_Open.Text = "Open                  Ctrl + O";
            this.toolStrip_Open.Click += new System.EventHandler(this.toolStrip_Open_Click);
            // 
            // toolStrip_Save
            // 
            this.toolStrip_Save.Name = "toolStrip_Save";
            this.toolStrip_Save.Size = new System.Drawing.Size(243, 22);
            this.toolStrip_Save.Text = "Save                    Ctrl + S";
            this.toolStrip_Save.Click += new System.EventHandler(this.toolStrip_Save_Click);
            // 
            // toolStrip_SaveAs
            // 
            this.toolStrip_SaveAs.Name = "toolStrip_SaveAs";
            this.toolStrip_SaveAs.Size = new System.Drawing.Size(243, 22);
            this.toolStrip_SaveAs.Text = "Save As               Ctrl + Shift + S";
            this.toolStrip_SaveAs.Click += new System.EventHandler(this.toolStrip_SaveAs_Click);
            // 
            // toolStrip_Close
            // 
            this.toolStrip_Close.Name = "toolStrip_Close";
            this.toolStrip_Close.Size = new System.Drawing.Size(243, 22);
            this.toolStrip_Close.Text = "Close                   Esc";
            this.toolStrip_Close.Click += new System.EventHandler(this.toolStrip_Close_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Find,
            this.toolStrip_Replace});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStrip_Find
            // 
            this.toolStrip_Find.Name = "toolStrip_Find";
            this.toolStrip_Find.Size = new System.Drawing.Size(187, 22);
            this.toolStrip_Find.Text = "Find               Ctrl + F";
            this.toolStrip_Find.Click += new System.EventHandler(this.toolStrip_Find_Click);
            // 
            // toolStrip_Replace
            // 
            this.toolStrip_Replace.Name = "toolStrip_Replace";
            this.toolStrip_Replace.Size = new System.Drawing.Size(187, 22);
            this.toolStrip_Replace.Text = "Replace        Ctrl + H";
            this.toolStrip_Replace.Click += new System.EventHandler(this.toolStrip_Replace_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 286);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_New;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Open;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Save;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Close;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Find;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Replace;
    }
}

