using Funcionarios_Solid.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Funcionarios_Solid.Data.Maps
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Cargo).HasColumnName("cargo").HasColumnType("int").IsRequired();
            builder.Property(x => x.NomeFuncionario).HasColumnName("nomeFuncionario").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.CPF).HasColumnName("CPF").HasColumnType("varchar(11)").IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Telefone).HasColumnName("telefone").HasColumnType("varchar(11)").IsRequired();
            builder.Property(x => x.DataAdmissao).HasColumnName("dataAdmissao").HasColumnType("date").IsRequired();
            builder.Property(x => x.DataDemissao).HasColumnName("dataDemissao").HasColumnType("date").IsRequired(false);
            builder.Property(x => x.Salario).HasColumnName("salario").HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(x => x.HorasRealizadas).HasColumnName("horasRealizadas").HasColumnType("int").IsRequired();
            builder.Property(x => x.ValorHorasNormais).HasColumnName("valorHorasNormais").HasColumnType("int").IsRequired();
            builder.Property(x => x.INSS).HasColumnName("INSS").HasColumnType("int").IsRequired();
            builder.Property(x => x.IR).HasColumnName("IR").HasColumnType("int").IsRequired();
        }
    }
    


}
