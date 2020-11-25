namespace Notepad.SubForm
{
    partial class EncryptForm
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
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.radioBtn_Encrypt = new System.Windows.Forms.RadioButton();
            this.radioBtn_Decrypt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // txt_Key
            // 
            this.txt_Key.Location = new System.Drawing.Point(76, 26);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(159, 26);
            this.txt_Key.TabIndex = 1;
            // 
            // btn_Execute
            // 
            this.btn_Execute.Location = new System.Drawing.Point(259, 25);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(90, 26);
            this.btn_Execute.TabIndex = 2;
            this.btn_Execute.Text = "Execute";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // radioBtn_Encrypt
            // 
            this.radioBtn_Encrypt.AutoSize = true;
            this.radioBtn_Encrypt.Checked = true;
            this.radioBtn_Encrypt.Location = new System.Drawing.Point(17, 28);
            this.radioBtn_Encrypt.Name = "radioBtn_Encrypt";
            this.radioBtn_Encrypt.Size = new System.Drawing.Size(90, 23);
            this.radioBtn_Encrypt.TabIndex = 3;
            this.radioBtn_Encrypt.TabStop = true;
            this.radioBtn_Encrypt.Text = "Encrypt";
            this.radioBtn_Encrypt.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Decrypt
            // 
            this.radioBtn_Decrypt.AutoSize = true;
            this.radioBtn_Decrypt.Location = new System.Drawing.Point(115, 28);
            this.radioBtn_Decrypt.Name = "radioBtn_Decrypt";
            this.radioBtn_Decrypt.Size = new System.Drawing.Size(90, 23);
            this.radioBtn_Decrypt.TabIndex = 4;
            this.radioBtn_Decrypt.Text = "Decrypt";
            this.radioBtn_Decrypt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_Decrypt);
            this.groupBox1.Controls.Add(this.radioBtn_Encrypt);
            this.groupBox1.Location = new System.Drawing.Point(23, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(259, 70);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 26);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 148);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncryptForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Encrypt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.RadioButton radioBtn_Encrypt;
        private System.Windows.Forms.RadioButton radioBtn_Decrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
    }
}