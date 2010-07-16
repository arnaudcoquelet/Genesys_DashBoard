using System;
using System.Collections.Generic;
using System.Text;

namespace Genesys_DashBoard.GVP
{
    class GVPPortConfig
    {
        public string hostname { set; get; }
        public string port { set; get; }
        public string service { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public string table { set; get; }
    }
}
