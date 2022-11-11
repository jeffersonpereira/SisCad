using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public partial class empresa : classe_base
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
    }
}