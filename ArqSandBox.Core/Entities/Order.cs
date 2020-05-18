using ArqSandBox.Core.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace ArqSandBox.Core.Entities
{
    internal class Order : BaseEntity
    {
        internal DbSet<Order> Orders { get; set; }
    }
}
