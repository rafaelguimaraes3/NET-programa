using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace rafael_guimaraes.Models
{
    public class contexto: BdContext
    {
        public DbSet<pessoa> Pessoas { get; set; }

    }
}
