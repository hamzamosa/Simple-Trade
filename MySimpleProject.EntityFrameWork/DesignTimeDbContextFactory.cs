using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleProject.EntityFrameWork
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MySimpleTraderDbContext>
    {
        public MySimpleTraderDbContext CreateDbContext(string[] args=null)
        {
            var options = new DbContextOptionsBuilder<MySimpleTraderDbContext>();
            options.UseSqlServer("Server=DESKTOP-STJIF6I;Database=SimpleTrading;Trusted_Connection=True;Encrypt=false");

            return new MySimpleTraderDbContext(options.Options);
        }
    }
}
