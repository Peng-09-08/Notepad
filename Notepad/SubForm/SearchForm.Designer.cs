
namespace Notepad
{
    partial class SearchForm
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
            this.txt_Target = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.radioBtn_Next = new System.Windows.Forms.RadioButton();
            this.checkBox_WrapAround = new System.Windows.Forms.CheckBox();
            this.checkBox_MatchCase = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_Previous = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // txt_Target
            // 
            this.txt_Target.Location = new System.Drawing.Point(125, 19);
            this.txt_Target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Target.Name = "txt_Target";
            this.txt_Target.Size = new System.Drawing.Size(282, 26);
            this.txt_Target.TabIndex = 1;
            this.txt_Target.TextChanged += new System.EventHandler(this.txt_Target_TextChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Enabled = false;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(430, 19);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(90, 26);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btn_Search.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(430, 63);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 26);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // radioBtn_Next
            // 
            this.radioBtn_Next.AutoSize = true;
            this.radioBtn_Next.Checked = true;
            this.radioBtn_Next.Location = new System.Drawing.Point(133, 25);
            this.radioBtn_Next.Name = "radioBtn_Next";
            this.radioBtn_Next.Size = new System.Drawing.Size(63, 23);
            this.radioBtn_Next.TabIndex = 6;
            this.radioBtn_Next.TabStop = true;
            this.radioBtn_Next.Text = "Next";
            this.radioBtn_Next.UseVisualStyleBackColor = true;
            // 
            // checkBox_WrapAround
            // 
            this.checkBox_WrapAround.AutoSize = true;
            this.checkBox_WrapAround.Location = new System.Drawing.Point(24, 130);
            this.checkBox_WrapAround.Name = "checkBox_WrapAround";
            this.checkBox_WrapAround.Size = new System.Drawing.Size(127, 23);
            this.checkBox_WrapAround.TabIndex = 7;
            this.checkBox_WrapAround.Text = "Wrap around";
            this.checkBox_WrapAround.UseVisualStyleBackColor = true;
            // 
            // checkBox_MatchCase
            // 
            this.checkBox_MatchCase.AutoSize = true;
            this.checkBox_MatchCase.Location = new System.Drawing.Point(24, 95);
            this.checkBox_MatchCase.Name = "checkBox_MatchCase";
            this.checkBox_MatchCase.Size = new System.Drawing.Size(118, 23);
            this.checkBox_MatchCase.TabIndex = 8;
            this.checkBox_MatchCase.Text = "Match case";
            this.checkBox_MatchCase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_Previous);
            this.groupBox1.Controls.Add(this.radioBtn_Next);
            this.groupBox1.Location = new System.Drawing.Point(197, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 58);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // radioBtn_Previous
            // 
            this.radioBtn_Previous.AutoSize = true;
            this.radioBtn_Previous.Location = new System.Drawing.Point(15, 25);
            this.radioBtn_Previous.Name = "radioBtn_Previous";
            this.radioBtn_Previous.Size = new System.Drawing.Size(99, 23);
            this.radioBtn_Previous.TabIndex = 7;
            this.radioBtn_Previous.Text = "Previous";
            this.radioBtn_Previous.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 174);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_MatchCase);
            this.Controls.Add(this.checkBox_WrapAround);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Target);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Search";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Target;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RadioButton radioBtn_Next;
        private System.Windows.Forms.CheckBox checkBox_WrapAround;
        private System.Windows.Forms.CheckBox checkBox_MatchCase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_Previous;
    }
}