' Developer Express Code Central Example:
' How to implement hot tracking in the XtraTreeList
' 
' This example demonstrates how to change the appearance of grid rows when the
' mouse is hovered over them. For more information, please review the
' http://www.devexpress.com/scid=A1099 Knowledge Base Article.
' 
' See also:
' <kblink id = "A998"/>
' TreeList.NodeCellStyle Event
' (ms-help://MS.VSCC.v80/MS.VSIPCC.v80/DevExpress.NETv8.3/DevExpress.XtraTreeList/DevExpressXtraTreeListTreeList_NodeCellStyletopic.htm)
' TreeList.CalcHitInfo
' Method
' (ms-help://MS.VSCC.v80/MS.VSIPCC.v80/DevExpress.NETv8.3/DevExpress.XtraTreeList/DevExpressXtraTreeListTreeList_CalcHitInfotopic.htm)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E766


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraTreeList

Namespace HotTrack
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn

		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			InitializeComponent()
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
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
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.BeginUnboundLoad()
			Me.treeList1.AppendNode(New Object() { "1", Nothing, Nothing}, -1)
			Me.treeList1.AppendNode(New Object() { "2", Nothing, Nothing}, 0)
			Me.treeList1.AppendNode(New Object() { "3", Nothing, Nothing}, -1)
			Me.treeList1.AppendNode(New Object() { "4", Nothing, Nothing}, -1)
			Me.treeList1.AppendNode(New Object() { "5", Nothing, Nothing}, -1)
			Me.treeList1.EndUnboundLoad()
			Me.treeList1.Size = New System.Drawing.Size(485, 169)
			Me.treeList1.TabIndex = 1
'			Me.treeList1.NodeCellStyle += New DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(Me.treeList1_NodeCellStyle);
'			Me.treeList1.MouseLeave += New System.EventHandler(Me.treeList1_MouseLeave);
'			Me.treeList1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.treeList1_MouseMove);
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "treeListColumn1"
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(485, 169)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "How to implement hot tracking in the XtraTreeList"
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub




		Private hotTracNode_Renamed As DevExpress.XtraTreeList.Nodes.TreeListNode = Nothing



		Private Property HotTracNode() As DevExpress.XtraTreeList.Nodes.TreeListNode
			Get
				Return hotTracNode_Renamed
			End Get
			Set(ByVal value As DevExpress.XtraTreeList.Nodes.TreeListNode)
				If hotTracNode_Renamed IsNot value Then
					Dim prevHotTracNode As DevExpress.XtraTreeList.Nodes.TreeListNode = hotTracNode_Renamed
					hotTracNode_Renamed = value
					If treeList1.ActiveEditor IsNot Nothing Then
						treeList1.PostEditor()
					End If
					treeList1.InvalidateNode(prevHotTracNode)
					treeList1.InvalidateNode(hotTracNode_Renamed)
				End If
			End Set
		End Property




		Private Sub treeList1_NodeCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs) Handles treeList1.NodeCellStyle
			If e.Node Is HotTracNode Then
				e.Appearance.BackColor = Color.PaleGoldenrod
			End If
		End Sub

		Private Sub treeList1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles treeList1.MouseMove
			Dim treelist As DevExpress.XtraTreeList.TreeList = TryCast(sender, DevExpress.XtraTreeList.TreeList)
			Dim info As TreeListHitInfo = treelist.CalcHitInfo(New Point(e.X, e.Y))

			If info.HitInfoType = HitInfoType.Cell Then
				HotTracNode = info.Node
			Else
				HotTracNode = Nothing
			End If
		End Sub

		Private Sub treeList1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles treeList1.MouseLeave
			HotTracNode = Nothing
		End Sub
	End Class
End Namespace
