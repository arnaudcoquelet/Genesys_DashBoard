namespace Genesys_DashBoard
{
    partial class HddSnmpMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HddSnmpMonitor));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ProgressStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FailedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressFailedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HostContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLastErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ScanBtn = new System.Windows.Forms.Button();
            this.HostListView = new System.Windows.Forms.ListView();
            this.ResultTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.HDDResultListView = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CPUResultListView = new System.Windows.Forms.ListView();
            this.CPUResultContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearCPUMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportCPUResultMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromHostFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pollAllHostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.HostContextMenu.SuspendLayout();
            this.ResultContextMenu.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ResultTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.CPUResultContextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressLabel,
            this.ProgressBar,
            this.ProgressStatusLabel,
            this.FailedLabel,
            this.ProgressFailedLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 363);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(472, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(49, 17);
            this.ProgressLabel.Text = "Progress";
            this.ProgressLabel.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.Visible = false;
            // 
            // ProgressStatusLabel
            // 
            this.ProgressStatusLabel.Name = "ProgressStatusLabel";
            this.ProgressStatusLabel.Size = new System.Drawing.Size(23, 17);
            this.ProgressStatusLabel.Text = "0/0";
            this.ProgressStatusLabel.Visible = false;
            // 
            // FailedLabel
            // 
            this.FailedLabel.Name = "FailedLabel";
            this.FailedLabel.Size = new System.Drawing.Size(125, 17);
            this.FailedLabel.Text = "                              Failed";
            this.FailedLabel.Visible = false;
            // 
            // ProgressFailedLabel
            // 
            this.ProgressFailedLabel.Name = "ProgressFailedLabel";
            this.ProgressFailedLabel.Size = new System.Drawing.Size(23, 17);
            this.ProgressFailedLabel.Text = "0/0";
            this.ProgressFailedLabel.Visible = false;
            // 
            // HostContextMenu
            // 
            this.HostContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator5,
            this.editToolStripMenuItem,
            this.toolStripSeparator4,
            this.pollToolStripMenuItem,
            this.showLastErrorToolStripMenuItem});
            this.HostContextMenu.Name = "HostContextMenu";
            this.HostContextMenu.Size = new System.Drawing.Size(159, 126);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // pollToolStripMenuItem
            // 
            this.pollToolStripMenuItem.Enabled = false;
            this.pollToolStripMenuItem.Name = "pollToolStripMenuItem";
            this.pollToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pollToolStripMenuItem.Text = "Scan";
            this.pollToolStripMenuItem.Click += new System.EventHandler(this.pollToolStripMenuItem_Click);
            // 
            // showLastErrorToolStripMenuItem
            // 
            this.showLastErrorToolStripMenuItem.Name = "showLastErrorToolStripMenuItem";
            this.showLastErrorToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.showLastErrorToolStripMenuItem.Text = "Show last error";
            this.showLastErrorToolStripMenuItem.Click += new System.EventHandler(this.showLastErrorToolStripMenuItem_Click);
            // 
            // ResultContextMenu
            // 
            this.ResultContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exportToolStripMenuItem1});
            this.ResultContextMenu.Name = "ResultContextMenu";
            this.ResultContextMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toFileToolStripMenuItem});
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.exportToolStripMenuItem1.Text = "Export";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
            // 
            // toFileToolStripMenuItem
            // 
            this.toFileToolStripMenuItem.Name = "toFileToolStripMenuItem";
            this.toFileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.toFileToolStripMenuItem.Text = "To File";
            this.toFileToolStripMenuItem.Click += new System.EventHandler(this.toFileToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ScanBtn);
            this.splitContainer1.Panel1.Controls.Add(this.HostListView);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ResultTab);
            this.splitContainer1.Size = new System.Drawing.Size(472, 361);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.TabIndex = 4;
            // 
            // ScanBtn
            // 
            this.ScanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ScanBtn.Location = new System.Drawing.Point(6, 310);
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.Size = new System.Drawing.Size(104, 23);
            this.ScanBtn.TabIndex = 3;
            this.ScanBtn.Text = "Scan all >>";
            this.ScanBtn.UseVisualStyleBackColor = true;
            this.ScanBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // HostListView
            // 
            this.HostListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.HostListView.ContextMenuStrip = this.HostContextMenu;
            this.HostListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostListView.FullRowSelect = true;
            this.HostListView.Location = new System.Drawing.Point(6, 3);
            this.HostListView.MultiSelect = false;
            this.HostListView.Name = "HostListView";
            this.HostListView.OwnerDraw = true;
            this.HostListView.Size = new System.Drawing.Size(104, 301);
            this.HostListView.TabIndex = 2;
            this.HostListView.UseCompatibleStateImageBehavior = false;
            this.HostListView.View = System.Windows.Forms.View.Details;
            this.HostListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.HostListView_ColumnClick);
            this.HostListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.HostListView_DrawColumnHeader);
            this.HostListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.HostListView_DrawItem);
            this.HostListView.SelectedIndexChanged += new System.EventHandler(this.HostListView_SelectedIndexChanged);
            // 
            // ResultTab
            // 
            this.ResultTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTab.Controls.Add(this.tabPage1);
            this.ResultTab.Controls.Add(this.tabPage2);
            this.ResultTab.Location = new System.Drawing.Point(3, 3);
            this.ResultTab.Name = "ResultTab";
            this.ResultTab.SelectedIndex = 0;
            this.ResultTab.Size = new System.Drawing.Size(352, 333);
            this.ResultTab.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.HDDResultListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HDD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // HDDResultListView
            // 
            this.HDDResultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.HDDResultListView.ContextMenuStrip = this.ResultContextMenu;
            this.HDDResultListView.FullRowSelect = true;
            this.HDDResultListView.GridLines = true;
            this.HDDResultListView.HideSelection = false;
            this.HDDResultListView.LabelWrap = false;
            this.HDDResultListView.Location = new System.Drawing.Point(0, 0);
            this.HDDResultListView.MultiSelect = false;
            this.HDDResultListView.Name = "HDDResultListView";
            this.HDDResultListView.OwnerDraw = true;
            this.HDDResultListView.Size = new System.Drawing.Size(344, 307);
            this.HDDResultListView.TabIndex = 3;
            this.HDDResultListView.UseCompatibleStateImageBehavior = false;
            this.HDDResultListView.View = System.Windows.Forms.View.Details;
            this.HDDResultListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.HDDResultListView_ColumnClick);
            this.HDDResultListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.HDDResultListView_DrawColumnHeader);
            this.HDDResultListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.HDDResultListView_DrawItem);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CPUResultListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CPU";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CPUResultListView
            // 
            this.CPUResultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUResultListView.ContextMenuStrip = this.CPUResultContextMenuStrip;
            this.CPUResultListView.FullRowSelect = true;
            this.CPUResultListView.GridLines = true;
            this.CPUResultListView.HideSelection = false;
            this.CPUResultListView.LabelWrap = false;
            this.CPUResultListView.Location = new System.Drawing.Point(1, 0);
            this.CPUResultListView.MultiSelect = false;
            this.CPUResultListView.Name = "CPUResultListView";
            this.CPUResultListView.OwnerDraw = true;
            this.CPUResultListView.Size = new System.Drawing.Size(569, 597);
            this.CPUResultListView.TabIndex = 4;
            this.CPUResultListView.UseCompatibleStateImageBehavior = false;
            this.CPUResultListView.View = System.Windows.Forms.View.Details;
            this.CPUResultListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.CPUResultListView_ColumnClick);
            this.CPUResultListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.CPUResultListView_DrawColumnHeader);
            this.CPUResultListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.CPUResultListView_DrawItem);
            // 
            // CPUResultContextMenuStrip
            // 
            this.CPUResultContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearCPUMenuItem,
            this.ExportCPUResultMenuItem});
            this.CPUResultContextMenuStrip.Name = "ResultContextMenu";
            this.CPUResultContextMenuStrip.Size = new System.Drawing.Size(118, 48);
            // 
            // ClearCPUMenuItem
            // 
            this.ClearCPUMenuItem.Name = "ClearCPUMenuItem";
            this.ClearCPUMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ClearCPUMenuItem.Text = "Clear";
            this.ClearCPUMenuItem.Click += new System.EventHandler(this.ClearCPUMenuItem_Click);
            // 
            // ExportCPUResultMenuItem
            // 
            this.ExportCPUResultMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.ExportCPUResultMenuItem.Name = "ExportCPUResultMenuItem";
            this.ExportCPUResultMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ExportCPUResultMenuItem.Text = "Export";
            this.ExportCPUResultMenuItem.Click += new System.EventHandler(this.ExportCPUResultMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem4.Text = "To File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.snmpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromHostFileToolStripMenuItem});
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "Import";
            // 
            // fromHostFileToolStripMenuItem
            // 
            this.fromHostFileToolStripMenuItem.Name = "fromHostFileToolStripMenuItem";
            this.fromHostFileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.fromHostFileToolStripMenuItem.Text = "From Host file";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(114, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // snmpToolStripMenuItem
            // 
            this.snmpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pollAllHostsToolStripMenuItem,
            this.toolStripSeparator3,
            this.exportToolStripMenuItem});
            this.snmpToolStripMenuItem.Name = "snmpToolStripMenuItem";
            this.snmpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.snmpToolStripMenuItem.Text = "Snmp";
            // 
            // pollAllHostsToolStripMenuItem
            // 
            this.pollAllHostsToolStripMenuItem.Name = "pollAllHostsToolStripMenuItem";
            this.pollAllHostsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pollAllHostsToolStripMenuItem.Text = "Scan all hosts";
            this.pollAllHostsToolStripMenuItem.Click += new System.EventHandler(this.pollAllHostsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(147, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportResultsToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exportResultsToolStripMenuItem
            // 
            this.exportResultsToolStripMenuItem.Name = "exportResultsToolStripMenuItem";
            this.exportResultsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exportResultsToolStripMenuItem.Text = "To File";
            this.exportResultsToolStripMenuItem.Click += new System.EventHandler(this.exportResultsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // HddSnmpMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 385);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HddSnmpMonitor";
            this.Text = "Hdd Snmp Monitor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.HostContextMenu.ResumeLayout(false);
            this.ResultContextMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResultTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.CPUResultContextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ProgressLabel;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel ProgressStatusLabel;
        private System.Windows.Forms.ContextMenuStrip HostContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem pollToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ResultContextMenu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toFileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fromHostFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pollAllHostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportResultsToolStripMenuItem;
        private System.Windows.Forms.ListView HostListView;
        private System.Windows.Forms.ListView HDDResultListView;
        private System.Windows.Forms.Button ScanBtn;
        private System.Windows.Forms.ToolStripMenuItem showLastErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel FailedLabel;
        private System.Windows.Forms.ToolStripStatusLabel ProgressFailedLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl ResultTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView CPUResultListView;
        private System.Windows.Forms.ContextMenuStrip CPUResultContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClearCPUMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportCPUResultMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}