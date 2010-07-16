using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Genesys_DashBoard
{
    public partial class HostConfiguration : Form
    {
        private ListView HostList;
        private ListViewItem HostItem;
        private int FormAction;  //0:Add, 1:Edit

        public HostConfiguration()
        {
            InitializeComponent();
        }

        public HostConfiguration(ListView hostlist)
        {
            InitializeComponent();
            FormAction = 0;
            HostList = hostlist;

            if (HostList != null)
            {
                HostNameTxt.Text = "localhost";
                SnmpPortTxt.Text = "161";
                SnmpCommunityTxt.Text = "public";
                SnmpVersionTxt.SelectedText = "2";
            }
        }

        public HostConfiguration(ListViewItem hostitem)
        {
            InitializeComponent();
            FormAction = 1;
            HostItem = hostitem;

            if (HostItem != null)
            {
                //Fill the fields
                HostNameTxt.Text = HostItem.Text.Trim();
                SnmpPortTxt.Text = HostItem.SubItems[1].Text.Trim();
                SnmpCommunityTxt.Text = HostItem.SubItems[2].Text.Trim();
                SnmpVersionTxt.Text = HostItem.SubItems[3].Text.Trim();
                SnmpUserTxt.Text = HostItem.SubItems[4].Text.Trim();
                SnmpPasswordTxt.Text = HostItem.SubItems[5].Text.Trim();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            switch (FormAction)
            {
                case 0:
                    if (HostList != null)
                    {
                        ListViewItem lst = HostList.Items.Add(HostNameTxt.Text.Trim());
                        lst.SubItems.Add(SnmpPortTxt.Text.Trim());
                        lst.SubItems.Add(SnmpCommunityTxt.Text.Trim());
                        lst.SubItems.Add(SnmpVersionTxt.Text.Trim());
                        lst.SubItems.Add(SnmpUserTxt.Text.Trim());
                        lst.SubItems.Add(SnmpPasswordTxt.Text.Trim());
                    }
                    break;
                case 1:
                    if (HostItem != null)
                    {
                        HostItem.SubItems[0].Text = HostNameTxt.Text.Trim();
                        HostItem.SubItems[1].Text = SnmpPortTxt.Text.Trim();
                        HostItem.SubItems[2].Text = SnmpCommunityTxt.Text.Trim();
                        HostItem.SubItems[3].Text = SnmpVersionTxt.Text.Trim();
                        HostItem.SubItems[4].Text = SnmpUserTxt.Text.Trim();
                        HostItem.SubItems[5].Text = SnmpPasswordTxt.Text.Trim();
                    }
                    break;
                default:
                    break;
            }

            this.Close();
        }

        private void SnmpVersionTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string version = SnmpVersionTxt.Text;
            switch (version)
            {
                case "3":
                    SnmpUserTxt.Enabled = true;
                    SnmpPasswordTxt.Enabled = true;
                    break;

                case "1":
                case "2":
                default:
                    SnmpUserTxt.Text = "";
                    SnmpPasswordTxt.Text = "";
                    SnmpUserTxt.Enabled = false;
                    SnmpPasswordTxt.Enabled = false;
                    break;
            }
        }
    }
}
