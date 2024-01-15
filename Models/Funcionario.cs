using Funcionarios_Solid.DTOs;
using Funcionarios_Solid.Models.Interfaces;
using static Funcionarios_Solid.Enums.Enum;

namespace Funcionarios_Solid.Models
{
    public class Funcionario
    {
        private readonly IDefineCargoParaFuncionario _defineCargoParaFuncionario;

        public int Id { get; set; }
        public TipoFuncionario Cargo { get; set; }
        public string NomeFuncionario { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public decimal Salario { get; set; }
        public int HorasRealizadas { get; set; }
        public int ValorHorasNormais { get; set; }
        public int INSS { get; set; }
        public int IR { get; set; }

        public decimal CalcularSalario()
        {
            return (ValorHorasNormais * HorasRealizadas) - (INSS + IR);
        }

        public decimal CalcularFerias()
        {
            var salario = CalcularSalario();
            return salario + (salario / 3);
        }
        public decimal CalcularDecimoTerceiro(decimal salarioMes)
        {
            var salario = CalcularSalario();
            return salarioMes + salario;
        }

        public void ToClass(FuncionarioDTO funcionarioDTO)
        { 
            Id = funcionarioDTO.Id;
            NomeFuncionario = funcionarioDTO.NomeFuncionario;
            CPF = funcionarioDTO.CPF;
            Email = funcionarioDTO.Email;
            Telefone = funcionarioDTO.Telefone;
            DataAdmissao = funcionarioDTO.DataAdmissao;
        }

        public void DefinindoAreaDeAtuacao(TipoFuncionario cargo)
        {
            var defineCargo = _defineCargoParaFuncionario.DefineAreaDeAtuacaoDoFuncionario(cargo);

            if (defineCargo == null)
                throw new Exception("Cargo não encontrado");

            defineCargo.DefinirInformacoesDoFuncionario(this);
        }
    }
}
