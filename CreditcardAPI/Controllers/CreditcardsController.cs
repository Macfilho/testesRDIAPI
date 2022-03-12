using CreditcardAPI.Repositories;
using CreditcardAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CreditcardAPI.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class CreditcardsController : ControllerBase
    {

        private readonly ICreditcardRepository _creditcardRepository;
       public CreditcardsController(ICreditcardRepository creditcardRepository)
        {
            _creditcardRepository = creditcardRepository;
        }

        [HttpGet]

        public async Task<IEnumerable<Creditcard>> GetCreditcards()
        {
            return await _creditcardRepository.Get();
        }
       
        [HttpGet ("{id}")]
        public async  Task<ActionResult<Creditcard>> GetCreditcards(int id)
        {
            return await _creditcardRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Creditcard>> PostCreditcards([FromBody] Creditcard creditcard)
        {
            var newCreditcard = await _creditcardRepository.Create(creditcard);
            return CreatedAtAction(nameof(GetCreditcards), new { id = newCreditcard.Id }, newCreditcard);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id)
        {
            var creditcardToDelete = await _creditcardRepository.Get(id);
            if (creditcardToDelete == null)
                return NotFound();
            await _creditcardRepository.Delete(creditcardToDelete.id);
            return NoContent();

        }
        [HttpPut]
        public async Task<ActionResult<Creditcard>> PutCreditcards(int id, [FromBody] Creditcard creditcard)
        {
            if (id != creditcard.id)
                return BadRequest();
                await _creditcardRepository.Update(creditcard);
            return NoContent();
         }
                

    }
}
