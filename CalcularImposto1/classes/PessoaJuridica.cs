using CalcularImposto1.interfaces;

namespace CalcularImposto1.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? CNPJ{get; set;}


        public string? RazaoSocila{get; set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCNPJ(string CNPJ)
        {
            throw new NotImplementedException();
        }
    }
}