using static Funcionarios_Solid.Enums.Enum;

namespace Funcionarios_Solid.Models.Interfaces
{
    public interface IDefineCargoParaFuncionario
    {
        IDefinindoCargo DefineAreaDeAtuacaoDoFuncionario(TipoFuncionario tipoFuncionario);
    }
}
