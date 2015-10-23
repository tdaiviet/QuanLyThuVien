using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien.Manager.Library.BookLoan
{
    public partial class FormLoanBooks : XtraForm
    {
        public FormLoanBooks()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender,
                                         EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormLoanBooks_Load(object sender, EventArgs e)
        {
            txtDateFrom.EditValue = DateTime.Now;
            txtDateTo.EditValue = DateTime.Now.AddMonths(1);
        }
    }
}
