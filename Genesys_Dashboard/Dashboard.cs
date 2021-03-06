﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Oracle.DataAccess.Client;

namespace Genesys_DashBoard
{
    public partial class Dashboard : Form
    {
        //SNMP Tab
        private ListViewColumnSorter SnmpHostlvwColumnSorter;
        private ListViewColumnSorter SnmpHDDResultlvwColumnSorter;
        private ListViewColumnSorter SnmpCPUResultlvwColumnSorter;

        //InfoMart Tab
        private InfoMart.InfoMartConfig InfoMartJobConfig;

        //GVP Tab
        private GVP.GVPReportConfig GVPReportingConfig;
        private GVP.GVPPortConfig GVPPortConfig;

        public Dashboard()
        {
            InitializeComponent();


            //Load SCS config


            //Load SNMP config
            loadSNMPConfig();

            //Load InfoMart config
            loadInfoMartConfig();

            //Load GVP config
            loadGVPConfig();

        }

        #region  Summary LINKS

        private void SCSLink_Click(object sender, EventArgs e)
        {
            this.DashBoardTab.SelectTab(1);
        }

        private void SNMPLink_Click(object sender, EventArgs e)
        {
            this.DashBoardTab.SelectTab(2);
        }

        private void InfomartLink_Click(object sender, EventArgs e)
        {
            this.DashBoardTab.SelectTab(3);
        }

        private void GVPLink_Click(object sender, EventArgs e)
        {
            this.DashBoardTab.SelectTab(4);
        }

        private void ReportingLink_Click(object sender, EventArgs e)
        {
            this.DashBoardTab.SelectTab(5);
        }

        #endregion


        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            //SCS Logs

            //SNMP
            SnmpPollAllHost();
            //SnmpHDDResultsToFile();
            //SnmpCPUResultsToFile();

            //InfoMart logs
            InfoMartGetAllDayJobs();

            //GVP
            GVPReportingGetAllDayCalls();

            //Historical Reports

        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }



        #region  SNMP

        #region SNMP Config
        private void loadSNMPConfig()
        {
            //Host List
            SnmpHostListView.Columns.Add("HostName").Width = 150;
            SnmpHostListView.Columns.Add("Port").Width = 0;
            SnmpHostListView.Columns.Add("Communtity").Width = 0;
            SnmpHostListView.Columns.Add("Version").Width = 0;
            SnmpHostListView.Columns.Add("User").Width = 0;
            SnmpHostListView.Columns.Add("Password").Width = 0;
            SnmpHostListView.Columns.Add("Error").Width = 0;

            SnmpHostlvwColumnSorter = new ListViewColumnSorter();
            SnmpHostListView.ListViewItemSorter = SnmpHostlvwColumnSorter;


            //HDD Results List
            SnmpHDDResultListView.Columns.Add("id").Width = 0;
            SnmpHDDResultListView.Columns.Add("HostName").Width = 150;
            SnmpHDDResultListView.Columns.Add("Disk").TextAlign = HorizontalAlignment.Center;
            SnmpHDDResultListView.Columns.Add("%Free").TextAlign = HorizontalAlignment.Center;
            SnmpHDDResultListView.Columns.Add("Size").TextAlign = HorizontalAlignment.Center;
            SnmpHDDResultListView.Columns.Add("Used").TextAlign = HorizontalAlignment.Center;
            SnmpHDDResultListView.Columns.Add("Free").TextAlign = HorizontalAlignment.Center;

            SnmpHDDResultlvwColumnSorter = new ListViewColumnSorter();
            SnmpHDDResultListView.ListViewItemSorter = SnmpHDDResultlvwColumnSorter;

            //CPU Results List
            SnmpCPUResultListView.Columns.Add("id").Width = 0;
            SnmpCPUResultListView.Columns.Add("HostName").Width = 150;
            SnmpCPUResultListView.Columns.Add("CPU Id").TextAlign = HorizontalAlignment.Center;
            SnmpCPUResultListView.Columns.Add("CPU Load").TextAlign = HorizontalAlignment.Center;

            SnmpCPUResultlvwColumnSorter = new ListViewColumnSorter();
            SnmpCPUResultListView.ListViewItemSorter = SnmpCPUResultlvwColumnSorter;

            IniFile ini = new IniFile("SNMP config.ini");
            if (ini.Exists())
            {
                loadSnmpConfigFile();
            }

            //Refresh
            SnmpHostListView.Refresh();
            SnmpHDDResultListView.Refresh();
            SnmpCPUResultListView.Refresh();
        }

        private void loadSnmpConfigFile()
        {
            IniFile ini = new IniFile("SNMP Config.ini");
            if (ini.Exists())
            {
                ini.Load();
            }

            foreach (string section in ini.GetSections())
            {
                ListViewItem lst = SnmpHostListView.Items.Add(ini[section]["HostName"]);
                lst.SubItems.Add(ini[section]["Port"]);
                lst.SubItems.Add(ini[section]["Community"]);
                lst.SubItems.Add(ini[section]["Version"]);
                lst.SubItems.Add(ini[section]["User"]);
                lst.SubItems.Add(ini[section]["Password"]);
                lst.SubItems.Add(""); //SnmpError field
            }
        }

        private void saveSnmpConfigFile()
        {
            IniFile ini = new IniFile("SNMP Config.ini");

            foreach (ListViewItem lsti in SnmpHostListView.Items)
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
        #endregion

        #region SnmpHostListView
        private void SnmpHostListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == SnmpHostlvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (SnmpHostlvwColumnSorter.Order == SortOrder.Ascending)
                {
                    SnmpHostlvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    SnmpHostlvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                SnmpHostlvwColumnSorter.SortColumn = e.Column;
                SnmpHostlvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            SnmpHostListView.Sort();
        }

        private void SnmpHostListView_DrawItem(object sender, DrawListViewItemEventArgs e)
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

        private void SnmpHostListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        #endregion

        #region SnmpHDDListView
        private void SnmpHDDResultListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == SnmpHDDResultlvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (SnmpHDDResultlvwColumnSorter.Order == SortOrder.Ascending)
                {
                    SnmpHDDResultlvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    SnmpHDDResultlvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                SnmpHDDResultlvwColumnSorter.SortColumn = e.Column;
                SnmpHDDResultlvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            SnmpHDDResultListView.Sort();
        }

        private void SnmpHDDResultListView_DrawItem(object sender, DrawListViewItemEventArgs e)
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

        private void SnmpHDDResultListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
        #endregion

        #region SnmpCPUListView
        private void SnmpCPUResultListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == SnmpCPUResultlvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (SnmpCPUResultlvwColumnSorter.Order == SortOrder.Ascending)
                {
                    SnmpCPUResultlvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    SnmpCPUResultlvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                SnmpCPUResultlvwColumnSorter.SortColumn = e.Column;
                SnmpCPUResultlvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            SnmpCPUResultListView.Sort();
        }

        private void SnmpCPUResultListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            Color c1 = Color.FromArgb(245, 249, 254);
            Color c2 = Color.FromArgb(237, 244, 255);
            Color colorItem = e.ItemIndex % 2 == 1 ? Color.FromArgb(125, c1.R, c1.G, c1.B) : Color.FromArgb(125, c2.R, c2.G, c2.B);

            string cpuLoad = e.Item.SubItems[3].Text;
            cpuLoad = cpuLoad.Substring(0, cpuLoad.Length - 1);
            double vcpuLoad = Convert.ToDouble(cpuLoad);

            if (vcpuLoad > 90)
            {
                colorItem = System.Drawing.Color.Red;
            }
            else
            {
                if (vcpuLoad > 80)
                {
                    colorItem = System.Drawing.Color.Orange;
                }
                else
                {
                    if (vcpuLoad > 70)
                    {
                        colorItem = System.Drawing.Color.Yellow;
                    }
                }
            }

            e.Item.BackColor = colorItem;
            e.Item.UseItemStyleForSubItems = true;
        }

        private void SnmpCPUResultListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        #endregion

        private void SnmpCleanAllPoll()
        {
            SnmpHDDResultListView.Clear();
            SnmpCPUResultListView.Clear();
        }

        private void SnmpCPUResultsToFile()
        {
            string file = String.Format("SnmpMonitoring-CPU-{0:yyyyMMddHHmmss}.txt", DateTime.Now);
            TextWriter tw = new StreamWriter(file);

            tw.WriteLine(String.Format("{0};{1};{2}", SnmpCPUResultListView.Columns[1].Text, SnmpCPUResultListView.Columns[2].Text, SnmpCPUResultListView.Columns[3].Text));

            foreach (ListViewItem lsti in SnmpCPUResultListView.Items)
            {
                tw.WriteLine(String.Format("{0};{1};{2}", lsti.SubItems[1].Text, lsti.SubItems[2].Text, lsti.SubItems[3].Text));
            }
            tw.Close();

        }

        private void SnmpHDDResultsToFile()
        {
            string file = String.Format("SnmpMonitoring-HDD-{0:yyyyMMddHHmmss}.txt", DateTime.Now);
            TextWriter tw = new StreamWriter(file);

            tw.WriteLine(String.Format("{0};{1};{2};{3};{4};{5}", SnmpHDDResultListView.Columns[1].Text, SnmpHDDResultListView.Columns[2].Text, SnmpHDDResultListView.Columns[3].Text, SnmpHDDResultListView.Columns[4].Text, SnmpHDDResultListView.Columns[5].Text, SnmpHDDResultListView.Columns[6].Text));

            foreach (ListViewItem lsti in SnmpHDDResultListView.Items)
            {
                tw.WriteLine(String.Format("{0};{1};{2};{3};{4};{5}", lsti.SubItems[1].Text, lsti.SubItems[2].Text, lsti.SubItems[3].Text, lsti.SubItems[4].Text, lsti.SubItems[5].Text, lsti.SubItems[6].Text));
            }
            tw.Close();
        }

        private void SnmpPollAllHost()
        {
            if (SnmpHostListView.Items.Count > 0)
            {
                //Show ProgressBar
                this.ProgressLabel.Visible = true;
                this.ProgressBar.Visible = true;
                this.ProgressStatusLabel.Visible = true;
                this.FailedLabel.Visible = true;
                this.ProgressFailedLabel.Visible = true;

                this.SNMPProgressBar.Minimum = 0;
                this.SNMPProgressBar.Maximum = SnmpHostListView.Items.Count;
                this.SNMPProgressBar.Value = 0;
                this.SNMPProgressBar.Step = 1;
                this.SNMPProgressBar.ForeColor = Color.Blue;
                this.SNMPProgressBar.Refresh();

                this.SNMPProgressLabel.Text = String.Format("0/{0}", SNMPProgressBar.Maximum);
                this.SNMPProgressLabel.Refresh();

                int i = 1;
                int failed = 0;

                foreach (ListViewItem lsti in SnmpHostListView.Items)
                {
                    SnmpPoller snmp = new SnmpPoller(SnmpHDDResultListView, SnmpCPUResultListView, lsti.SubItems[0].Text, Convert.ToInt16(lsti.SubItems[1].Text), lsti.SubItems[2].Text, Convert.ToInt16(lsti.SubItems[3].Text), lsti.SubItems[4].Text, lsti.SubItems[5].Text);
                    snmp.HddStatsPoll();

                    lsti.SubItems[6].Text = snmp.SnmpError;
                    if (snmp.SnmpError != "")
                    {
                        failed++;
                        this.ProgressFailedLabel.Text = String.Format("{0}/{1}", failed, SNMPProgressBar.Maximum);
                    }

                    this.SNMPProgressBar.PerformStep();
                    this.SNMPProgressBar.Refresh();

                    this.SNMPProgressLabel.Text = String.Format("{0}/{1}", i, SNMPProgressBar.Maximum);
                    this.SNMPProgressLabel.Refresh();
                    i++;
                }
            }

            //Refresh
            SnmpHostListView.Refresh();
            SnmpHDDResultListView.Refresh();
            SnmpCPUResultListView.Refresh();
        }

        #endregion


        #region InfoMart
        private void InfoMartJobRefreshBtn_Click(object sender, EventArgs e)
        {
            InfoMartGetAllDayJobs();
        }

        private void InfoMartGetAllDayJobs()
        {
            if (InfoMartJobConfig != null)
            {
                OracleConnection InfoMartDBCon = new OracleConnection();
                //using connection string attributes to connect to Oracle Database
                InfoMartDBCon.ConnectionString = String.Format("User Id={0};Password={1};Data Source=//{2}:{3}/{4}", InfoMartJobConfig.username, InfoMartJobConfig.password, InfoMartJobConfig.hostname, InfoMartJobConfig.port, InfoMartJobConfig.service);

                this.InfoMartJobProgressBar.Value = 0;
                this.InfoMartJobProgressBar.Step = 1;
                this.InfoMartJobProgressBar.ForeColor = Color.Blue;
                this.InfoMartJobProgressLabel.Text = "0/4";
                this.InfoMartJobProgressBar.Refresh();
                this.InfoMartJobProgressLabel.Refresh();

                try
                {
                    InfoMartDBCon.Open();
                    this.InfoMartJobProgressBar.PerformStep();
                    this.InfoMartJobProgressLabel.Text = "1/4";
                    this.InfoMartJobProgressBar.Refresh();
                    this.InfoMartJobProgressLabel.Refresh();

                    OracleDataAdapter InfoMartJobAdpater = new OracleDataAdapter(string.Format("SELECT job_name as \"Job\", START_TIME as \"Start\", End_Time as \"End\", Status as \"Status\", to_char(to_date(Duration,'SSSSS'),'HH24:MI:SS') as \"Duration\", DBCOnnection as \"DB\" FROM {0} WHERE START_TIME > (sysdate -1) ORDER BY Start_Time desc", InfoMartJobConfig.table), InfoMartDBCon);
                    DataTable InfoMartJobDataTable = new DataTable("InfoMartJob");
                    InfoMartJobAdpater.Fill(InfoMartJobDataTable);
                    this.InfoMartJobProgressBar.PerformStep();
                    this.InfoMartJobProgressLabel.Text = "2/4";
                    this.InfoMartJobProgressBar.Refresh();
                    this.InfoMartJobProgressLabel.Refresh();

                    InfoMartJobsDataGridView.DataSource = InfoMartJobDataTable;
                    this.InfoMartJobProgressBar.PerformStep();
                    this.InfoMartJobProgressLabel.Text = "3/4";
                    this.InfoMartJobProgressBar.Refresh();
                    this.InfoMartJobProgressLabel.Refresh();

                    InfoMartDBCon.Close();
                    InfoMartDBCon.Dispose();
                    this.InfoMartJobProgressBar.PerformStep();
                    this.InfoMartJobProgressLabel.Text = "4/4";
                    this.InfoMartJobProgressBar.Refresh();
                    this.InfoMartJobProgressLabel.Refresh();
                }
                catch (Exception ex) { }
            }
        }



        #region InfoMart Config
        private void loadInfoMartConfig()
        {
            InfoMartJobConfig = new InfoMart.InfoMartConfig();

            loadInfoMartConfigFile();
        }

        private void loadInfoMartConfigFile()
        {
            IniFile ini = new IniFile("InfoMart Config.ini");
            if (ini.Exists())
            {
                ini.Load();
            }

            if (InfoMartJobConfig != null)
            {
                InfoMartJobConfig.hostname = ini["InfoMart DB"]["HostName"];
                InfoMartJobConfig.port = ini["InfoMart DB"]["Port"];
                InfoMartJobConfig.service = ini["InfoMart DB"]["Service"];
                InfoMartJobConfig.table = ini["InfoMart DB"]["Table"];
                InfoMartJobConfig.username = ini["InfoMart DB"]["Username"];
                InfoMartJobConfig.password = ini["InfoMart DB"]["Password"];
            }
        }

        private void saveInfoMartConfigFile()
        {
            IniFile ini = new IniFile("InfoMart Config.ini");

            if (InfoMartJobConfig != null)
            {
                IniSection section = new IniSection();
                section.Add("HostName", InfoMartJobConfig.hostname);
                section.Add("Port", InfoMartJobConfig.port );
                section.Add("Service", InfoMartJobConfig.service );
                section.Add("Table", InfoMartJobConfig.table );
                section.Add("Username", InfoMartJobConfig.username );
                section.Add("Password", InfoMartJobConfig.password );
                ini.Add("InfoMart DB", section);
            }
            ini.Save();
        }
        #endregion



        #endregion


        #region GVP
        private void GVPReportRefreshBtn_Click(object sender, EventArgs e)
        {
            GVPReportingGetAllDayCalls();
        }

        private void GVPActivityRefreshBtn_Click(object sender, EventArgs e)
        {

        }

        private void GVPReportingGetAllDayCalls()
        {
            if (GVPReportingConfig != null)
            {
                OracleConnection GVPReportDBCon = new OracleConnection();
                //using connection string attributes to connect to Oracle Database
                GVPReportDBCon.ConnectionString = String.Format("User Id={0};Password={1};Data Source=//{2}:{3}/{4}", GVPReportingConfig.username, GVPReportingConfig.password, GVPReportingConfig.hostname, GVPReportingConfig.port, GVPReportingConfig.service);

                this.GVPProgressBar.Value = 0;
                this.GVPProgressBar.Step = 1;
                this.GVPProgressBar.ForeColor = Color.Blue;
                this.GVPProgressLabel.Text = "0/4";
                this.GVPProgressBar.Refresh();
                this.GVPProgressLabel.Refresh();

                try
                {
                    GVPReportDBCon.Open();
                    this.GVPProgressBar.PerformStep();
                    this.GVPProgressLabel.Text = "1/4";
                    this.GVPProgressBar.Refresh();
                    this.GVPProgressLabel.Refresh();

                    OracleDataAdapter GVPReportAdpater = new OracleDataAdapter(string.Format("SELECT * FROM (SELECT CONN_ID as \"ConnID\", OCCURRENCE_TIME as \"Start\", CONTEXT as \"Context\", RESULT as \"Status\", Duration as \"Duration\" from {0} WHERE OCCURRENCE_TIME > (sysdate -1) ORDER BY CONN_ID DESC) WHERE rownum<100", GVPReportingConfig.table), GVPReportDBCon);
                    DataTable GVPReportDataTable = new DataTable("GVPReport");
                    GVPReportAdpater.Fill(GVPReportDataTable);
                    this.GVPProgressBar.PerformStep();
                    this.GVPProgressLabel.Text = "2/4";
                    this.GVPProgressBar.Refresh();
                    this.GVPProgressLabel.Refresh();

                    GVPReportDataGridView.DataSource = GVPReportDataTable;
                    this.GVPProgressBar.PerformStep();
                    this.GVPProgressLabel.Text = "3/4";
                    this.GVPProgressBar.Refresh();
                    this.GVPProgressLabel.Refresh();

                    GVPReportDBCon.Close();
                    GVPReportDBCon.Dispose();
                    this.GVPProgressBar.PerformStep();
                    this.GVPProgressLabel.Text = "4/4";
                    this.GVPProgressBar.Refresh();
                    this.GVPProgressLabel.Refresh();
                }
                catch (Exception ex) { }
            }
        }

        #region GVP Report Config
        private void loadGVPConfig()
        {
            GVPReportingConfig = new GVP.GVPReportConfig();
            GVPPortConfig = new GVP.GVPPortConfig();

            loadGVPConfigFile();
        }

        private void loadGVPConfigFile()
        {
            IniFile ini = new IniFile("GVP Config.ini");
            if (ini.Exists())
            {
                ini.Load();
            }

            if (GVPReportingConfig != null)
            {
                GVPReportingConfig.hostname = ini["GVP Report DB"]["HostName"];
                GVPReportingConfig.port = ini["GVP Report DB"]["Port"];
                GVPReportingConfig.service = ini["GVP Report DB"]["Service"];
                GVPReportingConfig.table = ini["GVP Report DB"]["Table"];
                GVPReportingConfig.username = ini["GVP Report DB"]["Username"];
                GVPReportingConfig.password = ini["GVP Report DB"]["Password"];
            }


        }

        private void saveGVPConfigFile()
        {
            IniFile ini = new IniFile("GVP Config.ini");

            ini.Save();
        }
        #endregion




        #endregion

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


    }
}
