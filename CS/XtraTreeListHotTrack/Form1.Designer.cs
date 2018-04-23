namespace XtraTreeListHotTrack
{
    partial class Form1
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "1",
            null,
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "1.1",
            null,
            null}, 0);
            this.treeList1.AppendNode(new object[] {
            "2",
            null,
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "2.1",
            null,
            null}, 2);
            this.treeList1.AppendNode(new object[] {
            "3",
            null,
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "3.1",
            null,
            null}, 4);
            this.treeList1.AppendNode(new object[] {
            "4",
            null,
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "4.1",
            null,
            null}, 6);
            this.treeList1.AppendNode(new object[] {
            "5",
            null,
            null}, -1);
            this.treeList1.AppendNode(new object[] {
            "5.1",
            null,
            null}, 8);
            this.treeList1.EndUnboundLoad();
            this.treeList1.Size = new System.Drawing.Size(424, 262);
            this.treeList1.TabIndex = 0;
            this.treeList1.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.treeList1_NodeCellStyle);
            this.treeList1.MouseLeave += new System.EventHandler(this.treeList1_MouseLeave);
            this.treeList1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseMove);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.MinWidth = 52;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "treeListColumn2";
            this.treeListColumn2.FieldName = "treeListColumn2";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "treeListColumn3";
            this.treeListColumn3.FieldName = "treeListColumn3";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 262);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
    }
}

