﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Videe.Dtos
{
    public class NewRentalDto
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public List<int> MovieIds { get; set; }
    }
}