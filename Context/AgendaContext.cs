using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CriaApis2._0.Entities;
using Microsoft.EntityFrameworkCore;

namespace CriaApis2._0.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext>options): base(options)
        {
        }
        public DbSet<Contato>Contatos{get;set;}
        
    }
}