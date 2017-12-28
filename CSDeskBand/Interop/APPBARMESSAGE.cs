﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDeskBand.Interop
{
    internal enum APPBARMESSAGE : uint
    {
        ABM_NEW = 0x00000000,
        ABM_REMOVE = 0x00000001,
        ABM_QUERYPOS = 0x00000002,
        ABM_SETPOS = 0x00000003,
        ABM_GETSTATE = 0x00000004,
        ABM_GETTASKBARPOS = 0x00000005,
        ABM_ACTIVATE = 0x00000006,
        ABM_GETAUTOHIDEBAR = 0x00000007,
        ABM_SETAUTOHIDEBAR = 0x00000008,
        ABM_WINDOWPOSCHANGED = 0x00000009,
        ABM_SETSTATE = 0x0000000A,
        ABM_GETAUTOHIDEBAREX = 0x0000000B,
        ABM_SETAUTOHIDEBAREX = 0x0000000C,
    }
}
