using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Lextm.SharpSnmpLib;
using Lextm.SharpSnmpLib.Security;
using Lextm.SharpSnmpLib.Messaging;
using Mono.Options;

namespace Genesys_DashBoard
{
    class SnmpPoller
    {
        public string HostName;
        public int SnmpPort;
        public string SnmpCommunity;
        public VersionCode SnmpVersion;
        public string SnmpUser;
        public string SnmpPassword;

        public ListView.ListViewItemCollection results;
        public ListView.ListViewItemCollection CpuResults;

        public string SnmpError = "";

        private int SnmpTimeout = 1000;
        private int SnmpRetry = 0;
        private string SnmpAuthentication = string.Empty;
        private string SnmpAuthPhrase = string.Empty;
        private string SnmpPrivacy = string.Empty;
        private string SnmpPrivPhrase = string.Empty;

        ///////////////////////////////////////////////////////////////////////////////////////////////
        //                                              SNMP OID                                     //
        ///////////////////////////////////////////////////////////////////////////////////////////////
        //CPU
        private string SnmpOID_CpuLoad = ".1.3.6.1.2.1.25.3.3.1.2";
        //HardDisk
        private string SnmpOID_StorageIndex = ".1.3.6.1.2.1.25.2.3.1.1";
        private string SnmpOID_StorageType = ".1.3.6.1.2.1.25.2.3.1.2";
        private string SnmpOID_StorageDescr = ".1.3.6.1.2.1.25.2.3.1.3";
        private string SnmpOID_StorageAllocationUnits = ".1.3.6.1.2.1.25.2.3.1.4";
        private string SnmpOID_StorageSize = ".1.3.6.1.2.1.25.2.3.1.5";
        private string SnmpOID_StorageUsed = ".1.3.6.1.2.1.25.2.3.1.6";
        private string SnmpOID_StorageAllocationFailures = ".1.3.6.1.2.1.25.2.3.1.7";
        //Storage Types
        private string SnmpOID_StorageOther = ".1.3.6.1.2.1.25.2.1.1";
        private string SnmpOID_StorageRam = ".1.3.6.1.2.1.25.2.1.2";
        private string SnmpOID_StorageVirtualMemory = ".1.3.6.1.2.1.25.2.1.3";
        private string SnmpOID_StorageFixedDisk = ".1.3.6.1.2.1.25.2.1.4";
        private string SnmpOID_StorageRemovableDisk = ".1.3.6.1.2.1.25.2.1.5";
        private string SnmpOID_StorageFloppyDisk = ".1.3.6.1.2.1.25.2.1.6";
        private string SnmpOID_StorageCompactDisk = ".1.3.6.1.2.1.25.2.1.7";
        private string SnmpOID_StorageRamDisk = ".1.3.6.1.2.1.25.2.1.8";

        public SnmpPoller(ListView resultlist, ListView cpuresultlist)
        {
            HostName = "localhost";
            SnmpPort = 161;
            SnmpCommunity = "public";
            SnmpVersion = VersionCode.V2;
            SnmpUser = string.Empty;
            SnmpPassword = string.Empty;

            SnmpTimeout = 1000;
            SnmpRetry = 0;
            results = new ListView.ListViewItemCollection(resultlist);
            CpuResults = new ListView.ListViewItemCollection(cpuresultlist);
        }

        public SnmpPoller(ListView resultlist, ListView cpuresultlist, string hostname, int port, string community, int version, string user, string password)
        {
            HostName = hostname;
            SnmpPort = port;
            SnmpCommunity = community;

            switch (version)
            {
                case 1: SnmpVersion = VersionCode.V1; break;
                case 2: SnmpVersion = VersionCode.V2; break;
                case 3: SnmpVersion = VersionCode.V3; break;
                default: SnmpVersion = VersionCode.V2; break;
            }

            SnmpUser = user;
            SnmpPassword = password;

            SnmpTimeout = 1000;
            SnmpRetry = 0;
            results = new ListView.ListViewItemCollection(resultlist);
            CpuResults = new ListView.ListViewItemCollection(cpuresultlist);
        }

        public void HddStatsPoolV2(IPEndPoint receiver)
        {
            List<Variable> vList = new List<Variable>();
            try
            {
                for (int nDisk = 1; nDisk <= 100; nDisk++)
                {
                    //Get Disk Type
                    string DiskType = "";
                    vList.Add(new Variable(new ObjectIdentifier(SnmpOID_StorageType + "." + nDisk.ToString())));
                    foreach (Variable variable in Messenger.Get(SnmpVersion, receiver, new OctetString(SnmpCommunity), vList, SnmpTimeout))
                    {
                        DiskType = variable.Data.ToString();
                    }
                    vList.Clear();

                    //Get Disk Name
                    string DiskName = "";
                    vList.Add(new Variable(new ObjectIdentifier(SnmpOID_StorageDescr + "." + nDisk.ToString())));
                    foreach (Variable variable in Messenger.Get(SnmpVersion, receiver, new OctetString(SnmpCommunity), vList, SnmpTimeout))
                    {
                        DiskName = variable.Data.ToString();
                    }
                    vList.Clear();

                    //Get Disk Unit
                    Int32 DiskUnit = 1;
                    vList.Add(new Variable(new ObjectIdentifier(SnmpOID_StorageAllocationUnits + "." + nDisk.ToString())));
                    foreach (Variable variable in Messenger.Get(SnmpVersion, receiver, new OctetString(SnmpCommunity), vList, SnmpTimeout))
                    {
                        DiskUnit = Convert.ToInt32(variable.Data.ToString());
                    }
                    vList.Clear();

                    //Get Disk size
                    double DiskSize = 1;
                    vList.Add(new Variable(new ObjectIdentifier(SnmpOID_StorageSize + "." + nDisk.ToString())));
                    foreach (Variable variable in Messenger.Get(SnmpVersion, receiver, new OctetString(SnmpCommunity), vList, SnmpTimeout))
                    {
                        DiskSize = Convert.ToDouble(variable.Data.ToString()) * DiskUnit / (1024 * 1024 * 1024);
                    }
                    vList.Clear();

                    //Get Disk used
                    double DiskUsed = 1;
                    vList.Add(new Variable(new ObjectIdentifier(SnmpOID_StorageUsed + "." + nDisk.ToString())));
                    foreach (Variable variable in Messenger.Get(SnmpVersion, receiver, new OctetString(SnmpCommunity), vList, SnmpTimeout))
                    {
                        double value = Convert.ToDouble(variable.Data.ToString());
                        DiskUsed = value * DiskUnit / (1024 * 1024 * 1024);
                    }
                    vList.Clear();

                    if (DiskType == SnmpOID_StorageFixedDisk)
                    {
                        ListViewItem lsti = results.Add(GenerateId());
                        lsti.SubItems.Add(HostName);
                        lsti.SubItems.Add(DiskName.Substring(0, 2));
                        lsti.SubItems.Add(String.Format("{0:0.0}%", (DiskSize - DiskUsed) * 100 / DiskSize));
                        lsti.SubItems.Add(String.Format("{0:0.0}Gb", DiskSize));
                        lsti.SubItems.Add(String.Format("{0:0.0}Gb", DiskUsed));
                        lsti.SubItems.Add(String.Format("{0:0.0}Gb", DiskSize - DiskUsed));
                        lsti.SubItems.Add(""); //SnmpError field
                        lsti.UseItemStyleForSubItems = true;
                    }
                }


            }
            catch (SnmpException ex)
            {

            }
            catch (SocketException ex)
            {
                SnmpError = String.Format("{0} Connection problem. Check IP, Hostname, SNMP service and SNMP community on the host", HostName);
            }


            //Gather CPUs load
            try
            {
                //CPU 1
                int nCPU = 1;
                //Get CPU Load
                Int32 CpuLoad = 0;
                vList.Clear();
                vList.Add(new Variable(new ObjectIdentifier(SnmpOID_CpuLoad + "." + nCPU.ToString())));
                foreach (Variable variable in Messenger.Get(SnmpVersion, receiver, new OctetString(SnmpCommunity), vList, SnmpTimeout))
                {
                    CpuLoad = Convert.ToInt32(variable.Data.ToString());
                }
                vList.Clear();

                ListViewItem lsti = CpuResults.Add(GenerateId());
                lsti.SubItems.Add(HostName);
                lsti.SubItems.Add(string.Format("{0}", nCPU));
                lsti.SubItems.Add(String.Format("{0:0}%", CpuLoad) );
                lsti.SubItems.Add(""); //SnmpError field
                lsti.UseItemStyleForSubItems = true;
            }
            catch (SnmpException ex)
            {

            }
            catch (SocketException ex)
            {
                SnmpError = String.Format("{0} Connection problem. Check IP, Hostname, SNMP service and SNMP community on the host", HostName);
            }

            try
            {
                //All CPUs (2 to ZZZ)
                for (int nCPU = 2; nCPU <= 100; nCPU++)
                {
                    //Get CPU Load
                    Int32 CpuLoad = 0;
                    vList.Clear();
                    vList.Add(new Variable(new ObjectIdentifier(SnmpOID_CpuLoad + "." + nCPU.ToString())));
                    foreach (Variable variable in Messenger.Get(SnmpVersion, receiver, new OctetString(SnmpCommunity), vList, SnmpTimeout))
                    {
                        CpuLoad = Convert.ToInt32(variable.Data.ToString());
                    }
                    vList.Clear();

                    ListViewItem lsti = CpuResults.Add(GenerateId());
                    lsti.SubItems.Add(HostName);
                    lsti.SubItems.Add(string.Format("{0}", nCPU));
                    lsti.SubItems.Add(String.Format("{0:0}%", CpuLoad));
                    lsti.SubItems.Add(""); //SnmpError field
                    lsti.UseItemStyleForSubItems = true;
                }
            }
            catch (SnmpException ex)
            {

            }
            catch (SocketException ex)
            {
                SnmpError = String.Format("{0} Connection problem. Check IP, Hostname, SNMP service and SNMP community on the host", HostName);
            }

        }

        public void HddStatsPoolV3(IPEndPoint receiver) { }

        public void HddStatsPoll()
        {
            //Check IP
            IPAddress ip;
            bool parsed = IPAddress.TryParse(HostName, out ip);
            if (!parsed)
            {
                foreach (IPAddress address in Dns.GetHostAddresses(HostName))
                {
                    if (address.AddressFamily != AddressFamily.InterNetwork)
                    {
                        continue;
                    }

                    ip = address;
                    break;
                }

                if (ip == null)
                {
                    //Console.WriteLine("invalid host or wrong IP address found: " + HostName);
                    return;
                }
            }

            IPEndPoint receiver = new IPEndPoint(ip, SnmpPort);
            switch (SnmpVersion)
            {
                case VersionCode.V3:
                    HddStatsPoolV3(receiver);
                    break;
                case VersionCode.V1:
                case VersionCode.V2:
                default:
                    HddStatsPoolV2(receiver);
                    break;
            }
        }

        private string GenerateId()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }
    }
}
