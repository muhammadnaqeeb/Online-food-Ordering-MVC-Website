using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Online_Food_Ordering_Website.Models
{
    public class CustumerContext : DbContext
    {
        public DbSet<CustumerRegister> custumer_Reg { get; set; }
    
    }
}