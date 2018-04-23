Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace XtraTreeListHotTrack
	Partial Public Class Form1
		Inherits Form
		Private hotTrackNode_Renamed As TreeListNode = Nothing

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Property HotTrackNode() As TreeListNode
			Get
				Return hotTrackNode_Renamed
			End Get
			Set(ByVal value As TreeListNode)
				If hotTrackNode_Renamed IsNot value Then
					Dim prevHotTrackNode As TreeListNode = hotTrackNode_Renamed
					hotTrackNode_Renamed = value
					If treeList1.ActiveEditor IsNot Nothing Then
						treeList1.PostEditor()
					End If
					treeList1.RefreshNode(prevHotTrackNode)
					treeList1.RefreshNode(hotTrackNode_Renamed)
				End If
			End Set
		End Property

		Private Sub treeList1_NodeCellStyle(ByVal sender As Object, ByVal e As GetCustomNodeCellStyleEventArgs) Handles treeList1.NodeCellStyle
			If e.Node Is HotTrackNode Then
				e.Appearance.BackColor = Color.LightBlue
			End If
		End Sub

		Private Sub treeList1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles treeList1.MouseMove
			Dim treelist As TreeList = TryCast(sender, DevExpress.XtraTreeList.TreeList)
			Dim info As TreeListHitInfo = treelist.CalcHitInfo(New Point(e.X, e.Y))
			HotTrackNode = If(info.HitInfoType = HitInfoType.Cell, info.Node, Nothing)
		End Sub

		Private Sub treeList1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles treeList1.MouseLeave
			HotTrackNode = Nothing
		End Sub
	End Class
End Namespace
