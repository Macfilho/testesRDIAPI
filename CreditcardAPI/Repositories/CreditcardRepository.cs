using CreditcardAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditcardAPI.Repositories
{
    public class CreditcardRepository : ICreditcardRepository
    {

        public readonly Creditcardcontext _context;
        public CreditcardRepository (Creditcardcontext context)
        {
            _context = context;
        }

        public async Task<Creditcard> Create(Creditcard creditcard)
        {
            _context.Creditcards.Add(creditcard);
            await  _context.SaveChangesAsync();
            return creditcard;

        }

        public async Task Delete(int id)
        {
            var creditcardToDelete = await _context.Creditcards.FindAsync(id);
            _context.Creditcards.Remove(creditcardToDelete); 
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Creditcard>> Get()
        {
           return await _context.Creditcards.ToListAsync();
        }

        public async Task<Creditcard> Get(int id)
        {
            return await _context.Creditcards.FindAsync(id);
        }

        public async Task Update(Creditcard creditcard)
        {
            _context.Entry(creditcard).State = EntityState.Modified;
                await _context.SaveChangesAsync();
        }
    }
}
