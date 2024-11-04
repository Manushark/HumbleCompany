using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HumbleCompany.Domain;

namespace HumbleCompany.API.Data
{
    public class HumbleCompanyAPIContext : DbContext
    {
        public HumbleCompanyAPIContext (DbContextOptions<HumbleCompanyAPIContext> options)
            : base(options)
        {
        }

        public DbSet<HumbleCompany.Domain.Empleado> Empleado { get; set; } = default!;
    }
}
