using CreditcardAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditcardAPI.Repositories
{
   public interface ICreditcardRepository
    {
        Task<IEnumerable<Creditcard>> Get();

        Task<Creditcard> Get(int Id);

        Task<Creditcard> Create(Creditcard creditcard);

        Task Update(Creditcard creditcard);

        Task Delete(int ID);

    }
}
