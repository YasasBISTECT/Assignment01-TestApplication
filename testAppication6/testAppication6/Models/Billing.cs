using System;
using System.Collections.Generic;

#nullable disable

namespace testAppication6.Models
{
    public partial class Billing
    {
        public int BillId { get; set; }
        public string BillAddress1 { get; set; }
        public string BillAddress2 { get; set; }
        public string BillCity { get; set; }
        public int AccId { get; set; }

        public virtual Account Acc { get; set; }
    }
}
