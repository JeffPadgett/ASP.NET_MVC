﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class IndexCustomer
    {
        public List<Customer> Customers { get; set; }
        public int Id { get; set; }
    }
}