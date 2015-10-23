using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien.Manager.Library.Book
{
    public partial class FormAddBook : XtraForm
    {
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, System.EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            Close();
        }
    }
}
