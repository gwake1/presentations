﻿using System;

namespace PerformanceEfCore.EfStructures.Models
{
    public partial class SalesOrderHeaderSalesReason
    {
        public int SalesOrderID { get; set; }
        public int SalesReasonID { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeader SalesOrder { get; set; }
        public virtual SalesReason SalesReason { get; set; }
    }
}
