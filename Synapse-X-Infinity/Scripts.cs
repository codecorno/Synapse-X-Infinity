using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sxlib;
using sxlib.Specialized;

namespace Synapse_X_Infinity
{
    class Scripts
    {
        public static void DexV4()
        {
            SynxF.Lib.Execute("loadstring(game:HttpGetAsync(\"https://raw.githubusercontent.com/ZeusHay/Synapse-X-Infinity/main/Synapse-X-Infinity/sxScripts/DexV4/DexV4.lua\"))()");
        }
    }
}
