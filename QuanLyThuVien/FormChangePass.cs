using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien
{
    public partial class FormChangePass : XtraForm
    {
        public FormChangePass()
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
