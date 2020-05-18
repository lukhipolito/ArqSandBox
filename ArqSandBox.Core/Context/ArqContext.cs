using ArqSandBox.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArqSandBox.Core.Context
{
    public class ArqContext : DbContext
    {
        public ArqContext(DbContextOptions<ArqContext> options) 
            : base(options)
        {
        }
    }
}
