﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kitchen.Models
{
    public class FoodItems
    {
        [Key]
        public int ItemID { get; set; }
        public string  ItemName { get; set; }
       // public ICollection<Ingredients> Ingredients { get; set; }
       

    }
}