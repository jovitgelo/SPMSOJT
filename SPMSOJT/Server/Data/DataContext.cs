using Microsoft.EntityFrameworkCore;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Data
{
    public class DataContext: DbContext
    {
        //A constructor for the connection to the database
        //You can find the connction in the StartUp.cs at the SPMJSOJT.Server/StartUp.cs
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //The Table in the opmjsojt database
        public DbSet<User> user_info { get; set; }

        //If you want to add another table:
        //      Add a model or object first at the OPMJSOJT.Shared
        //      Create a new DbSet<NameOfModel> NameOfTable {get; set;}
        //      In the package manager console, type this
        //              cd opmjsojt
        //              cd server
        //              dotnet ef migrations add AnyNameOfMigrationNoSpace
        //              dotnet ef database update
    }
}
