﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Configuration
    {
        public static long GuestRequestKey { get; set; } = 10000000;
        public static long HostingUnitKey { get; set; } = 10000000;
        public static long OrderKey { get; set; } = 10000000;
    }
}