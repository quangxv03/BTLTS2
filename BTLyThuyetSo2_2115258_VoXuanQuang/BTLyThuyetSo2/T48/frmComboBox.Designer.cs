namespace T48
{
    partial class frmComboBox
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
            this.cbNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbNgoaiNgu
            // 
            this.cbNgoaiNgu.FormattingEnabled = true;
            this.cbNgoaiNgu.Location = new System.Drawing.Point(132, 21);
            this.cbNgoaiNgu.Name = "cbNgoaiNgu";
            this.cbNgoaiNgu.Size = new System.Drawing.Size(121, 21);
            this.cbNgoaiNgu.TabIndex = 0;
            this.cbNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.cbNgoaiNgu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn Ngoại Ngữ";
            // 
            // frmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNgoaiNgu);
            this.Name = "frmComboBox";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.frmComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNgoaiNgu;
        private System.Windows.Forms.Label label1;
    }
}

