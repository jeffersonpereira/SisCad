using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Configuration;


namespace Model.Data
{
    public partial class SisCadEntities
    {

        public empresa EmpresaAtual
        {
            get
            {
                if (GlobalVar.EmpresaAtual != null)
                {
                    return empresa.First(e => e.empresa_id == GlobalVar.EmpresaAtual.empresa_id);
                }
                return null;
            }
        }

        public int GetProximoCodigoSetor()
        {
            if (!this.setor.Any(s => s.departamento.empresa_id == EmpresaAtual.empresa_id))
            {
                return 1;
            }
            int codigo = this.setor.Where(s => s.departamento.empresa_id == EmpresaAtual.empresa_id).Max(m => m.codigo);
            return codigo + 1;
        }

        public int GetProximoCodigoDepartamentor()
        {
            if (!this.departamento.Any(s => s.empresa_id == EmpresaAtual.empresa_id))
            {
                return 1;
            }
            int codigo = this.departamento.Where(s => s.empresa_id == EmpresaAtual.empresa_id).Max(m => m.codigo);
            return codigo+1;
        }

        public int GetProximoMatricula()
        {
            if (!this.funcionario.Any(s => s.empresa_id == EmpresaAtual.empresa_id))
            {
                return 1;
            }
            int codigo = this.funcionario.Where(s => s.empresa_id == EmpresaAtual.empresa_id).Max(m => m.matricula);
            return codigo + 1;
        }

        public bool Autenticate(string login, string senha)
        {
            usuario u = GetUsuario(login);
            if (u == null)
            {
                return false;
            }
            return Security.VeryHash(senha, u.senha);
        }

        private usuario GetUsuario(string login)
        {
            return usuario.FirstOrDefault(u=>u.login.Equals(login));
        }
    }
}
