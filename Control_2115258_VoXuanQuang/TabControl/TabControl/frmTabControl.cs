﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class frmTabControl : Form
    {
        public frmTabControl()
        {
            InitializeComponent();
        }

        private void frmTabControl_Load(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Clear();
            TabPage tabSV = new TabPage();
            TabPage tabGV = new TabPage();
            TabPage tabMH = new TabPage();
            tabSV.Text = "Sinh viên";
            tabGV.Text = "Giáo viên";
            tabMH.Text = "Môn học";
            this.tabControl1.TabPages.Add(tabSV);
            this.tabControl1.TabPages.Add(tabGV);
            this.tabControl1.TabPages.Add(tabMH);
        }
    }
}
