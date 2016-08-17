﻿using System.Runtime.InteropServices;

namespace vibrance.GUI.AMD.vendor.adl64
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct ADLDisplayID
    {
        internal int DisplayLogicalIndex;
        internal int DisplayPhysicalIndex;
        internal int DisplayLogicalAdapterIndex;
        internal int DisplayPhysicalAdapterIndex;
    }
}