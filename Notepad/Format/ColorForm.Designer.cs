
namespace Notepad.Format
{
    partial class ColorForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.comboBox_ForeColor = new System.Windows.Forms.ComboBox();
            this.lbl_ForeColor = new System.Windows.Forms.Label();
            this.pictureBox_ForeColor = new System.Windows.Forms.PictureBox();
            this.btn_ForeColor = new System.Windows.Forms.Button();
            this.lbl_BackColor = new System.Windows.Forms.Label();
            this.pictureBox_BackColor = new System.Windows.Forms.PictureBox();
            this.btn_BackColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BackColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ForeColor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "BackColor:";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(359, 28);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(83, 35);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(359, 90);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(83, 35);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // comboBox_ForeColor
            // 
            this.comboBox_ForeColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_ForeColor.FormattingEnabled = true;
            this.comboBox_ForeColor.Location = new System.Drawing.Point(281, 177);
            this.comboBox_ForeColor.Name = "comboBox_ForeColor";
            this.comboBox_ForeColor.Size = new System.Drawing.Size(180, 27);
            this.comboBox_ForeColor.TabIndex = 4;
            this.comboBox_ForeColor.Visible = false;
            this.comboBox_ForeColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_ForeColor_DrawItem);
            // 
            // lbl_ForeColor
            // 
            this.lbl_ForeColor.AutoSize = true;
            this.lbl_ForeColor.Location = new System.Drawing.Point(155, 38);
            this.lbl_ForeColor.Name = "lbl_ForeColor";
            this.lbl_ForeColor.Size = new System.Drawing.Size(54, 19);
            this.lbl_ForeColor.TabIndex = 6;
            this.lbl_ForeColor.Text = "Black";
            // 
            // pictureBox_ForeColor
            // 
            this.pictureBox_ForeColor.BackColor = System.Drawing.Color.Black;
            this.pictureBox_ForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_ForeColor.Location = new System.Drawing.Point(129, 37);
            this.pictureBox_ForeColor.Name = "pictureBox_ForeColor";
            this.pictureBox_ForeColor.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_ForeColor.TabIndex = 5;
            this.pictureBox_ForeColor.TabStop = false;
            // 
            // btn_ForeColor
            // 
            this.btn_ForeColor.BackColor = System.Drawing.Color.Transparent;
            this.btn_ForeColor.BackgroundImage = global::Notepad.Properties.Resources.Triangle;
            this.btn_ForeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ForeColor.Location = new System.Drawing.Point(244, 32);
            this.btn_ForeColor.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ForeColor.Name = "btn_ForeColor";
            this.btn_ForeColor.Size = new System.Drawing.Size(30, 30);
            this.btn_ForeColor.TabIndex = 7;
            this.btn_ForeColor.UseVisualStyleBackColor = false;
            this.btn_ForeColor.Click += new System.EventHandler(this.button_Click);
            // 
            // lbl_BackColor
            // 
            this.lbl_BackColor.AutoSize = true;
            this.lbl_BackColor.Location = new System.Drawing.Point(155, 104);
            this.lbl_BackColor.Name = "lbl_BackColor";
            this.lbl_BackColor.Size = new System.Drawing.Size(54, 19);
            this.lbl_BackColor.TabIndex = 9;
            this.lbl_BackColor.Text = "Black";
            // 
            // pictureBox_BackColor
            // 
            this.pictureBox_BackColor.BackColor = System.Drawing.Color.Black;
            this.pictureBox_BackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_BackColor.Location = new System.Drawing.Point(129, 103);
            this.pictureBox_BackColor.Name = "pictureBox_BackColor";
            this.pictureBox_BackColor.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_BackColor.TabIndex = 8;
            this.pictureBox_BackColor.TabStop = false;
            // 
            // btn_BackColor
            // 
            this.btn_BackColor.BackColor = System.Drawing.Color.Transparent;
            this.btn_BackColor.BackgroundImage = global::Notepad.Properties.Resources.Triangle;
            this.btn_BackColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BackColor.Location = new System.Drawing.Point(244, 98);
            this.btn_BackColor.Margin = new System.Windows.Forms.Padding(0);
            this.btn_BackColor.Name = "btn_BackColor";
            this.btn_BackColor.Size = new System.Drawing.Size(30, 30);
            this.btn_BackColor.TabIndex = 10;
            this.btn_BackColor.UseVisualStyleBackColor = false;
            this.btn_BackColor.Click += new System.EventHandler(this.button_Click);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.btn_BackColor);
            this.Controls.Add(this.lbl_BackColor);
            this.Controls.Add(this.pictureBox_BackColor);
            this.Controls.Add(this.lbl_ForeColor);
            this.Controls.Add(this.pictureBox_ForeColor);
            this.Controls.Add(this.btn_ForeColor);
            this.Controls.Add(this.comboBox_ForeColor);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Color";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BackColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox comboBox_ForeColor;
        private System.Windows.Forms.PictureBox pictureBox_ForeColor;
        private System.Windows.Forms.Label lbl_ForeColor;
        private System.Windows.Forms.Button btn_ForeColor;
        private System.Windows.Forms.Label lbl_BackColor;
        private System.Windows.Forms.PictureBox pictureBox_BackColor;
        private System.Windows.Forms.Button btn_BackColor;
    }
}