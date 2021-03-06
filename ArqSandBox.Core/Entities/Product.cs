﻿using ArqSandBox.Core.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace ArqSandBox.Core.Entities
{
    internal class Product : BaseEntity
    {
        internal DbSet<Product> Products { get; set; }
    }
}
