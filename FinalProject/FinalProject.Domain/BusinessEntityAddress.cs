﻿using System;
using System.Collections.Generic;

namespace FinalProject.Domain
{
    public partial class BusinessEntityAddress
    {
        public int BusinessEntityId { get; set; }
        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Address Address { get; set; }
    }
}
