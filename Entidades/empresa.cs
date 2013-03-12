using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Drawing;

namespace Model.Data
{
    public partial class empresa : IValidade
    {
        [Key]
        public int empresa_id { get; set; }
        [Required(ErrorMessage = "Campo razão social deve ser informado.")]
        public string razao_social { get; set; }
        public byte[] logo { get; set; }
        [Required(ErrorMessage = "Campo cnpj deve ser informado.")]
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        [Required(ErrorMessage = "Campo município deve ser informado.")]
        public municipio municipio { get; set; }
        public int municipio_id { get; set; }
        public int gestor_id { get; set; }
        [Required(ErrorMessage = "Campo gestor deve ser informado.")]
        public gestor gestor { get; set; }
        public virtual List<funcionario> funcionario { get; set; }
        public virtual List<departamento> departamento { get; set; }

        public System.Drawing.Image Imagem
        {
            get
            {
                System.Drawing.Image img;
                if (this.logo == null || this.logo.Length == 0)
                {
                    return img = System.Drawing.Image.FromFile("D:\\Sistemas\\SisCad\\Images\\mulher.png");
                }
                System.IO.MemoryStream memory = new System.IO.MemoryStream(this.logo);
                img = System.Drawing.Image.FromStream(memory);
                return img;
            }
        }

        public List<ValidationResult> GetValidationResult()
        {
            ValidationContext context = new ValidationContext(this, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            Validator.TryValidateObject(this, context, result);
            return result;
        }
    }
}
