﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class CategoryDTO
    {
        public CategoryDTO() { }
        public int CategoryId { get; set; } 
        public string CategoryName { get; set; } = null;
    }
}
