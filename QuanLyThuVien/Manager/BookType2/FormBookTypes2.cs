using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Ribbon;
using QuanLyThuVien.Properties;

namespace QuanLyThuVien.Manager.BookType2
{
    public partial class FormBookTypes2 : RibbonForm
    {
        private string fileName = string.Empty;

        private bool openFile;

        public FormBookTypes2()
        {
            InitializeComponent();
        }

        private void ExportGrid(Action<string> func,
                                string format)
        {
            saveFileDialog.FileName = "DanhSachLoaiHinh";
            saveFileDialog.Filter = format;
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    func.Invoke(saveFileDialog.FileName);
                    AlertControl.Show(this,
                                      "Thông báo",
                                      "Trích xuất dữ liệu thành công",
                                      Resources.success48);
                    openFile = true;
                    fileName = saveFileDialog.FileName;
                }
                catch (Exception)
                {
                    AlertControl.Show(this,
                                      "Thông báo",
                                      "Trích xuất dữ liệu không thành công. Vui lòng thử lại sau",
                                      Resources.error48);
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void barButtonItem4_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            ExportGrid(gridControl1.ExportToPdf,
                       "PDF Files (*.pdf)|*.pdf");
        }

        private void barButtonItem5_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            ExportGrid(gridControl1.ExportToXls,
                       "XLS Files (*.xls)|*.xls");
        }

        private void barButtonItem6_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            ExportGrid(gridControl1.ExportToXlsx,
                       "XLSX Files (*.xlsx)|*.xlsx");
        }

        private void barButtonItem7_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            ExportGrid(gridControl1.ExportToCsv,
                       "CSV Files (*.csv)|*.csv");
        }

        private void AlertControl_AlertClick(object sender,
                                             AlertClickEventArgs e)
        {
            if(!string.IsNullOrEmpty(fileName) && openFile)
            {
                Process.Start(fileName);
            }
        }

        private void barButtonItem1_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            if(new FormAddBookType2().ShowDialog() == DialogResult.OK)
            {
                openFile = false;
                AlertControl.Show(this,
                                  "Thông báo",
                                  "Thêm loại hình sách thành công",
                                  Resources.success48);
            }
        }
    }
}
