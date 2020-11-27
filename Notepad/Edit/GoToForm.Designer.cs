namespace Notepad.Edit
{
    partial class GoToForm
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
            this.txt_LineNumber = new System.Windows.Forms.TextBox();
            this.btn_GoTo = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Line number:";
            // 
            // txt_LineNumber
            // 
            this.txt_LineNumber.Location = new System.Drawing.Point(16, 43);
            this.txt_LineNumber.Name = "txt_LineNumber";
            this.txt_LineNumber.Size = new System.Drawing.Size(257, 26);
            this.txt_LineNumber.TabIndex = 1;
            // 
            // btn_GoTo
            // 
            this.btn_GoTo.Location = new System.Drawing.Point(91, 83);
            this.btn_GoTo.Name = "btn_GoTo";
            this.btn_GoTo.Size = new System.Drawing.Size(75, 28);
            this.btn_GoTo.TabIndex = 2;
            this.btn_GoTo.Text = "Go To";
            this.btn_GoTo.UseVisualStyleBackColor = true;
            this.btn_GoTo.Click += new System.EventHandler(this.btn_GoTo_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(199, 83);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 28);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // GoToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 126);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_GoTo);
            this.Controls.Add(this.txt_LineNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Go To Line";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoToForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LineNumber;
        private System.Windows.Forms.Button btn_GoTo;
        private System.Windows.Forms.Button btn_Cancel;
    }
}