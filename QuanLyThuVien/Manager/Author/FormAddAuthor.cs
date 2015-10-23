using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien.Manager.Author
{
    public partial class FormAddAuthor : XtraForm
    {
        public FormAddAuthor()
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
