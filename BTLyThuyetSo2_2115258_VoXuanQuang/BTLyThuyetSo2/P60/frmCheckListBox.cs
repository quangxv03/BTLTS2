﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P60
{
    public partial class frmCheckListBox : Form
    {
        public frmCheckListBox()
        {
            InitializeComponent();
        }

        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items;
            items = this.clbMonHoc.CheckedItems;
            string s = "";
            foreach(object ob in items)
            {
                s += ob.ToString() + ",";
            }
            MessageBox.Show("Danh sach mon hoc: "+s);
        }
    }
}
