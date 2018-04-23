using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace XtraTreeListHotTrack
{
    public partial class Form1 : Form
    {
        private TreeListNode hotTrackNode = null;

        public Form1()
        {
            InitializeComponent();
        }

        private TreeListNode HotTrackNode
        {
            get { return hotTrackNode; }
            set
            {
                if (hotTrackNode != value)
                {
                    TreeListNode prevHotTrackNode = hotTrackNode;
                    hotTrackNode = value;
                    if (treeList1.ActiveEditor != null)
                        treeList1.PostEditor();
                    treeList1.RefreshNode(prevHotTrackNode);
                    treeList1.RefreshNode(hotTrackNode);
                }
            }
        }

        private void treeList1_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node == HotTrackNode)
                e.Appearance.BackColor = Color.LightBlue;
        }

        private void treeList1_MouseMove(object sender, MouseEventArgs e)
        {
            TreeList treelist = sender as DevExpress.XtraTreeList.TreeList;
            TreeListHitInfo info = treelist.CalcHitInfo(new Point(e.X, e.Y));
            HotTrackNode = info.HitInfoType == HitInfoType.Cell ? info.Node : null;
        }

        private void treeList1_MouseLeave(object sender, EventArgs e)
        { HotTrackNode = null; }
    }
}
