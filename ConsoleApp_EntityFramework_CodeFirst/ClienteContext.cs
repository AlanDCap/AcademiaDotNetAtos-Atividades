using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EntityFramework_CodeFirst
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}
