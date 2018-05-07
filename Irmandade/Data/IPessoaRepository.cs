using Irmandade.Model;

namespace Irmandade.Data
{
    public interface IPessoaRepository
    {
        Pessoa GetPessoa(string CPF);
        void SavePessoa(Pessoa pessoa);
    }
}