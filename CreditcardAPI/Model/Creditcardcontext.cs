using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditcardAPI.Model
{
    public class Creditcardcontext :DbContext
    {
        public Creditcardcontext( DbContextOptions<Creditcardcontext> options): base (options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Creditcard> Creditcards { get; set; }

    }
}
