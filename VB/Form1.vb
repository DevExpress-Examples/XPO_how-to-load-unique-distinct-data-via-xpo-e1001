Imports System
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports System.Linq

Namespace Distinct
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
        Private WithEvents XPView As Button
        Private WithEvents LINQ As Button
        Private WithEvents PersAlias As Button
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private ReadOnly components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
                If gridView1 IsNot Nothing Then
                    gridView1.Dispose()
                    gridView1 = Nothing
                End If
                If colCompanyName IsNot Nothing Then
                    colCompanyName.Dispose()
                    colCompanyName = Nothing
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.XPView = New System.Windows.Forms.Button()
            Me.LINQ = New System.Windows.Forms.Button()
            Me.PersAlias = New System.Windows.Forms.Button()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gridControl1.Location = New System.Drawing.Point(0, 59)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(613, 388)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCompanyName})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.AllowCellMerge = True
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCompanyName, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colCompanyName
            ' 
            Me.colCompanyName.Caption = "Company Name"
            Me.colCompanyName.FieldName = "Company Name"
            Me.colCompanyName.Name = "colCompanyName"
            Me.colCompanyName.OptionsColumn.ReadOnly = True
            Me.colCompanyName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
            Me.colCompanyName.Visible = True
            Me.colCompanyName.VisibleIndex = 0
            ' 
            ' XPView
            ' 
            Me.XPView.Location = New System.Drawing.Point(12, 13)
            Me.XPView.Name = "XPView"
            Me.XPView.Size = New System.Drawing.Size(160, 37)
            Me.XPView.TabIndex = 1
            Me.XPView.Text = "XPView"
            Me.XPView.UseVisualStyleBackColor = True
            ' 
            ' LINQ
            ' 
            Me.LINQ.Location = New System.Drawing.Point(213, 13)
            Me.LINQ.Name = "LINQ"
            Me.LINQ.Size = New System.Drawing.Size(193, 37)
            Me.LINQ.TabIndex = 2
            Me.LINQ.Text = "LINQ"
            Me.LINQ.UseVisualStyleBackColor = True
            ' 
            ' PersAlias
            ' 
            Me.PersAlias.Location = New System.Drawing.Point(431, 13)
            Me.PersAlias.Name = "PersAlias"
            Me.PersAlias.Size = New System.Drawing.Size(170, 37)
            Me.PersAlias.TabIndex = 3
            Me.PersAlias.Text = "PersistentAlias"
            Me.PersAlias.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(613, 447)
            Me.Controls.Add(Me.PersAlias)
            Me.Controls.Add(Me.LINQ)
            Me.Controls.Add(Me.XPView)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        #End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            DevExpress.Xpo.XpoDefault.ConnectionString = DevExpress.Xpo.DB.MSSqlConnectionProvider.GetConnectionString(".\SQLEXPRESS", "Northwind")
            Application.Run(New Form1())
        End Sub

        Private Sub LoadViaXPView(ByVal sender As Object, ByVal e As EventArgs) Handles XPView.Click
            Dim xpView1 As New XPView(XpoDefault.Session, GetType(Northwind.Order))
            xpView1.Properties.Add(New DevExpress.Xpo.ViewProperty("Company Name", DevExpress.Xpo.SortDirection.None, "[Customer.CompanyName]", True, True))
            gridControl1.DataSource = xpView1
            RefreshColumns()
        End Sub

        Private Sub LoadViaLINQ(ByVal sender As Object, ByVal e As EventArgs) Handles LINQ.Click
            gridControl1.DataSource = (New XPQuery(Of Northwind.Order)(XpoDefault.Session)).Select(Function(s) s.Customer.CompanyName).Distinct()
            RefreshColumns()
        End Sub

        Private Sub LoadDataWithPersistentAlias(ByVal sender As Object, ByVal e As EventArgs) Handles PersAlias.Click
            gridControl1.DataSource = New XPCollection(Of Northwind.Employee)()
            RefreshColumns()
        End Sub
        Public Sub RefreshColumns()
            gridControl1.MainView.PopulateColumns()
            gridView1.Columns(0).Summary.Add(DevExpress.Data.SummaryItemType.Count)
        End Sub
    End Class
End Namespace