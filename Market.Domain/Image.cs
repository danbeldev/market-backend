﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Domain
{
    public class Image
    {
        [Key] public string Id { get; set; }
        [Required] public string Url { get; set; }
    }
}
