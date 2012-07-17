using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SisCadLibrary.Data
{
    [MetadataType(typeof(Funcionario_Metadata))]
    public partial class funcionario
    {
        public int funcionario_id { get; set; }
        public int matricula { get; set; }
        public string nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public string sexo { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public int municipio_id { get; set; }
        public municipio municipio { get; set; }
        public municipio naturalidade { get; set; }
        public int municipio_id_naturalidade { get; set; }
        public string telefone_residencial { get; set; }
        public string telefone_celular { get; set; }
        public string telefone_recado { get; set; }
        public int estado_civil { get; set; }
        public int grau_instrucao { get; set; }
        public int cor { get; set; }
        public string rg { get; set; }
        public DateTime? data_emissao_rg { get; set; }
        public string orgao_emissor { get; set; }
        public string cpf { get; set; }
        public string pis { get; set; }
        public string ctps { get; set; }
        public string serie { get; set; }
        public DateTime? data_expedicao_ctps { get; set; }
        public DateTime? data_expedicao_cnh { get; set; }
        public string titulo_eleitor { get; set; }
        public string zona { get; set; }
        public string secao { get; set; }
        public string cnh { get; set; }
        public setor setor { get; set; }
        public int setor_id { get; set; }
        public string orgao_emissor_rg { get; set; }
        public string categoria_cnh { get; set; }
        public DateTime data_admissao { get; set; }
        public decimal salario_inicial { get; set; }
        public decimal salario_atual { get; set; }
        public cargo cargo { get; set; }
        public int cargo_id { get; set; }
        public int cargo_contratacao_id { get; set; }
        public cargo cargo_contratacao { get; set; }
        public string caminho_foto { get; set; }
        public bool ativo { get; set; }
        public int empresa_id { get; set; }
        public empresa empresa { get; set; }
        public string mae { get; set; }
        public string pai { get; set; }
        public List<dependente> dependente { get; internal set; }
        public List<ferias> ferias { get; internal set; }
        public List<movimentacao> movimentacao { get; internal set; }
    }

    public class Funcionario_Metadata
    {
        [Key]
        public int funcionario_id { get; set; }
        public int matricula { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        [Display(Name="Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Data de Nascimento é obrigatório.")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime data_nascimento { get; set; }

        [Required(ErrorMessage = "Campo Sexo é obrigatório.")]
        [Display(Name = "Sexo")]
        public string sexo { get; set; }

        [ForeignKey("municipio_id")]
        [Display(Name = "Município")]
        public municipio municipio { get; set; }

        [Required(ErrorMessage = "Campo Naturalidade é obrigatório.")]
        [Display(Name = "Naturalidade")]
        [ForeignKey("municipio_id_naturalidade")]
        public municipio naturalidade { get; set; }

        [Required(ErrorMessage = "Campo Estado Cívil é obrigatório.")]
        [Display(Name = "Estado Cívil")]
        public int estado_civil { get; set; }

        [Required(ErrorMessage = "Campo Grau de Instrução é obrigatório.")]
        [Display(Name = "Grau de Instrução")]
        public int grau_instrucao { get; set; }

        [Required(ErrorMessage = "Campo Cor é obrigatório.")]
        [Display(Name = "Cor")]
        public int cor { get; set; }

        [Required(ErrorMessage = "Campo Setor é obrigatório.")]
        [ForeignKey("setor_id")]
        [Display(Name = "Setor")]
        public setor setor { get; set; }


        [Required(ErrorMessage = "Campo Data de Admissão é obrigatório.")]
        [Display(Name = "Data de Admissão")]
        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime data_admissao { get; set; }

        [Required(ErrorMessage = "Campo Salário Inicial é obrigatório.")]
        [Display(Name = "Salário Inicial")]
        [DisplayFormat(DataFormatString="{0:c2}")]
        public decimal salario_inicial { get; set; }

        [Required(ErrorMessage = "Campo Salário Atual é obrigatório.")]
        [Display(Name = "Salário Atual")]
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public decimal salario_atual { get; set; }

        [Required(ErrorMessage = "Campo Cargo é obrigatório.")]
        [ForeignKey("cargo_id")]
        [Display(Name = "Cargo")]
        public cargo cargo { get; set; }

        [Required(ErrorMessage = "Campo Cargo Contratação é obrigatório.")]
        [ForeignKey("cargo_contratacao_id")]
        [Display(Name = "Cargo Contradação")]
        public cargo cargo_contratacao { get; set; }

        [Required(ErrorMessage = "Funcionário precisa estar vinculado a uma empresa.")]
        [ForeignKey("empresa_id")]
        [Display(Name = "Empresa")]
        public empresa empresa { get; set; }
    }
}
