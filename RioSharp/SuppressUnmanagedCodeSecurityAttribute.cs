﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#if !DNX46 

namespace System.Security
{
    public class SuppressUnmanagedCodeSecurityAttribute : Attribute
    {
    }
}
#endif