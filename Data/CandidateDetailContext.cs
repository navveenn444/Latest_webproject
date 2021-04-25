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
    }
}
