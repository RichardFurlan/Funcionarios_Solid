using Funcionarios_Solid.Models.Interfaces;
using static Funcionarios_Solid.Enums.Enum;

namespace Funcionarios_Solid.Models
{
    public class Designer : IDefinindoCargo
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public Funcionario InfoFuncionario { get; set; }
        public string FerramentaPreferida { get; set; }
        public AreaAtuacaoDesigner AreaAtuacao { get; set; }
        public decimal Bonus { get; set; }

        public void DefinirInformacoesDoFuncionario(Funcionario funcionario)
        {
            InfoFuncionario.NomeFuncionario = funcionario.NomeFuncionario;
            InfoFuncionario.CPF = funcionario.CPF;
            InfoFuncionario.Email = funcionario.Email;
            InfoFuncionario.Telefone = funcionario.Telefone;
            InfoFuncionario.DataAdmissao = funcionario.DataAdmissao;
            InfoFuncionario.DataDemissao = funcionario.DataDemissao;
            InfoFuncionario.Salario = funcionario.Salario;
            InfoFuncionario.HorasRealizadas = funcionario.HorasRealizadas;
            InfoFuncionario.ValorHorasNormais = funcionario.ValorHorasNormais;
            InfoFuncionario.INSS = funcionario.INSS;
            InfoFuncionario.IR = funcionario.IR;
        }
    }
}
