namespace Funcionarios_Solid.DTOs
{
    public class FuncionarioDTO
    {
        public int Id { get; set; }
        public string NomeFuncionario { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
