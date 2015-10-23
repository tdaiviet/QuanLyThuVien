using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien
{
    public partial class FormLogin : XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender,
                                         EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender,
                                         EventArgs e)
        {
            AppUtil.frmLogin = this;
            Hide();
            if(AppUtil.frmMain == null)
            {
                AppUtil.frmMain = new FormMain();
            }
            AppUtil.frmMain.Show();
        }
    }
}
