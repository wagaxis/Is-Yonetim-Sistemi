using AbcManagement.DataAccess.ORMs.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcManagement.DataAccess.ORMs
{
    public class ConnectionData : IConnectionData
    {
        public string DatabaseName { get; set; }

        public string ServerName { get; set; }

        public int PortNumber { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

    }
}
