using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rafael_guimaraes.Models;

namespace rafael_guimaraes.Data
{
    public class rafael_guimaraesContext : DbContext
    {
        public rafael_guimaraesContext (DbContextOptions<rafael_guimaraesContext> options)
            : base(options)
        {
        }

        public DbSet<rafael_guimaraes.Models.pessoa> pessoa { get; set; }
    }
}
