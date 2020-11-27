namespace Notepad.Edit
{
    partial class ReplaceForm
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Target = new System.Windows.Forms.TextBox();
            this.txt_Replace = new System.Windows.Forms.TextBox();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.btn_ReplaceAll = new System.Windows.Forms.Button();
            this.checkBox_MatchCase = new System.Windows.Forms.CheckBox();
            this.checkBox_WrapAround = new System.Windows.Forms.CheckBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace with:";
            // 
            // btn_Search
            // 
            this.btn_Search.Enabled = false;
            this.btn_Search.Location = new System.Drawing.Point(403, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(150, 35);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btn_Search.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // txt_Target
            // 
            this.txt_Target.Location = new System.Drawing.Point(155, 19);
            this.txt_Target.Name = "txt_Target";
            this.txt_Target.Size = new System.Drawing.Size(227, 26);
            this.txt_Target.TabIndex = 3;
            this.txt_Target.TextChanged += new System.EventHandler(this.txt_Target_TextChanged);
            // 
            // txt_Replace
            // 
            this.txt_Replace.Location = new System.Drawing.Point(155, 62);
            this.txt_Replace.Name = "txt_Replace";
            this.txt_Replace.Size = new System.Drawing.Size(227, 26);
            this.txt_Replace.TabIndex = 6;
            // 
            // btn_Replace
            // 
            this.btn_Replace.Enabled = false;
            this.btn_Replace.Location = new System.Drawing.Point(403, 67);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(150, 35);
            this.btn_Replace.TabIndex = 7;
            this.btn_Replace.Text = "Replace(&R)";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            this.btn_Replace.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btn_Replace.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btn_ReplaceAll
            // 
            this.btn_ReplaceAll.Enabled = false;
            this.btn_ReplaceAll.Location = new System.Drawing.Point(403, 115);
            this.btn_ReplaceAll.Name = "btn_ReplaceAll";
            this.btn_ReplaceAll.Size = new System.Drawing.Size(150, 35);
            this.btn_ReplaceAll.TabIndex = 8;
            this.btn_ReplaceAll.Text = "Replace All(&A)";
            this.btn_ReplaceAll.UseVisualStyleBackColor = true;
            this.btn_ReplaceAll.Click += new System.EventHandler(this.btn_ReplaceAll_Click);
            this.btn_ReplaceAll.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btn_ReplaceAll.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // checkBox_MatchCase
            // 
            this.checkBox_MatchCase.AutoSize = true;
            this.checkBox_MatchCase.Location = new System.Drawing.Point(25, 135);
            this.checkBox_MatchCase.Name = "checkBox_MatchCase";
            this.checkBox_MatchCase.Size = new System.Drawing.Size(118, 23);
            this.checkBox_MatchCase.TabIndex = 11;
            this.checkBox_MatchCase.Text = "Match case";
            this.checkBox_MatchCase.UseVisualStyleBackColor = true;
            this.checkBox_MatchCase.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_WrapAround
            // 
            this.checkBox_WrapAround.AutoSize = true;
            this.checkBox_WrapAround.Location = new System.Drawing.Point(25, 170);
            this.checkBox_WrapAround.Name = "checkBox_WrapAround";
            this.checkBox_WrapAround.Size = new System.Drawing.Size(127, 23);
            this.checkBox_WrapAround.TabIndex = 10;
            this.checkBox_WrapAround.Text = "Wrap around";
            this.checkBox_WrapAround.UseVisualStyleBackColor = true;
            this.checkBox_WrapAround.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(403, 163);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(150, 35);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 213);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.checkBox_MatchCase);
            this.Controls.Add(this.checkBox_WrapAround);
            this.Controls.Add(this.btn_ReplaceAll);
            this.Controls.Add(this.btn_Replace);
            this.Controls.Add(this.txt_Replace);
            this.Controls.Add(this.txt_Target);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Replace";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReplaceForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Target;
        private System.Windows.Forms.TextBox txt_Replace;
        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.Button btn_ReplaceAll;
        private System.Windows.Forms.CheckBox checkBox_MatchCase;
        private System.Windows.Forms.CheckBox checkBox_WrapAround;
        private System.Windows.Forms.Button btn_Cancel;
    }
}