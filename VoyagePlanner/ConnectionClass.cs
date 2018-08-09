using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoyagePlanner
{
    public class ConnectionClass
    {
        public DatabaseConnection EF;
        public ConnectionClass()
        {
            var connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=asd;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseConnection>();
            optionsBuilder.UseSqlServer(connection);
            EF = new DatabaseConnection(optionsBuilder.Options);
        }
    }
}
