using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Objects.DataClasses;

namespace Model.Data
{
    public partial class funcionario : classe_base
    {
        public funcionario()
        {
            this.ativo = true;
        }

        public override string ToString()
        {
            return string.Concat(this.matricula, "-", this.nome);
        }

        [Key]
        public int funcionario_id { get; set; }
        public int matricula { get; set; }
        public byte[] foto { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Data de Nascimento é obrigatório.")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime data_nascimento { get; set; }

        [Required(ErrorMessage = "Campo Sexo é obrigatório.")]
        [Display(Name = "Sexo")]
        public string sexo { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public int municipio_id { get; set; }

        [Required(ErrorMessage = "Campo Município é obrigatório.")]
        [Display(Name = "Município")]
        public municipio municipio { get; set; }
        //{
        //    get
        //    {
        //        return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<municipio>("SisCadEntities.fk_municipio_naturalidade_to_funcionario", "municipio").Value;
        //    }
        //    set
        //    {
        //        ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<municipio>("SisCadEntities.fk_municipio_naturalidade_to_funcionario", "municipio").Value = value;
        //    }
        //}

        [Required(ErrorMessage = "Campo Naturalidade é obrigatório.")]
        [Display(Name = "Naturalidade")]
        public municipio naturalidade { get; set; }
        public int municipio_id_naturalidade { get; set; }
        public string telefone_residencial { get; set; }
        public string telefone_celular { get; set; }
        public string telefone_recado { get; set; }

        [Required(ErrorMessage = "Campo Estado Cívil é obrigatório.")]
        [Display(Name = "Estado Cívil")]
        public string estado_civil { get; set; }

        [Required(ErrorMessage = "Campo Vínculo é obrigatório.")]
        [Display(Name = "Vínculo")]
        public string vinculo { get; set; }

        [Required(ErrorMessage = "Campo Nacionalidade é obrigatório.")]
        [Display(Name = "Nacionalidade")]
        public string nacionalidade { get; set; }

        [Required(ErrorMessage = "Campo Grau de Instrução é obrigatório.")]
        [Display(Name = "Grau de Instrução")]
        public string grau_instrucao { get; set; }

        [Required(ErrorMessage = "Campo Cor é obrigatório.")]
        [Display(Name = "Cor")]
        public string cor { get; set; }
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

        [Required(ErrorMessage = "Campo Setor é obrigatório.")]
        [Display(Name = "Setor")]
        public setor setor { get; set; }
        public int setor_id { get; set; }
        public string orgao_emissor_rg { get; set; }
        public string categoria_cnh { get; set; }

        [Required(ErrorMessage = "Campo Data de Admissão é obrigatório.")]
        [Display(Name = "Data de Admissão")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime data_admissao { get; set; }

        [Required(ErrorMessage = "Campo Salário Inicial é obrigatório.")]
        [Display(Name = "Salário Inicial")]
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public decimal salario_inicial { get; set; }

        [Required(ErrorMessage = "Campo Salário Atual é obrigatório.")]
        [Display(Name = "Salário Atual")]
        [DisplayFormat(DataFormatString = "{0:c2}")]
        public decimal salario_atual { get; set; }

        [Required(ErrorMessage = "Campo Cargo é obrigatório.")]
        [Display(Name = "Cargo")]
        public cargo cargo { get; set; }
        public int cargo_id { get; set; }
        public int cargo_contratacao_id { get; set; }

        [Required(ErrorMessage = "Campo Cargo Contração é obrigatório.")]
        [Display(Name = "Cargo Contratação")]
        public cargo cargo_contratacao { get; set; }
        public bool ativo { get; set; }
        public int empresa_id { get; set; }

        [Required(ErrorMessage = "Campo Empresa é obrigatório.")]
        [Display(Name = "Empresa")]
        public empresa empresa { get; set; }
        public string mae { get; set; }
        public string pai { get; set; }
        public string portaria_decreto { get; set; }
        public DateTime? data_publicacao { get; set; }
        public string banco { get; set; }
        public int? agencia { get; set; }

        [StringLength(1, ErrorMessage = "O campo Dígito Agência suporta no máximo é de 1 caracter.")]
        public string digito_agencia { get; set; }
        public int? numero_conta { get; set; }
        [StringLength(1, ErrorMessage = "O campo Dígito Conta suporta no máximo é de 1 caracter.")]
        public string digito_conta { get; set; }

        public virtual EntityCollection<dependente> dependente { get; set; }
        public virtual EntityCollection<ferias> ferias { get; set; }
        public virtual EntityCollection<movimentacao> movimentacao { get; set; }


        public System.Drawing.Image Imagem
        {
            get
            {
                System.Drawing.Image img;
                if (this.foto == null || this.foto.Length == 0)
                {
                    if (string.IsNullOrWhiteSpace(this.sexo) || sexo.Equals("M"))
                    {
                        return img = System.Drawing.Image.FromFile("D:\\Sistemas\\SisCad\\Images\\homem.png");
                    }
                    return img = System.Drawing.Image.FromFile("D:\\Sistemas\\SisCad\\Images\\mulher.png");
                }
                System.IO.MemoryStream memory = new System.IO.MemoryStream(this.foto);
                img = System.Drawing.Image.FromStream(memory);
                return img;
            }
        }

    }
}