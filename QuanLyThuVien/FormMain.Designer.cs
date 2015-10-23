namespace QuanLyThuVien
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem18 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.AlertControl = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem3,
            this.barButtonItem4,
            this.ribbonGalleryBarItem1,
            this.barButtonItem2,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barStaticItem1,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem15,
            this.barButtonItem16,
            this.barButtonItem17,
            this.barButtonItem18});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 24;
            this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(866, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.Merge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.ribbon_Merge);
            this.ribbon.UnMerge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.ribbon_UnMerge);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Glyph = global::QuanLyThuVien.Properties.Resources.close_16x16;
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem1.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem1.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem1.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem1.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem1.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem1.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem1.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem1.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem1.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem1.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem1.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem1.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem1.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem1.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem1.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem1.LargeGlyph = global::QuanLyThuVien.Properties.Resources.close_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đổi mật khẩu";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem3.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem3.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem3.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem3.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem3.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem3.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem3.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem3.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem3.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem3.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem3.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem3.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem3.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem3.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem3.LargeGlyph = global::QuanLyThuVien.Properties.Resources.ChangePass;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thông tin";
            this.barButtonItem4.Glyph = global::QuanLyThuVien.Properties.Resources.customizegrid_16x16;
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem4.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem4.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem4.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem4.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem4.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem4.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem4.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem4.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem4.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem4.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem4.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem4.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem4.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem4.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem4.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem4.LargeGlyph = global::QuanLyThuVien.Properties.Resources.customizegrid_32x32;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 5;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Cho mượn sách";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem2.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem2.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem2.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem2.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem2.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem2.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem2.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem2.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Nhận sách trả";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem5.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem5.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem5.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem5.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem5.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem5.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem5.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem5.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem5.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem5.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem5.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem5.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem5.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem5.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem5.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Đầu sách";
            this.barButtonItem6.Id = 8;
            this.barButtonItem6.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem6.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem6.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem6.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem6.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem6.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem6.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem6.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem6.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Danh sách sách";
            this.barButtonItem7.Id = 9;
            this.barButtonItem7.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem7.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem7.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem7.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem7.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem7.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem7.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem7.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem7.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Nhập thêm sách";
            this.barButtonItem8.Id = 10;
            this.barButtonItem8.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem8.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem8.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem8.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem8.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem8.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem8.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem8.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem8.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Danh sách thẻ";
            this.barButtonItem9.Glyph = global::QuanLyThuVien.Properties.Resources.contact_16x16;
            this.barButtonItem9.Id = 11;
            this.barButtonItem9.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem9.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem9.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem9.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem9.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem9.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem9.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem9.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem9.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.LargeGlyph = global::QuanLyThuVien.Properties.Resources.contact_32x32;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.ActAsDropDown = true;
            this.barButtonItem10.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem10.Caption = "Quản lý khác";
            this.barButtonItem10.DropDownControl = this.popupMenu1;
            this.barButtonItem10.Glyph = global::QuanLyThuVien.Properties.Resources.properties_16x16;
            this.barButtonItem10.Id = 13;
            this.barButtonItem10.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem10.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem10.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem10.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem10.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem10.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem10.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem10.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem10.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.LargeGlyph = global::QuanLyThuVien.Properties.Resources.properties_32x32;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButtonItem11);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem12);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem14);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem15);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem16);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem17);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Người dùng";
            this.barButtonItem11.Glyph = global::QuanLyThuVien.Properties.Resources.customer_16x16;
            this.barButtonItem11.Id = 14;
            this.barButtonItem11.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem11.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem11.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem11.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem11.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem11.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem11.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem11.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem11.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem11.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem11.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem11.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem11.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem11.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem11.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem11.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem11.LargeGlyph = global::QuanLyThuVien.Properties.Resources.customer_32x32;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Thể loại";
            this.barButtonItem12.Glyph = global::QuanLyThuVien.Properties.Resources.edittask_16x16;
            this.barButtonItem12.Id = 15;
            this.barButtonItem12.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem12.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem12.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem12.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem12.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem12.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem12.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem12.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem12.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem12.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem12.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem12.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem12.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem12.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem12.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem12.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem12.LargeGlyph = global::QuanLyThuVien.Properties.Resources.edittask_32x32;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Loại hình";
            this.barButtonItem14.Glyph = global::QuanLyThuVien.Properties.Resources.edittask_16x16;
            this.barButtonItem14.Id = 19;
            this.barButtonItem14.LargeGlyph = global::QuanLyThuVien.Properties.Resources.edittask_32x32;
            this.barButtonItem14.Name = "barButtonItem14";
            this.barButtonItem14.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick);
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Ngôn ngữ";
            this.barButtonItem15.Glyph = global::QuanLyThuVien.Properties.Resources.edittask_16x16;
            this.barButtonItem15.Id = 20;
            this.barButtonItem15.LargeGlyph = global::QuanLyThuVien.Properties.Resources.edittask_32x32;
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem15_ItemClick);
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Nhà xuất bản";
            this.barButtonItem16.Glyph = global::QuanLyThuVien.Properties.Resources.edittask_16x16;
            this.barButtonItem16.Id = 21;
            this.barButtonItem16.LargeGlyph = global::QuanLyThuVien.Properties.Resources.edittask_32x32;
            this.barButtonItem16.Name = "barButtonItem16";
            this.barButtonItem16.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem16_ItemClick);
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "Tác giả";
            this.barButtonItem17.Glyph = global::QuanLyThuVien.Properties.Resources.edittask_16x16;
            this.barButtonItem17.Id = 22;
            this.barButtonItem17.LargeGlyph = global::QuanLyThuVien.Properties.Resources.edittask_32x32;
            this.barButtonItem17.Name = "barButtonItem17";
            this.barButtonItem17.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem17_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Id = 16;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem13.Description = "Máy tính";
            this.barButtonItem13.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.Glyph")));
            this.barButtonItem13.Hint = "Máy tính";
            this.barButtonItem13.Id = 18;
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // barButtonItem18
            // 
            this.barButtonItem18.Caption = "Tiêu hủy sách";
            this.barButtonItem18.Id = 23;
            this.barButtonItem18.ItemAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem18.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem18.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem18.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem18.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem18.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem18.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem18.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem18.ItemInMenuAppearance.Disabled.Options.UseTextOptions = true;
            this.barButtonItem18.ItemInMenuAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem18.ItemInMenuAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem18.ItemInMenuAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem18.ItemInMenuAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem18.ItemInMenuAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem18.ItemInMenuAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem18.ItemInMenuAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem18.Name = "barButtonItem18";
            this.barButtonItem18.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem18.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem18_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Thông tin";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.ribbonGalleryBarItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Giao diện";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem18);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Kho sách";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Thẻ thành viên";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            this.ribbonPageGroup7.Text = "Khác";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Báo cáo";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem13);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 575);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(866, 31);
            // 
            // AlertControl
            // 
            this.AlertControl.AutoFormDelay = 3500;
            this.AlertControl.AutoHeight = true;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 606);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần mềm quản lý thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.Alerter.AlertControl AlertControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.BarButtonItem barButtonItem18;
    }
}