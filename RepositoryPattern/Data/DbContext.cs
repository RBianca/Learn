namespace RepositoryPattern.Data
{
    public class DbContext
    {
        private DbContextOptions<EmployeeContext> options;

        public DbContext(DbContextOptions<EmployeeContext> options)
        {
            this.options = options;
        }
    }
}