using DevZest.Data.DbInit;
using System.IO;

namespace Movies
{
    public sealed class DevDb : DbSessionProvider<Db>
    {
        public override Db Create(string projectPath)
        {
            var dbFolder = Path.Combine(projectPath, @"LocalDb");
            string attachDbFilename = Path.Combine(dbFolder, "Movies.mdf");
            //var connectionString = string.Format(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=""{0}"";Integrated Security=True", attachDbFilename);
            var connectionString = $@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=""{attachDbFilename}"";Integrated Security=True";
            return new Db(connectionString);
        }
    }
}
