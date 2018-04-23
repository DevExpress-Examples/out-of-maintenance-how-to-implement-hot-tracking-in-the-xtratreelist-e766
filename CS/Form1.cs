// Developer Express Code Central Example:
// How to implement hot tracking in the XtraTreeList
// 
// This example demonstrates how to change the appearance of grid rows when the
// mouse is hovered over them. For more information, please review the
// http://www.devexpress.com/scid=A1099 Knowledge Base Article.
// 
// See also:
// <kblink id = "A998"/>
// TreeList.NodeCellStyle Event
// (ms-help://MS.VSCC.v80/MS.VSIPCC.v80/DevExpress.NETv8.3/DevExpress.XtraTreeList/DevExpressXtraTreeListTreeList_NodeCellStyletopic.htm)
// TreeList.CalcHitInfo
// Method
// (ms-help://MS.VSCC.v80/MS.VSIPCC.v80/DevExpress.NETv8.3/DevExpress.XtraTreeList/DevExpressXtraTreeListTreeList_CalcHitInfotopic.htm)
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E766

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraTreeList;

namespace HotTrack
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;

		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "1",
            null,
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "2",
            null,
            null}, 0);
            this.treeList1.AppendNode(new object[] {
            "3",
            null,
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "4",
            null,
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "5",
            null,
            null}, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.Size = new System.Drawing.Size(485, 169);
            this.treeList1.TabIndex = 1;
            this.treeList1.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.treeList1_NodeCellStyle);
            this.treeList1.MouseLeave += new System.EventHandler(this.treeList1_MouseLeave);
            this.treeList1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseMove);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(485, 169);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "How to implement hot tracking in the XtraTreeList";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

	

		
        private DevExpress.XtraTreeList.Nodes.TreeListNode hotTracNode = null;



        private DevExpress.XtraTreeList.Nodes.TreeListNode HotTracNode
        {
            get
            {
                return hotTracNode;
            }
            set
            {
                if (hotTracNode != value)
                {
                    DevExpress.XtraTreeList.Nodes.TreeListNode prevHotTracNode = hotTracNode;
                    hotTracNode = value;
                    if (treeList1.ActiveEditor != null)
                        treeList1.PostEditor();
                    treeList1.InvalidateNode(prevHotTracNode);
                    treeList1.InvalidateNode(hotTracNode);
                }
            }
        }


			

        private void treeList1_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node == HotTracNode)
                e.Appearance.BackColor = Color.PaleGoldenrod;
        }

        private void treeList1_MouseMove(object sender, MouseEventArgs e)
        {
            DevExpress.XtraTreeList.TreeList treelist = sender as DevExpress.XtraTreeList.TreeList;
            TreeListHitInfo info = treelist.CalcHitInfo(new Point(e.X, e.Y));

            if (info.HitInfoType == HitInfoType.Cell)
                HotTracNode = info.Node;
            else
                HotTracNode = null;
        }

        private void treeList1_MouseLeave(object sender, EventArgs e)
        {
            HotTracNode = null;
        }
	}
}
