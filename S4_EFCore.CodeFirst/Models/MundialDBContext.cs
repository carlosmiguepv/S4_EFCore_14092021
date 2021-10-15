using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_EFCore.CodeFirst.Models
{
    public class MundialDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //SQL Server Authentication
            var myConnectionString = "Server=LAPTOP-9Q6APE6P;Database=MundialDB;User=sa;Pwd=123456789" ;

            //Windows Authentication
            //var myConnectionString = "Server=LAPTOP-9Q6APE6P;Database=MundialDB;Trusted_Connection=true;MultipleActiveResultSets=true";

            optionsBuilder.UseSqlServer(myConnectionString)
                .LogTo(Console.WriteLine, LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Player> Player { get; set; }

    }
}
