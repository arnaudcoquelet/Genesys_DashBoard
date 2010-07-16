namespace Genesys_DashBoard
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.DashBoardTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ReportingLink = new System.Windows.Forms.Label();
            this.GVPLink = new System.Windows.Forms.Label();
            this.InfomartLink = new System.Windows.Forms.Label();
            this.SNMPLink = new System.Windows.Forms.Label();
            this.SCSLink = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ResultTab = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.SnmpHDDResultListView = new System.Windows.Forms.ListView();
            this.SnmpResultContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.SnmpCPUResultListView = new System.Windows.Forms.ListView();
            this.CPUResultContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearCPUMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportCPUResultMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.SnmpHostListView = new System.Windows.Forms.ListView();
            this.SnmpHostContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLastErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ProgressStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FailedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressFailedLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DashBoardTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.ResultTab.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SnmpResultContextMenu.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.CPUResultContextMenuStrip.SuspendLayout();
            this.SnmpHostContextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashBoardTab
            // 
            this.DashBoardTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DashBoardTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.DashBoardTab.Controls.Add(this.tabPage1);
            this.DashBoardTab.Controls.Add(this.tabPage2);
            this.DashBoardTab.Controls.Add(this.tabPage3);
            this.DashBoardTab.Controls.Add(this.tabPage4);
            this.DashBoardTab.Controls.Add(this.tabPage5);
            this.DashBoardTab.Controls.Add(this.tabPage6);
            this.DashBoardTab.Location = new System.Drawing.Point(0, 27);
            this.DashBoardTab.Name = "DashBoardTab";
            this.DashBoardTab.SelectedIndex = 0;
            this.DashBoardTab.Size = new System.Drawing.Size(532, 372);
            this.DashBoardTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ReportingLink);
            this.tabPage1.Controls.Add(this.GVPLink);
            this.tabPage1.Controls.Add(this.InfomartLink);
            this.tabPage1.Controls.Add(this.SNMPLink);
            this.tabPage1.Controls.Add(this.SCSLink);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ReportingLink
            // 
            this.ReportingLink.AutoSize = true;
            this.ReportingLink.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportingLink.Location = new System.Drawing.Point(56, 203);
            this.ReportingLink.Name = "ReportingLink";
            this.ReportingLink.Size = new System.Drawing.Size(116, 23);
            this.ReportingLink.TabIndex = 9;
            this.ReportingLink.Text = "Reporting";
            this.ReportingLink.Click += new System.EventHandler(this.ReportingLink_Click);
            // 
            // GVPLink
            // 
            this.GVPLink.AutoSize = true;
            this.GVPLink.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVPLink.Location = new System.Drawing.Point(56, 162);
            this.GVPLink.Name = "GVPLink";
            this.GVPLink.Size = new System.Drawing.Size(128, 23);
            this.GVPLink.TabIndex = 8;
            this.GVPLink.Text = "GVP status";
            this.GVPLink.Click += new System.EventHandler(this.GVPLink_Click);
            // 
            // InfomartLink
            // 
            this.InfomartLink.AutoSize = true;
            this.InfomartLink.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfomartLink.Location = new System.Drawing.Point(56, 119);
            this.InfomartLink.Name = "InfomartLink";
            this.InfomartLink.Size = new System.Drawing.Size(158, 23);
            this.InfomartLink.TabIndex = 7;
            this.InfomartLink.Text = "Infomart jobs";
            this.InfomartLink.Click += new System.EventHandler(this.InfomartLink_Click);
            // 
            // SNMPLink
            // 
            this.SNMPLink.AutoSize = true;
            this.SNMPLink.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNMPLink.Location = new System.Drawing.Point(56, 73);
            this.SNMPLink.Name = "SNMPLink";
            this.SNMPLink.Size = new System.Drawing.Size(146, 23);
            this.SNMPLink.TabIndex = 6;
            this.SNMPLink.Text = "SNMP status";
            this.SNMPLink.Click += new System.EventHandler(this.SNMPLink_Click);
            // 
            // SCSLink
            // 
            this.SCSLink.AutoSize = true;
            this.SCSLink.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCSLink.Location = new System.Drawing.Point(56, 29);
            this.SCSLink.Name = "SCSLink";
            this.SCSLink.Size = new System.Drawing.Size(103, 23);
            this.SCSLink.TabIndex = 5;
            this.SCSLink.Text = "SCS logs";
            this.SCSLink.Click += new System.EventHandler(this.SCSLink_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SCS Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ResultTab);
            this.tabPage3.Controls.Add(this.SnmpHostListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(524, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SNMP Status";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ResultTab
            // 
            this.ResultTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ResultTab.Controls.Add(this.tabPage7);
            this.ResultTab.Controls.Add(this.tabPage8);
            this.ResultTab.Location = new System.Drawing.Point(191, 6);
            this.ResultTab.Name = "ResultTab";
            this.ResultTab.SelectedIndex = 0;
            this.ResultTab.Size = new System.Drawing.Size(327, 334);
            this.ResultTab.TabIndex = 4;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.SnmpHDDResultListView);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(319, 305);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "HDD";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // SnmpHDDResultListView
            // 
            this.SnmpHDDResultListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SnmpHDDResultListView.ContextMenuStrip = this.SnmpResultContextMenu;
            this.SnmpHDDResultListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SnmpHDDResultListView.FullRowSelect = true;
            this.SnmpHDDResultListView.GridLines = true;
            this.SnmpHDDResultListView.HideSelection = false;
            this.SnmpHDDResultListView.LabelWrap = false;
            this.SnmpHDDResultListView.Location = new System.Drawing.Point(3, 3);
            this.SnmpHDDResultListView.MultiSelect = false;
            this.SnmpHDDResultListView.Name = "SnmpHDDResultListView";
            this.SnmpHDDResultListView.OwnerDraw = true;
            this.SnmpHDDResultListView.Size = new System.Drawing.Size(313, 299);
            this.SnmpHDDResultListView.TabIndex = 3;
            this.SnmpHDDResultListView.UseCompatibleStateImageBehavior = false;
            this.SnmpHDDResultListView.View = System.Windows.Forms.View.Details;
            this.SnmpHDDResultListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SnmpHDDResultListView_ColumnClick);
            this.SnmpHDDResultListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.SnmpHDDResultListView_DrawColumnHeader);
            this.SnmpHDDResultListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.SnmpHDDResultListView_DrawItem);
            // 
            // SnmpResultContextMenu
            // 
            this.SnmpResultContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exportToolStripMenuItem1});
            this.SnmpResultContextMenu.Name = "ResultContextMenu";
            this.SnmpResultContextMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toFileToolStripMenuItem});
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.exportToolStripMenuItem1.Text = "Export";
            // 
            // toFileToolStripMenuItem
            // 
            this.toFileToolStripMenuItem.Name = "toFileToolStripMenuItem";
            this.toFileToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.toFileToolStripMenuItem.Text = "To File";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.SnmpCPUResultListView);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(319, 305);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "CPU";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // SnmpCPUResultListView
            // 
            this.SnmpCPUResultListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SnmpCPUResultListView.ContextMenuStrip = this.CPUResultContextMenuStrip;
            this.SnmpCPUResultListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SnmpCPUResultListView.FullRowSelect = true;
            this.SnmpCPUResultListView.GridLines = true;
            this.SnmpCPUResultListView.HideSelection = false;
            this.SnmpCPUResultListView.LabelWrap = false;
            this.SnmpCPUResultListView.Location = new System.Drawing.Point(3, 3);
            this.SnmpCPUResultListView.MultiSelect = false;
            this.SnmpCPUResultListView.Name = "SnmpCPUResultListView";
            this.SnmpCPUResultListView.OwnerDraw = true;
            this.SnmpCPUResultListView.Size = new System.Drawing.Size(313, 299);
            this.SnmpCPUResultListView.TabIndex = 4;
            this.SnmpCPUResultListView.UseCompatibleStateImageBehavior = false;
            this.SnmpCPUResultListView.View = System.Windows.Forms.View.Details;
            this.SnmpCPUResultListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SnmpCPUResultListView_ColumnClick);
            this.SnmpCPUResultListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.SnmpCPUResultListView_DrawColumnHeader);
            this.SnmpCPUResultListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.SnmpCPUResultListView_DrawItem);
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
            // 
            // ExportCPUResultMenuItem
            // 
            this.ExportCPUResultMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.ExportCPUResultMenuItem.Name = "ExportCPUResultMenuItem";
            this.ExportCPUResultMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ExportCPUResultMenuItem.Text = "Export";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem4.Text = "To File";
            // 
            // SnmpHostListView
            // 
            this.SnmpHostListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.SnmpHostListView.ContextMenuStrip = this.SnmpHostContextMenu;
            this.SnmpHostListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnmpHostListView.FullRowSelect = true;
            this.SnmpHostListView.Location = new System.Drawing.Point(6, 31);
            this.SnmpHostListView.MultiSelect = false;
            this.SnmpHostListView.Name = "SnmpHostListView";
            this.SnmpHostListView.OwnerDraw = true;
            this.SnmpHostListView.Size = new System.Drawing.Size(179, 299);
            this.SnmpHostListView.TabIndex = 2;
            this.SnmpHostListView.UseCompatibleStateImageBehavior = false;
            this.SnmpHostListView.View = System.Windows.Forms.View.Details;
            this.SnmpHostListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SnmpHostListView_ColumnClick);
            this.SnmpHostListView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.SnmpHostListView_DrawColumnHeader);
            this.SnmpHostListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.SnmpHostListView_DrawItem);
            // 
            // SnmpHostContextMenu
            // 
            this.SnmpHostContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator5,
            this.editToolStripMenuItem,
            this.toolStripSeparator4,
            this.pollToolStripMenuItem,
            this.showLastErrorToolStripMenuItem});
            this.SnmpHostContextMenu.Name = "HostContextMenu";
            this.SnmpHostContextMenu.Size = new System.Drawing.Size(159, 126);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
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
            // 
            // showLastErrorToolStripMenuItem
            // 
            this.showLastErrorToolStripMenuItem.Name = "showLastErrorToolStripMenuItem";
            this.showLastErrorToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.showLastErrorToolStripMenuItem.Text = "Show last error";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(524, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "InforMart jobs";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(524, 343);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "GVP Status";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(524, 343);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Historical Reports";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessBtn.Location = new System.Drawing.Point(4, 405);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(524, 23);
            this.ProcessBtn.TabIndex = 1;
            this.ProcessBtn.Text = "Process >>";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressLabel,
            this.ProgressBar,
            this.ProgressStatusLabel,
            this.FailedLabel,
            this.ProgressFailedLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(532, 22);
            this.statusStrip1.TabIndex = 6;
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
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 7;
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
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveToolStripMenuItem.Text = "Save";
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
            // 
            // exportResultsToolStripMenuItem
            // 
            this.exportResultsToolStripMenuItem.Name = "exportResultsToolStripMenuItem";
            this.exportResultsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exportResultsToolStripMenuItem.Text = "To File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "blue.png");
            this.imageList1.Images.SetKeyName(1, "green.png");
            this.imageList1.Images.SetKeyName(2, "yellow.png");
            this.imageList1.Images.SetKeyName(3, "orange.png");
            this.imageList1.Images.SetKeyName(4, "red.png");
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.DashBoardTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 480);
            this.Name = "Dashboard";
            this.Text = "DashBoard";
            this.DashBoardTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResultTab.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.SnmpResultContextMenu.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.CPUResultContextMenuStrip.ResumeLayout(false);
            this.SnmpHostContextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl DashBoardTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ProgressLabel;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel ProgressStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel FailedLabel;
        private System.Windows.Forms.ToolStripStatusLabel ProgressFailedLabel;
        private System.Windows.Forms.ContextMenuStrip SnmpHostContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem pollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLastErrorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CPUResultContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClearCPUMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportCPUResultMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
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
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip SnmpResultContextMenu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toFileToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl ResultTab;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListView SnmpHDDResultListView;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.ListView SnmpCPUResultListView;
        private System.Windows.Forms.ListView SnmpHostListView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label ReportingLink;
        private System.Windows.Forms.Label GVPLink;
        private System.Windows.Forms.Label InfomartLink;
        private System.Windows.Forms.Label SNMPLink;
        private System.Windows.Forms.Label SCSLink;
    }
}

