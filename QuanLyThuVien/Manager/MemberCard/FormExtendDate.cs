using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien.Manager.MemberCard
{
    public partial class FormExtendDate : XtraForm
    {
        public FormExtendDate()
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
