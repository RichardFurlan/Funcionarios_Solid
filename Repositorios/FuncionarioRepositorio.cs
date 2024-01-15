using Funcionarios_Solid.Data;
using Funcionarios_Solid.DTOs;
using Funcionarios_Solid.Models;
using Funcionarios_Solid.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;
using static Funcionarios_Solid.Enums.Enum;

namespace Funcionarios_Solid.Repositorios
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {

        private readonly SistemaContabilDBContext _dbContext;
        public FuncionarioRepositorio(SistemaContabilDBContext sistemaContabilDBContext)
        {
            _dbContext = sistemaContabilDBContext;
        }

        public async Task<Funcionario> BuscarFuncionarioPorId(int id)
        {
            return await _dbContext.Funcionarios.FindAsync(id);
        }

        public async Task<Funcionario> AdicionarFuncionario(FuncionarioDTO funcionarioDto)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.ToClass(funcionarioDto);

            await _dbContext.Funcionarios.AddAsync(funcionario);
            await _dbContext.SaveChangesAsync();

            return funcionario;
        }

        public Task<Funcionario> DefinirCargo(int id, TipoFuncionario cargo)
        {
            var funcionario = _dbContext.Funcionarios.Find(id);

            funcionario.Cargo = cargo;

            _dbContext.Funcionarios.Update(funcionario);

            return Task.FromResult(funcionario);
        }

        public Task<Funcionario> EditarCadastroFuncionario(Funcionario funcionario)
        {
            var funcionarioEditar = _dbContext.Funcionarios.Find(funcionario.Id);

            if (funcionarioEditar == null)
            {
                throw new Exception("Funcionario não encontrado");
            }

            funcionarioEditar.NomeFuncionario = funcionario.NomeFuncionario;
            funcionarioEditar.CPF = funcionario.CPF;
            funcionarioEditar.Email = funcionario.Email;
            funcionarioEditar.Telefone = funcionario.Telefone;
            funcionarioEditar.DataAdmissao = funcionario.DataAdmissao;
            funcionarioEditar.DataDemissao = funcionario.DataDemissao;
            funcionarioEditar.Salario = funcionario.Salario;
            funcionarioEditar.HorasRealizadas = funcionario.HorasRealizadas;
            funcionarioEditar.ValorHorasNormais = funcionario.ValorHorasNormais;
            funcionarioEditar.INSS = funcionario.INSS;
            funcionarioEditar.IR = funcionario.IR;

            _dbContext.Funcionarios.Update(funcionarioEditar);
            _dbContext.SaveChanges();

            return Task.FromResult(funcionarioEditar);

        }

        public Task<Funcionario> ExcluirFuncionario(Funcionario funcionario)
        {
            var funcionarioApagar = _dbContext.Funcionarios.Find(funcionario.Id);

            if (funcionarioApagar == null)
            {
                throw new Exception("Funcionario não encontrado");
            }

            _dbContext.Funcionarios.Remove(funcionarioApagar);
            _dbContext.SaveChanges();

            return Task.FromResult(funcionarioApagar);
        }

        public async Task<List<Funcionario>> ListarFuncionarios()
        {
            return await _dbContext.Funcionarios.ToListAsync();
        }

    }
}
