using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Genesys_DashBoard
{
    public partial class HddSnmpMonitor : Form
    {
        private ListViewColumnSorter HostlvwColumnSorter;
        private ListViewColumnSorter HDDResultlvwColumnSorter;
        private ListViewColumnSorter CPUResultlvwColumnSorter;

        public HddSnmpMonitor()
        {
            InitializeComponent();

            //Host List
            HostListView.Columns.Add("HostName").Width=150;
            HostListView.Columns.Add("Port").Width=0;
            HostListView.Columns.Add("Communtity").Width = 0;
            HostListView.Columns.Add("Version").Width = 0;
            HostListView.Columns.Add("User").Width = 0;
            HostListView.Columns.Add("Password").Width = 0;
            HostListView.Columns.Add("Error").Width = 0;

            HostlvwColumnSorter = new ListViewColumnSorter();
            HostListView.ListViewItemSorter = HostlvwColumnSorter;
            

            //HDD Results List
            HDDResultListView.Columns.Add("id").Width=0;
            HDDResultListView.Columns.Add("HostName").Width=150;
            HDDResultListView.Columns.Add("Disk").TextAlign= HorizontalAlignment.Center;
            HDDResultListView.Columns.Add("%Free").TextAlign = HorizontalAlignment.Center;
            HDDResultListView.Columns.Add("Size").TextAlign = HorizontalAlignment.Center;
            HDDResultListView.Columns.Add("Used").TextAlign = HorizontalAlignment.Center;
            HDDResultListView.Columns.Add("Free").TextAlign = HorizontalAlignment.Center;

            HDDResultlvwColumnSorter = new ListViewColumnSorter();
            HDDResultListView.ListViewItemSorter = HDDResultlvwColumnSorter;

            //CPU Results List
            CPUResultListView.Columns.Add("id").Width = 0;
            CPUResultListView.Columns.Add("HostName").Width = 150;
            CPUResultListView.Columns.Add("CPU Id").TextAlign = HorizontalAlignment.Center;
            CPUResultListView.Columns.Add("CPU Load").TextAlign = HorizontalAlignment.Center;

            CPUResultlvwColumnSorter = new ListViewColumnSorter();
            CPUResultListView.ListViewItemSorter = CPUResultlvwColumnSorter;


            string currentPath = Directory.GetCurrentDirectory();
            IniFile ini = new IniFile(currentPath + "\\config.ini");
            if (ini.Exists())
            {
                loadConfigFile();
            }
        }

        private void initSnmpTab()
        { 
        
        }

        private void loadConfigFile()
        {
            string currentPath = Directory.GetCurrentDirectory();
            IniFile ini = new IniFile(currentPath + "\\config.ini");
            if (ini.Exists())
            {
                ini.Load();
            }

            foreach (string section in ini.GetSections())
            {
                ListViewItem lst = HostListView.Items.Add(ini[section]["HostName"]);
                lst.SubItems.Add(ini[section]["Port"]);
                lst.SubItems.Add(ini[section]["Community"]);
                lst.SubItems.Add(ini[section]["Version"]);
                lst.SubItems.Add(ini[section]["User"]);
                lst.SubItems.Add(ini[section]["Password"]);
                lst.SubItems.Add(""); //SnmpError field
            }
        }

        private void saveConfigFile()
        {
            string currentPath = Directory.GetCurrentDirectory();
            IniFile ini = new IniFile(currentPath + "\\config.ini");

            foreach (ListViewItem lsti in HostListView.Items)
            {
                IniSection section = new IniSection();
                section.Add("HostName", lsti.SubItems[0].Text);
                section.Add("Port", lsti.SubItems[1].Text);
                section.Add("Community", lsti.SubItems[2].Text);
                section.Add("Version", lsti.SubItems[3].Text);
                section.Add("User", lsti.SubItems[4].Text);
                section.Add("Password", lsti.SubItems[5].Text);
                ini.Add(lsti.SubItems[0].Text, section);
            }
            ini.Save();
        }

        private void HDDResultsToFile()
        {
            string file = String.Format("SnmpMonitoring-HDD-{0:yyyyMMddHHmmss}.txt", DateTime.Now);
            TextWriter tw = new StreamWriter(file);

            tw.WriteLine(String.Format("{0};{1};{2};{3};{4};{5}",HDDResultListView.Columns[1].Text,HDDResultListView.Columns[2].Text,HDDResultListView.Columns[3].Text,HDDResultListView.Columns[4].Text,HDDResultListView.Columns[5].Text,HDDResultListView.Columns[6].Text));

            foreach (ListViewItem lsti in HDDResultListView.Items)
            {
                tw.WriteLine(String.Format("{0};{1};{2};{3};{4};{5}", lsti.SubItems[1].Text,lsti.SubItems[2].Text,lsti.SubItems[3].Text,lsti.SubItems[4].Text,lsti.SubItems[5].Text,lsti.SubItems[6].Text ));
            }
            tw.Close();
        }

        private void pollAllSnmpHost()
        {
            if (HostListView.Items.Count > 0)
            {
                //Show ProgressBar
                this.ProgressLabel.Visible = true;
                this.ProgressBar.Visible = true;
                this.ProgressStatusLabel.Visible = true;
                this.FailedLabel.Visible = true;
                this.ProgressFailedLabel.Visible = true;

                this.ProgressBar.Minimum = 0;
                this.ProgressBar.Maximum = HostListView.Items.Count;
                this.ProgressBar.Step = 1;
                this.ProgressStatusLabel.Text = String.Format("0/{0}" ,HostListView.Items.Count);
                this.Refresh();
                //this.statusStrip1.Refresh();

                int i = 1;
                int failed = 0;
                foreach (ListViewItem lsti in HostListView.Items)
                {
                    SnmpPoller snmp = new SnmpPoller(HDDResultListView, CPUResultListView, lsti.SubItems[0].Text, Convert.ToInt16(lsti.SubItems[1].Text), lsti.SubItems[2].Text, Convert.ToInt16(lsti.SubItems[3].Text), lsti.SubItems[4].Text, lsti.SubItems[5].Text);
                    snmp.HddStatsPoll();

                    lsti.SubItems[6].Text = snmp.SnmpError;
                    if (snmp.SnmpError != "")
                    {
                        failed++;
                        this.ProgressFailedLabel.Text = String.Format("{0}/{1}", failed, HostListView.Items.Count);
                    }

                    this.ProgressBar.PerformStep();
                    this.ProgressStatusLabel.Text = String.Format("{0}/{1}", i,HostListView.Items.Count);
                    this.Refresh();
                    //this.statusStrip1.Refresh();
                    i++;
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HostConfiguration hostFrm = new HostConfiguration(HostListView);
            hostFrm.ShowDialog();

            //Refresh HostView
            HostListView.Refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HostListView.SelectedItems.Count > 0)
            {
                foreach(ListViewItem lst in HostListView.SelectedItems)
                {   
                    if ( MessageBox.Show(String.Format("Do you want to delete {0}", lst.Text) , "Deleting Host", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        HostListView.Items.Remove(lst);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HostListView.SelectedItems.Count > 0)
            {
                HostConfiguration hostFrm = new HostConfiguration(HostListView.SelectedItems[0]);
                hostFrm.ShowDialog();

                //Refresh HostView
                HostListView.Refresh();
            }
        }

        private void pollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HostListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lsti in HostListView.SelectedItems)
                {
                    SnmpPoller snmp = new SnmpPoller(HDDResultListView, CPUResultListView, lsti.SubItems[0].Text, Convert.ToInt16(lsti.SubItems[1].Text), lsti.SubItems[2].Text, Convert.ToInt16(lsti.SubItems[3].Text), lsti.SubItems[4].Text, lsti.SubItems[5].Text);
                    snmp.HddStatsPoll();
                }
            }
        }

        private void pollAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pollAllSnmpHost();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDDResultListView.Items.Clear();
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDDResultsToFile();
        }

        private void HostListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HostListView.SelectedItems.Count > 0)
            {
                HostContextMenu.Items[1].Enabled = true; //DELETE
                HostContextMenu.Items[3].Enabled = true; //EDIT
                HostContextMenu.Items[5].Enabled = true; //POLL
                HostContextMenu.Items[6].Enabled = true; //POLL
            }
            else {
                HostContextMenu.Items[1].Enabled = false; //DELETE
                HostContextMenu.Items[3].Enabled = false; //EDIT
                HostContextMenu.Items[5].Enabled = false; //POLL
            }

            //Last SNMP Error
            if (HostListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lsti in HostListView.SelectedItems)
                {
                    string snmpError = lsti.SubItems[6].Text;
                    if (snmpError == "")
                    {
                        HostContextMenu.Items[6].Enabled = false; //No Error SNMP
                    }
                    else {
                        HostContextMenu.Items[6].Enabled = true; //Error SNMP
                    }
                }
            }
        }

        private void HostListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == HostlvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (HostlvwColumnSorter.Order == SortOrder.Ascending)
                {
                    HostlvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    HostlvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                HostlvwColumnSorter.SortColumn = e.Column;
                HostlvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            HostListView.Sort();
        }

        private void HDDResultListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == HDDResultlvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (HDDResultlvwColumnSorter.Order == SortOrder.Ascending)
                {
                    HDDResultlvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    HDDResultlvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                HDDResultlvwColumnSorter.SortColumn = e.Column;
                HDDResultlvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            HDDResultListView.Sort();
        }

        private void HDDResultListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            Color c1 = Color.FromArgb(245, 249, 254);
            Color c2 = Color.FromArgb(237, 244, 255);
            Color colorItem = e.ItemIndex % 2 == 1 ? Color.FromArgb(125, c1.R, c1.G, c1.B) : Color.FromArgb(125, c2.R, c2.G, c2.B);

            string freeDisk = e.Item.SubItems[3].Text;
            freeDisk = freeDisk.Substring(0, freeDisk.Length - 1);
            double vFreeDisk = Convert.ToDouble(freeDisk);
            if (vFreeDisk < 20)
            {
                colorItem = System.Drawing.Color.Yellow;
            }
            if (vFreeDisk < 15)
            {
                colorItem = System.Drawing.Color.Orange;
            }
            if (vFreeDisk < 10)
            {
                colorItem = System.Drawing.Color.Red;
            }

            e.Item.BackColor = colorItem;
            e.Item.UseItemStyleForSubItems = true;
        }

        private void HDDResultListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadConfigFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveConfigFile();
        }

        private void HostListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            Color c1 = Color.FromArgb(245, 249, 254);
            Color c2 = Color.FromArgb(237, 244, 255);
            Color colorItem = e.ItemIndex % 2 == 1 ? Color.FromArgb(125, c1.R, c1.G, c1.B) : Color.FromArgb(125, c2.R, c2.G, c2.B);
            
            //IF SNMP ERROR
            string snmpError = e.Item.SubItems[6].Text;
            if (snmpError != "")
            {
                colorItem = Color.Red;
            }

            e.Item.BackColor = colorItem;
            e.Item.UseItemStyleForSubItems = true;
        }

        private void HostListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void exportResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDDResultsToFile();
        }

        private void pollAllHostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pollAllSnmpHost();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDDResultsToFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pollAllSnmpHost();

            HDDResultsToFile();
            CPUResultsToFile();
        }

        private void showLastErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HostListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lsti in HostListView.SelectedItems)
                {
                    string snmpError = lsti.SubItems[6].Text;
                    if (snmpError == "") snmpError = "Snmp scan done.";
                    MessageBox.Show("Last Scan result: " + snmpError, "Scan Error");
                }
            }
        }

        private void showAboutBox()
        {
            (new AboutBox()).ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAboutBox();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CPUResultListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == CPUResultlvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (CPUResultlvwColumnSorter.Order == SortOrder.Ascending)
                {
                    CPUResultlvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    CPUResultlvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                CPUResultlvwColumnSorter.SortColumn = e.Column;
                CPUResultlvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            CPUResultListView.Sort();
        }

        private void CPUResultListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            Color c1 = Color.FromArgb(245, 249, 254);
            Color c2 = Color.FromArgb(237, 244, 255);
            Color colorItem = e.ItemIndex % 2 == 1 ? Color.FromArgb(125, c1.R, c1.G, c1.B) : Color.FromArgb(125, c2.R, c2.G, c2.B);

            string cpuLoad = e.Item.SubItems[3].Text;
            cpuLoad = cpuLoad.Substring(0, cpuLoad.Length - 1);
            double vcpuLoad = Convert.ToDouble(cpuLoad);
            if (vcpuLoad > 70)
            {
                colorItem = System.Drawing.Color.Yellow;
            }
            if (vcpuLoad > 80)
            {
                colorItem = System.Drawing.Color.Orange;
            }
            if (vcpuLoad > 90)
            {
                colorItem = System.Drawing.Color.Red;
            }

            e.Item.BackColor = colorItem;
            e.Item.UseItemStyleForSubItems = true;
        }

        private void CPUResultListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ClearCPUMenuItem_Click(object sender, EventArgs e)
        {
            CPUResultListView.Items.Clear();
        }

        private void CPUResultsToFile()
        {
            string currentPath = Directory.GetCurrentDirectory();
            string file = String.Format("SnmpMonitoring-CPU-{0:yyyyMMddHHmmss}.txt", DateTime.Now);
            TextWriter tw = new StreamWriter(file);

            tw.WriteLine(String.Format("{0};{1};{2}", CPUResultListView.Columns[1].Text, CPUResultListView.Columns[2].Text, CPUResultListView.Columns[3].Text));

            foreach (ListViewItem lsti in CPUResultListView.Items)
            {
                tw.WriteLine(String.Format("{0};{1};{2}", lsti.SubItems[1].Text, lsti.SubItems[2].Text, lsti.SubItems[3].Text));
            }
            tw.Close();
        
        }

        private void ExportCPUResultMenuItem_Click(object sender, EventArgs e)
        {
            CPUResultsToFile();
        }
    }
}
