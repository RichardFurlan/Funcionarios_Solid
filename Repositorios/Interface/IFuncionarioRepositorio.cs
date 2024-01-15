using Funcionarios_Solid.DTOs;
using Funcionarios_Solid.Models;
using static Funcionarios_Solid.Enums.Enum;

namespace Funcionarios_Solid.Repositorios.Interface
{
    public interface IFuncionarioRepositorio
    {
        Task<Funcionario> BuscarFuncionarioPorId(int id);
        Task<Funcionario> AdicionarFuncionario(FuncionarioDTO funcionario);
        Task<Funcionario> EditarCadastroFuncionario(Funcionario funcionario);
        Task<Funcionario> ExcluirFuncionario(Funcionario funcionario);
        Task<List<Funcionario>> ListarFuncionarios();
        Task<Funcionario> DefinirCargo(int id, TipoFuncionario cargo);

    }
}
