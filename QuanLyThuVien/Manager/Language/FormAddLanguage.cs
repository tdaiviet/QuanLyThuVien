using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien.Manager.Language
{
    public partial class FormAddLanguage : XtraForm
    {
        public FormAddLanguage()
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
