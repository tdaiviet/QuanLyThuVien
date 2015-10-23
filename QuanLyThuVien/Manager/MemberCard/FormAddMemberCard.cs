using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien.Manager.MemberCard
{
    public partial class FormAddMemberCard : XtraForm
    {
        public FormAddMemberCard()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender,
                                         EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormAddMemberCard_Load(object sender,
                                            EventArgs e)
        {
            txtCreatedDate.EditValue = DateTime.Now;
            txtExpiredDate.EditValue = DateTime.Now.AddMonths(6);
        }
    }
}
