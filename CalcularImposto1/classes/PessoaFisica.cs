using CalcularImposto1.interfaces;

namespace CalcularImposto1.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        
        public string? cpf{get; set;}

        
        public DateTime dataNasc{get; set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNacimento(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }
    }
}