Imports System
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

        Private XPView As Button

        Private LINQ As Button

        Private PersAlias As Button

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
            gridControl1 = New DevExpress.XtraGrid.GridControl()
            gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
            XPView = New Windows.Forms.Button()
            LINQ = New Windows.Forms.Button()
            PersAlias = New Windows.Forms.Button()
            CType(gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            gridControl1.Cursor = Windows.Forms.Cursors.[Default]
            gridControl1.Dock = Windows.Forms.DockStyle.Bottom
            gridControl1.Location = New System.Drawing.Point(0, 59)
            gridControl1.MainView = gridView1
            gridControl1.Name = "gridControl1"
            gridControl1.Size = New System.Drawing.Size(613, 388)
            gridControl1.TabIndex = 0
            gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {gridView1})
            ' 
            ' gridView1
            ' 
            gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {colCompanyName})
            gridView1.GridControl = gridControl1
            gridView1.Name = "gridView1"
            gridView1.OptionsView.AllowCellMerge = True
            gridView1.OptionsView.ShowFooter = True
            gridView1.OptionsView.ShowGroupPanel = False
            gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(colCompanyName, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colCompanyName
            ' 
            colCompanyName.Caption = "Company Name"
            colCompanyName.FieldName = "Company Name"
            colCompanyName.Name = "colCompanyName"
            colCompanyName.OptionsColumn.ReadOnly = True
            colCompanyName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
            colCompanyName.Visible = True
            colCompanyName.VisibleIndex = 0
            ' 
            ' XPView
            ' 
            XPView.Location = New System.Drawing.Point(12, 13)
            XPView.Name = "XPView"
            XPView.Size = New System.Drawing.Size(160, 37)
            XPView.TabIndex = 1
            XPView.Text = "XPView"
            XPView.UseVisualStyleBackColor = True
             ''' Cannot convert AssignmentExpressionSyntax, System.NullReferenceException: Object reference not set to an instance of an object.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''             this.XPView.Click += new System.EventHandler(this.LoadViaXPView)
'''  ' 
            ' LINQ
            ' 
LINQ.Location = New System.Drawing.Point(213, 13)
            LINQ.Name = "LINQ"
            LINQ.Size = New System.Drawing.Size(193, 37)
            LINQ.TabIndex = 2
            LINQ.Text = "LINQ"
            LINQ.UseVisualStyleBackColor = True
             ''' Cannot convert AssignmentExpressionSyntax, System.NullReferenceException: Object reference not set to an instance of an object.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''             this.LINQ.Click += new System.EventHandler(this.LoadViaLINQ)
'''  ' 
            ' PersAlias
            ' 
PersAlias.Location = New System.Drawing.Point(431, 13)
            PersAlias.Name = "PersAlias"
            PersAlias.Size = New System.Drawing.Size(170, 37)
            PersAlias.TabIndex = 3
            PersAlias.Text = "PersistentAlias"
            PersAlias.UseVisualStyleBackColor = True
             ''' Cannot convert AssignmentExpressionSyntax, System.NullReferenceException: Object reference not set to an instance of an object.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitAssignmentExpression(AssignmentExpressionSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''             this.PersAlias.Click += new System.EventHandler(this.LoadDataWithPersistentAlias)
'''  ' 
            ' Form1
            ' 
Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(613, 447)
            Me.Controls.Add(PersAlias)
            Me.Controls.Add(LINQ)
            Me.Controls.Add(XPView)
            Me.Controls.Add(gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            XpoDefault.ConnectionString = DB.MSSqlConnectionProvider.GetConnectionString(".\SQLEXPRESS", "Northwind")
            Application.Run(New Form1())
        End Sub

        Private Sub LoadViaXPView(ByVal sender As Object, ByVal e As EventArgs)
            Dim xpView1 As XPView = New XPView(XpoDefault.Session, GetType(Northwind.Order))
            xpView1.Properties.Add(New ViewProperty("Company Name", SortDirection.None, "[Customer.CompanyName]", True, True))
            gridControl1.DataSource = xpView1
            RefreshColumns()
        End Sub

        Private Sub LoadViaLINQ(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.DataSource = New XPQuery(Of Northwind.Order)(XpoDefault.Session).[Select](Function(s) s.Customer.CompanyName).Distinct()
            RefreshColumns()
        End Sub

        Private Sub LoadDataWithPersistentAlias(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.DataSource = New XPCollection(Of Northwind.Employee)()
            RefreshColumns()
        End Sub

        Public Sub RefreshColumns()
            gridControl1.MainView.PopulateColumns()
            gridView1.Columns(0).Summary.Add(DevExpress.Data.SummaryItemType.Count)
        End Sub
    End Class
End Namespace
