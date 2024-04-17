using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SebastianLargo_TallerMVC2.Models;

namespace SebastianLargo_TallerMVC2.Data
{
    public class SebastianLargo_TallerMVC2Context : DbContext
    {
        public SebastianLargo_TallerMVC2Context (DbContextOptions<SebastianLargo_TallerMVC2Context> options)
            : base(options)
        {
        }

        public DbSet<SebastianLargo_TallerMVC2.Models.Burger> Burger { get; set; } = default!;
    }
}
