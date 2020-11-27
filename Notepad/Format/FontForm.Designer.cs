
namespace Notepad.Format
{
    partial class FontForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.txt_Font = new System.Windows.Forms.TextBox();
            this.listBox_Font = new System.Windows.Forms.ListBox();
            this.listBox_Style = new System.Windows.Forms.ListBox();
            this.txt_Style = new System.Windows.Forms.TextBox();
            this.listBox_Size = new System.Windows.Forms.ListBox();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Sample = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Underline = new System.Windows.Forms.CheckBox();
            this.checkBox_Strikeout = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Font style:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(475, 78);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 30);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(475, 31);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(80, 30);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // txt_Font
            // 
            this.txt_Font.Location = new System.Drawing.Point(25, 34);
            this.txt_Font.Name = "txt_Font";
            this.txt_Font.Size = new System.Drawing.Size(182, 26);
            this.txt_Font.TabIndex = 5;
            // 
            // listBox_Font
            // 
            this.listBox_Font.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_Font.FormattingEnabled = true;
            this.listBox_Font.ItemHeight = 19;
            this.listBox_Font.Location = new System.Drawing.Point(25, 59);
            this.listBox_Font.Name = "listBox_Font";
            this.listBox_Font.Size = new System.Drawing.Size(182, 99);
            this.listBox_Font.TabIndex = 6;
            this.listBox_Font.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            this.listBox_Font.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBox_Style
            // 
            this.listBox_Style.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_Style.FormattingEnabled = true;
            this.listBox_Style.ItemHeight = 19;
            this.listBox_Style.Items.AddRange(new object[] {
            "Regular",
            "Italic",
            "Bold",
            "Bold Italic"});
            this.listBox_Style.Location = new System.Drawing.Point(227, 59);
            this.listBox_Style.Name = "listBox_Style";
            this.listBox_Style.Size = new System.Drawing.Size(140, 99);
            this.listBox_Style.TabIndex = 8;
            this.listBox_Style.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            this.listBox_Style.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // txt_Style
            // 
            this.txt_Style.Location = new System.Drawing.Point(227, 34);
            this.txt_Style.Name = "txt_Style";
            this.txt_Style.Size = new System.Drawing.Size(140, 26);
            this.txt_Style.TabIndex = 7;
            // 
            // listBox_Size
            // 
            this.listBox_Size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_Size.FormattingEnabled = true;
            this.listBox_Size.ItemHeight = 19;
            this.listBox_Size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.listBox_Size.Location = new System.Drawing.Point(387, 59);
            this.listBox_Size.Name = "listBox_Size";
            this.listBox_Size.Size = new System.Drawing.Size(67, 99);
            this.listBox_Size.TabIndex = 10;
            this.listBox_Size.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            this.listBox_Size.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // txt_Size
            // 
            this.txt_Size.Location = new System.Drawing.Point(387, 34);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(67, 26);
            this.txt_Size.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Sample);
            this.groupBox2.Location = new System.Drawing.Point(226, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sample";
            // 
            // lbl_Sample
            // 
            this.lbl_Sample.AutoSize = true;
            this.lbl_Sample.Location = new System.Drawing.Point(68, 55);
            this.lbl_Sample.Name = "lbl_Sample";
            this.lbl_Sample.Size = new System.Drawing.Size(81, 19);
            this.lbl_Sample.TabIndex = 0;
            this.lbl_Sample.Text = "AaBbYyZz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Underline);
            this.groupBox1.Controls.Add(this.checkBox_Strikeout);
            this.groupBox1.Location = new System.Drawing.Point(28, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 119);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Effect";
            // 
            // checkBox_Underline
            // 
            this.checkBox_Underline.AutoSize = true;
            this.checkBox_Underline.Location = new System.Drawing.Point(16, 73);
            this.checkBox_Underline.Name = "checkBox_Underline";
            this.checkBox_Underline.Size = new System.Drawing.Size(109, 23);
            this.checkBox_Underline.TabIndex = 1;
            this.checkBox_Underline.Text = "Underline";
            this.checkBox_Underline.UseVisualStyleBackColor = true;
            this.checkBox_Underline.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_Strikeout
            // 
            this.checkBox_Strikeout.AutoSize = true;
            this.checkBox_Strikeout.Location = new System.Drawing.Point(16, 36);
            this.checkBox_Strikeout.Name = "checkBox_Strikeout";
            this.checkBox_Strikeout.Size = new System.Drawing.Size(145, 23);
            this.checkBox_Strikeout.TabIndex = 0;
            this.checkBox_Strikeout.Text = "Strikethrough";
            this.checkBox_Strikeout.UseVisualStyleBackColor = true;
            this.checkBox_Strikeout.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // FontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox_Size);
            this.Controls.Add(this.txt_Size);
            this.Controls.Add(this.listBox_Style);
            this.Controls.Add(this.txt_Style);
            this.Controls.Add(this.listBox_Font);
            this.Controls.Add(this.txt_Font);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Font";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox txt_Font;
        private System.Windows.Forms.ListBox listBox_Font;
        private System.Windows.Forms.ListBox listBox_Style;
        private System.Windows.Forms.TextBox txt_Style;
        private System.Windows.Forms.ListBox listBox_Size;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Sample;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Strikeout;
        private System.Windows.Forms.CheckBox checkBox_Underline;
    }
}