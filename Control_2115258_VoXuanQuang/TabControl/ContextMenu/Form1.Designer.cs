namespace ContextMenu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tiếngAnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNgoaiNgu = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiếngAnhToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // tiếngAnhToolStripMenuItem
            // 
            this.tiếngAnhToolStripMenuItem.Name = "tiếngAnhToolStripMenuItem";
            this.tiếngAnhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tiếngAnhToolStripMenuItem.Text = "Remove";
            this.tiếngAnhToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // lbNgoaiNgu
            // 
            this.lbNgoaiNgu.ContextMenuStrip = this.contextMenuStrip1;
            this.lbNgoaiNgu.FormattingEnabled = true;
            this.lbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Hàn",
            "Tiếng Việt",
            "Tiếng Đức",
            "Tiếng Nga"});
            this.lbNgoaiNgu.Location = new System.Drawing.Point(13, 13);
            this.lbNgoaiNgu.Name = "lbNgoaiNgu";
            this.lbNgoaiNgu.Size = new System.Drawing.Size(196, 108);
            this.lbNgoaiNgu.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNgoaiNgu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiếngAnhToolStripMenuItem;
        private System.Windows.Forms.ListBox lbNgoaiNgu;
    }
}

