﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Domain
{
    public class ResponseBase<T> :ErrorResponseBase
    {
        public T Data { get; set; }
    }
}
