﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SaleWebMvc.Services.Exceptions
{
    public class NotFoundException:ApplicationException
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
