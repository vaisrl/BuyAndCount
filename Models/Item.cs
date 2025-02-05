﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuyAndCount.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Lender { get; set; }
        public string Borrower { get; set; }
        [DisplayName ("Item Name")]
        public string ItemName { get; set; }
    }
}
