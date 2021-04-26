using Microsoft.EntityFrameworkCore;
using Mywebproject_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mywebproject_core.Data
{
    public class CandidateDetailContext : DbContext
    {
        public CandidateDetailContext(DbContextOptions<CandidateDetailContext> options)
            : base(options)
        {
        }

        public DbSet<CandidateDetail> CandidateDetail { get; set; }

        //public static string GetConnectionString()
        //{
        //    string constring = @"Server=(localdb)\\MSSQLLocalDB;Database=CandidateDetailContext-1;Trusted_Connection=True;MultipleActiveResultSets=true";
        //    //string constring = @"Server=tcp:fuelserver.database.windows.net,1433;Initial Catalog=fueldatabase;Persist Security Info=False;User ID=omprakash;Password=Sulochana@1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        //    return constring;
        //}
    }
}
