using System;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;
using QuanLyThuVien.Manager.Author;
using QuanLyThuVien.Manager.BookType;
using QuanLyThuVien.Manager.BookType2;
using QuanLyThuVien.Manager.Language;
using QuanLyThuVien.Manager.Library.Book;
using QuanLyThuVien.Manager.Library.BookLoan;
using QuanLyThuVien.Manager.Library.BookTitle;
using QuanLyThuVien.Manager.MemberCard;
using QuanLyThuVien.Manager.PublishingHouse;
using QuanLyThuVien.Manager.User;
using QuanLyThuVien.Properties;

namespace QuanLyThuVien
{
    public partial class FormMain : RibbonForm
    {
        public dynamic AddForm<T>() where T : Form
        {
            Type type = typeof(T);

            foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            {
                if(page.MdiChild.GetType() == type)
                {
                    xtraTabbedMdiManager1.SelectedPage = page;

                    return page.MdiChild;
                }
            }
            Form form = Activator.CreateInstance(type,
                                                 true) as Form;
            if(form != null)
            {
                form.MdiParent = this;

                form.Show();
            }
            return form;
        }

        #region Form event

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender,
                                   EventArgs e)
        {
            SkinHelper.InitSkinGallery(ribbonGalleryBarItem1,
                                       true);
        }

        private void FormMain_FormClosing(object sender,
                                          FormClosingEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có chắc chắn muốn thoát?",
                                   "Thông báo",
                                   MessageBoxButtons.OKCancel,
                                   MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(AppUtil.frmLogin != null)
                {
                    AppUtil.frmLogin.Dispose();
                }
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender,
                                 EventArgs e)
        {
            string temp = string.Empty;
            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    temp = "Thứ hai";
                    break;
                case DayOfWeek.Tuesday:
                    temp = "Thứ ba";
                    break;
                case DayOfWeek.Wednesday:
                    temp = "Thứ tư";
                    break;
                case DayOfWeek.Thursday:
                    temp = "Thứ năm";
                    break;
                case DayOfWeek.Friday:
                    temp = "Thứ sáu";
                    break;
                case DayOfWeek.Saturday:
                    temp = "Thứ bảy";
                    break;
                case DayOfWeek.Sunday:
                    temp = "Chủ nhật";
                    break;
            }
            barStaticItem1.Caption = string.Format("{0} {1:00}-{2:00}-{3:00} {4:00}:{5:00}:{6:00}",
                                                   temp,
                                                   DateTime.Now.Day,
                                                   DateTime.Now.Month,
                                                   DateTime.Now.Year,
                                                   DateTime.Now.Hour,
                                                   DateTime.Now.Minute,
                                                   DateTime.Now.Second);
        }

        #endregion

        #region Ribbon event

        private void ribbon_Merge(object sender,
                                  RibbonMergeEventArgs e)
        {
            RibbonPage page = null;
            if(e.MergedChild.PageCategories.Count > 0)
            {
                if(e.MergedChild.PageCategories[0].Pages.Count > 0)
                {
                    page = e.MergedChild.PageCategories[0].Pages[0];
                }
            }
            else
            {
                if(e.MergedChild.DefaultPageCategory.Pages.Count > 0)
                {
                    page = e.MergedChild.DefaultPageCategory.Pages[0];
                }
            }
            if(page != null)
            {
                ribbon.SelectedPage = page;
            }
            // merge status bar
            RibbonControl parentRRibbon = sender as RibbonControl;
            RibbonControl childRibbon = e.MergedChild;
            if(childRibbon.StatusBar != null)
            {
                if(parentRRibbon != null)
                {
                    parentRRibbon.StatusBar.MergeStatusBar(childRibbon.StatusBar);
                }
            }
        }

        private void ribbon_UnMerge(object sender,
                                    RibbonMergeEventArgs e)
        {
            RibbonControl parentRRibbon = sender as RibbonControl;
            if(parentRRibbon != null)
            {
                parentRRibbon.StatusBar.UnMergeStatusBar();
            }
        }

        #endregion

        #region Button event

        private void barButtonItem1_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem4_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            FormInformation frm = new FormInformation();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                AlertControl.Show(this,
                                  "Thông báo",
                                  "Cập nhật thông tin thành công",
                                  Resources.success48);
            }
        }

        private void barButtonItem3_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            FormChangePass frm = new FormChangePass();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                AlertControl.Show(this,
                                  "Thông báo",
                                  "Thay đổi mật khẩu thành công",
                                  Resources.success48);
            }
        }

        private void barButtonItem9_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            AddForm<FormMemberCards>();
        }

        private void barButtonItem13_ItemClick(object sender,
                                               ItemClickEventArgs e)
        {
            Process.Start("calc");
        }

        private void barButtonItem11_ItemClick(object sender,
                                               ItemClickEventArgs e)
        {
            AddForm<FormUsers>();
        }

        private void barButtonItem12_ItemClick(object sender,
                                               ItemClickEventArgs e)
        {
            AddForm<FormBookTypes>();
        }

        private void barButtonItem14_ItemClick(object sender,
                                               ItemClickEventArgs e)
        {
            AddForm<FormBookTypes2>();
        }

        private void barButtonItem15_ItemClick(object sender,
                                               ItemClickEventArgs e)
        {
            AddForm<FormLanguages>();
        }

        private void barButtonItem16_ItemClick(object sender,
                                               ItemClickEventArgs e)
        {
            AddForm<FormPublishingHouses>();
        }

        private void barButtonItem17_ItemClick(object sender,
                                               ItemClickEventArgs e)
        {
            AddForm<FormAuthors>();
        }

        private void barButtonItem6_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            AddForm<FormBookTitles>();
        }

        private void barButtonItem7_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            AddForm<FormBooks>();
        }

        private void barButtonItem8_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            FormAddBook frm = new FormAddBook();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                AlertControl.Show(this,
                                  "Thông báo",
                                  "Nhập thêm sách thành công",
                                  Resources.success48);
            }
        }

        private void barButtonItem18_ItemClick(object sender,
                                               ItemClickEventArgs e)
        {
            FormRemoveBook frm = new FormRemoveBook();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                AlertControl.Show(this,
                                  "Thông báo",
                                  "Tiêu hủy sách thành công",
                                  Resources.success48);
            }
        }

        private void barButtonItem2_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            FormLoanBooks frm = new FormLoanBooks();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                AlertControl.Show(this,
                                  "Thông báo",
                                  "Cho mượn sách thành công",
                                  Resources.success48);
            }
        }

        private void barButtonItem5_ItemClick(object sender,
                                              ItemClickEventArgs e)
        {
            FormPayBooks frm = new FormPayBooks();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                AlertControl.Show(this,
                                  "Thông báo",
                                  "Nhận sách trả thành công",
                                  Resources.success48);
            }
        }

        #endregion
    }
}
