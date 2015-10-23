using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien.Manager.MemberCard
{
    public partial class FormEditMemberCard : XtraForm
    {
        public FormEditMemberCard()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender,
                                         EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormEditMemberCard_Load(object sender,
                                            EventArgs e)
        {
        }
    }
}
