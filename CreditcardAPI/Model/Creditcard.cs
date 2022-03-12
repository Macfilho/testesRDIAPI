using System;
using System.ComponentModel.DataAnnotations;

namespace CreditcardAPI.Model
{
    public class Creditcard
    {

        [Key]
        public int Customerid { get; set; }
        public long Cardnumber { get; set; }
        [MaxLength(16, ErrorMessage = "This Field must have maximum 16 characters ")]
        public int CVV { get; set; }
        [MaxLength(5, ErrorMessage = "This Field must have maximum 5 characters ")]
        public int Cardid { get; set; }
    }
}
