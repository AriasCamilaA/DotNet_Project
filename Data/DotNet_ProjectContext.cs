using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNet_Project.Models;

namespace DotNet_Project.Data
{
    public class DotNet_ProjectContext : DbContext
    {
        public DotNet_ProjectContext (DbContextOptions<DotNet_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<DotNet_Project.Models.Usuario> Usuario { get; set; } = default!;
    }
}
