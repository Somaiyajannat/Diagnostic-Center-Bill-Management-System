﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiagnosticCenterBillManagementSystemApp
{ 
    [Serializable]

    public class Test
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public double TestFee { get; set; }
        
    }
}