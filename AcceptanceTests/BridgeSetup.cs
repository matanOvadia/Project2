using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridges;
using WorkshopForum;

namespace AcceptanceTests
{
    class BridgeSetup
    {

        public static Bridge getBridge()
        {
            ProxyBridge proxy = new ProxyBridge();
            proxy.setRealBridge(new RealBridge());
            Bridge bridge = (Bridge)proxy;
            // comment out if not yet implemented
            return bridge;
        }

    }
}
