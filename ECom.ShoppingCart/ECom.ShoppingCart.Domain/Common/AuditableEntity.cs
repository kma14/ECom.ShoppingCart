﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.ShoppingCart.Domain.Common
{
    public class AuditableEntity
    {
        public Guid Id { get; set; }
        public DateTime WhenCreated { get; set; }
    }
}
