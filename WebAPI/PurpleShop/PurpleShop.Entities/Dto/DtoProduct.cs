﻿using PurpleShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PurpleShop.Entities.Dto
{
    public class DtoProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DtoCategory Category { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
