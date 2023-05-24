using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BinsaTest.Models;

namespace BinsaTest.Data
{
    public class BinsaTestContext : DbContext
    {
        public BinsaTestContext (DbContextOptions<BinsaTestContext> options)
            : base(options)
        {
        }

        public DbSet<BinsaTest.Models.Clientes> Clientes { get; set; } = default!;

        public DbSet<BinsaTest.Models.ContactosCliente>? ContactosCliente { get; set; }
    }
}
