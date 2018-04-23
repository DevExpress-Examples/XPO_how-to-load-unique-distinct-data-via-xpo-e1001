using System;
using System.Windows.Forms;
using DevExpress.Xpo;
using System.Linq;

namespace Distinct {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Form {
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private Button XPView;
        private Button LINQ;
        private Button PersAlias;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private readonly System.ComponentModel.Container components = null;

        public Form1() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
                if(gridView1 != null) {
                    gridView1.Dispose();
                    gridView1 = null;
                }
                if(colCompanyName != null) {
                    colCompanyName.Dispose();
                    colCompanyName = null;
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.XPView = new System.Windows.Forms.Button();
            this.LINQ = new System.Windows.Forms.Button();
            this.PersAlias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(613, 388);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCompanyName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "Company Name";
            this.colCompanyName.FieldName = "Company Name";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.OptionsColumn.ReadOnly = true;
            this.colCompanyName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 0;
            // 
            // XPView
            // 
            this.XPView.Location = new System.Drawing.Point(12, 13);
            this.XPView.Name = "XPView";
            this.XPView.Size = new System.Drawing.Size(160, 37);
            this.XPView.TabIndex = 1;
            this.XPView.Text = "XPView";
            this.XPView.UseVisualStyleBackColor = true;
            this.XPView.Click += new System.EventHandler(this.LoadViaXPView);
            // 
            // LINQ
            // 
            this.LINQ.Location = new System.Drawing.Point(213, 13);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(193, 37);
            this.LINQ.TabIndex = 2;
            this.LINQ.Text = "LINQ";
            this.LINQ.UseVisualStyleBackColor = true;
            this.LINQ.Click += new System.EventHandler(this.LoadViaLINQ);
            // 
            // PersAlias
            // 
            this.PersAlias.Location = new System.Drawing.Point(431, 13);
            this.PersAlias.Name = "PersAlias";
            this.PersAlias.Size = new System.Drawing.Size(170, 37);
            this.PersAlias.TabIndex = 3;
            this.PersAlias.Text = "PersistentAlias";
            this.PersAlias.UseVisualStyleBackColor = true;
            this.PersAlias.Click += new System.EventHandler(this.LoadDataWithPersistentAlias);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(613, 447);
            this.Controls.Add(this.PersAlias);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.XPView);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DevExpress.Xpo.XpoDefault.ConnectionString = DevExpress.Xpo.DB.MSSqlConnectionProvider.GetConnectionString(@".\SQLEXPRESS", "Northwind");
            Application.Run(new Form1());
        }

        private void LoadViaXPView(object sender, EventArgs e) {
            XPView xpView1 = new XPView(XpoDefault.Session, typeof(Northwind.Order));
            xpView1.Properties.Add(new DevExpress.Xpo.ViewProperty("Company Name", DevExpress.Xpo.SortDirection.None, "[Customer.CompanyName]", true, true));
            gridControl1.DataSource = xpView1;
            RefreshColumns();
        }

        private void LoadViaLINQ(object sender, EventArgs e) {
            gridControl1.DataSource = new XPQuery<Northwind.Order>(XpoDefault.Session).Select(s => s.Customer.CompanyName).Distinct();
            RefreshColumns();
        }

        private void LoadDataWithPersistentAlias(object sender, EventArgs e) {
            gridControl1.DataSource = new XPCollection<Northwind.Employee>();
            RefreshColumns();
        }
        public void RefreshColumns() {
            gridControl1.MainView.PopulateColumns();
            gridView1.Columns[0].Summary.Add(DevExpress.Data.SummaryItemType.Count);
        }
    }
}