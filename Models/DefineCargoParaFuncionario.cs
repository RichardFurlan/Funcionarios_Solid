using Funcionarios_Solid.Models.Interfaces;
using static Funcionarios_Solid.Enums.Enum;

namespace Funcionarios_Solid.Models
{
    public class DefineCargoParaFuncionario : IDefineCargoParaFuncionario
    {
        public IDefinindoCargo DefineAreaDeAtuacaoDoFuncionario(TipoFuncionario tipoFuncionario)
        {
            IDefinindoCargo definindoCargo;
            switch (tipoFuncionario)
            {
                case TipoFuncionario.Desenvolvedor:
                    definindoCargo = new Desenvolvedor();
                    break;
                case TipoFuncionario.Designer:
                    definindoCargo = new Designer();
                    break;
                case TipoFuncionario.Gerente:
                    definindoCargo = new Gerente();
                    break;
                case TipoFuncionario.Tester:
                    definindoCargo = new Tester();
                    break;
                case TipoFuncionario.Analista:
                    definindoCargo = new Analista();
                    break;

                default:
                    throw new NotImplementedException("Cargo desconhecido.");

            }
            return definindoCargo;
        }
    }
}
