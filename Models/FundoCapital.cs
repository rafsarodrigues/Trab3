using System;

namespace Trabalho.Api.Models
{
    
    public class FundoCapital{
        public FundoCapital()
        {
           Id = Guid.NewGuid(); 
        }
        public Guid Id{ get; }
        public string Nome{ get; set; }
        public decimal ValorNecessario { get; set;}
        public decimal ValorAtual { get; set; }
        public DateTime? DataResgate { get; set; }
    }
}
