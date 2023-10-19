using Expensive.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expensive.DataAciton
{
    public class ApplicationDbContext :  DbContext
    {

    }
    // Dbset is a collection of Object that represent table in  database
     public DbSet<ExpensiveModel> ExpensesTable { get; set; }
}
  