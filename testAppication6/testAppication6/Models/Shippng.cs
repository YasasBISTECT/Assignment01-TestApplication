﻿using System;
using System.Collections.Generic;

#nullable disable

namespace testAppication6.Models
{
    public partial class Shippng
    {
        public int ShipId { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipCity { get; set; }
        public string Request { get; set; }
        public string EmailSub { get; set; }
        public bool? IsChecked { get; set; }
        public int AccId { get; set; }

        public virtual Account Acc { get; set; }
    }
}
