﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmarinAssignmenmentMVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public int Name { get; set; }

    }
}
