﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Image : BaseModel
    {
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
