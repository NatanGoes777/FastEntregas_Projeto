using System;
using System.Collections.Generic;
using System.Text;
using Persistence;
using Model;
using System.Linq;

namespace Services
{
    public class GerenciadorConta : IGerenciadorConta
    {
        private readonly fast_entregasContext _context;

        public GerenciadorConta(fast_entregasContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Insere uma nova conta bancaria na base de dados
        /// </summary>
        /// <param name="contaModel">dados da conta</param>
        /// <returns></returns>
        public int Inserir(ContaBancaria contaModel)
        {
            TbContaBancaria tb_conta = new TbContaBancaria();

            tb_conta.CodConta = contaModel.CodConta;
            tb_conta.Numero = contaModel.Numero;
            tb_conta.Agencia = contaModel.Agencia;
            tb_conta.Tipo = contaModel.Tipo;
            tb_conta.CodUsuario = contaModel.CodUsuario;
            tb_conta.CodBanco = contaModel.CodBanco;

            _context.Add(tb_conta);
            _context.SaveChanges();

            return tb_conta.CodConta;
        }

        /// <summary>
        /// Atualiza os dados da conta na base de dados
        /// </summary>
        /// <param name="contaModel">dados da conta</param>
        public void Editar(ContaBancaria contaModel)
        {
            TbContaBancaria tb_conta = new TbContaBancaria();
            Atribuir(contaModel, tb_conta);
            _context.Update(tb_conta);
            _context.SaveChanges();
        }

        /// <summary>
        /// Remove uma conta da base de dados
        /// </summary>
        /// <param name="codConta">identificador da conta</param>
        public void Remover(int codConta)
        {
            var tb_conta = _context.TbContaBancaria.Find(codConta);
            _context.TbContaBancaria.Remove(tb_conta);
            _context.SaveChanges();
        }

        /// <summary>
        /// Consulta genérica aos dados da conta
        /// </summary>
        /// <returns></returns>
        private IQueryable<ContaBancaria> GetQuery()
        {
            IQueryable<TbContaBancaria> tb_conta = _context.TbContaBancaria;
            var query = from conta in tb_conta
                        select new ContaBancaria
                        {
                            CodConta = conta.CodConta,
                            Numero = conta.Numero,
                            Agencia = conta.Agencia,
                            Tipo = conta.Tipo,
                            CodUsuario = conta.CodUsuario,
                            CodBanco = conta.CodBanco
                        };
            return query;
        }

        /// <summary>
        /// Obtém todas as contas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ContaBancaria> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém pelo identificador da conta
        /// </summary>
        /// <param name="codConta"></param>
        /// <returns></returns>
        public ContaBancaria Obter(int codConta)
        {
            IEnumerable<ContaBancaria> contas = GetQuery().Where(contaModel => contaModel.CodConta.Equals(codConta));

            return contas.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém contas que iniciam com o numero
        /// </summary>
        /// <param name="numero">numero a ser buscado</param>
        /// <returns></returns>
        public IEnumerable<ContaBancaria> ObterPorNumero(int numero)
        {
            IEnumerable<ContaBancaria> contas = GetQuery().Where(contaModel => contaModel.Numero.Equals(numero));
            return contas;
        }

        /// <summary>
        /// Atribui dados entre objetos do model e entity
        /// </summary>
        /// <param name="contaModel">objeto model</param>
        /// <param name="tb_conta">objeto entity</param>
        private void Atribuir(ContaBancaria contaModel, TbContaBancaria tb_conta)
        {
            tb_conta.CodConta = contaModel.CodConta;
            tb_conta.Numero = contaModel.Numero;
            tb_conta.Agencia = contaModel.Agencia;
            tb_conta.Tipo = contaModel.Tipo;
            tb_conta.CodUsuario = contaModel.CodUsuario;
            tb_conta.CodBanco = contaModel.CodBanco;
        }

    }
}
