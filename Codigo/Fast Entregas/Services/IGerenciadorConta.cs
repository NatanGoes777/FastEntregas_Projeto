using System.Collections.Generic;
using Model;

namespace Services
{
    public interface IGerenciadorConta
    {
        void Editar(ContaBancaria contaModel);
        int Inserir(ContaBancaria contaModel);
        ContaBancaria Obter(int codConta);
        IEnumerable<ContaBancaria> ObterPorNumero(int numero);
        IEnumerable<ContaBancaria> ObterTodos();
        void Remover(int codConta);
    }
}