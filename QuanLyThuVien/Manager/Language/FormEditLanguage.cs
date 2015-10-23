using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien.Manager.Language
{
    public partial class FormEditLanguage : XtraForm
    {
        public FormEditLanguage()
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
