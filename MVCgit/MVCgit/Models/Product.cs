using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCgit.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [MaxLength(15)]
        public string ProductName { get; set; }

        public string productbar {get; set;}
    }
}