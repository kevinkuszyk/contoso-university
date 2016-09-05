using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace ContosoUniversity.Data.Migrations
{
    public class SchoolConfiguration : DbConfiguration
    {
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}