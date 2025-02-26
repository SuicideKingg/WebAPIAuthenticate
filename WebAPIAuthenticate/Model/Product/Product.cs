﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIAuthenticate.Model.Product
{
    public class Product
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Product Name cannot be empty.")]
        [StringLength(30, ErrorMessage = "Maximum for 'Product Name' length exceeded")]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
