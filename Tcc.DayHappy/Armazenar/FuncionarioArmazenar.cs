using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Dominio.Storer
{
    public class FuncionarioArmazenar 
    {
        private readonly IRepository<Funcionario> _funcionarioRepository;

        public FuncionarioArmazenar( IRepository<Funcionario> funcionarioRepostory )
        {
            _funcionarioRepository = funcionarioRepostory;
        }

        public void Armazenar(int id, string nomeCargo, decimal salario, DateTime dataAdm, Pessoa pessoa, Contato contato, string referencia)
        {
            var funcionario = _funcionarioRepository.GetById(id);

            if(funcionario == null)
            {
                funcionario = new Funcionario(nomeCargo,salario, dataAdm,pessoa, contato,referencia);
                _funcionarioRepository.Save(funcionario);
            }
            else
            {
                funcionario.Update(nomeCargo, salario, dataAdm, pessoa, contato, referencia);
            }
        }
    }
}
