using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien.Manager.Library.BookLoan
{
    public partial class FormPayBooks : XtraForm
    {
        public FormPayBooks()
        {
            InitializeComponent();
        }

        private void FormPayBooks_Load(object sender,
                                       EventArgs e)
        {
            txtDateTo.EditValue = DateTime.Now;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            Close();
        }
    }
}
