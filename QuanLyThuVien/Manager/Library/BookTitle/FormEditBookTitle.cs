﻿using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien.Manager.Library.BookTitle
{
    public partial class FormEditBookTitle : XtraForm
    {
        public FormEditBookTitle()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender,
                                         EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
