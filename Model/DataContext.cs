using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using Data.Entidades;
using System.Configuration;



namespace Model.Data
{
    public partial class DataContext : ObjectContext
    {
        public DataContext(string connection, string defaultContainerName)
            : base(connection,defaultContainerName)
        {
            if (!this.DatabaseExists())
            {
                this.CreateDatabase();
            }
        }

        IObjectSet<centro_custo> _centro;
        public IObjectSet<centro_custo> centro_custo
        {
            get
            {
                if (_centro == null)
                {
                    _centro = CreateObjectSet<centro_custo>();
                }
                return _centro;
            }
        }

        IObjectSet<dependente> _dependente;
        public IObjectSet<dependente> dependente
        {
            get
            {
                if (_dependente == null)
                {
                    _dependente = CreateObjectSet<dependente>();
                }
                return _dependente;
            }
        }

        IObjectSet<departamento> _departamento;
        public IObjectSet<departamento> departamento
        {
            get
            {
                if (_departamento == null)
                {
                    _departamento = CreateObjectSet<departamento>();
                }
                return _departamento;
            }
        }

        IObjectSet<municipio> _municipio;
        public IObjectSet<municipio> municipio
        {
            get
            {
                if (_municipio == null)
                {
                    _municipio = CreateObjectSet<municipio>();
                }
                return _municipio;
            }
        }

        IObjectSet<ferias> _ferias;
        public IObjectSet<ferias> ferias
        {
            get
            { 
                if(ferias==null)
                {
                    _ferias = CreateObjectSet<ferias>();
                }
                return _ferias;
            }
        }
        IObjectSet<empresa> _empresa;
        public IObjectSet<empresa> empresa
        {
            get
            {
                if (_empresa == null)
                {
                    _empresa = CreateObjectSet<empresa>();
                }
                return _empresa;
            }
        }

        IObjectSet<cargo> _cargo;
        public IObjectSet<cargo> cargo
        {
            get
            {
                if (_cargo == null)
                {
                    _cargo = CreateObjectSet<cargo>();
                }
                return _cargo;
            }
        }

        IObjectSet<setor> _setor;
        public IObjectSet<setor> setor
        {
            get
            {
                if (_setor == null)
                {
                    _setor = CreateObjectSet<setor>();
                }
                return _setor;
            }
        }

        IObjectSet<funcionario> _funcionario;
        public IObjectSet<funcionario> funcionario
        {
            get
            {
                if (_funcionario == null)
                {
                    _funcionario = CreateObjectSet<funcionario>();
                }
                return _funcionario;
            }
        }

        IObjectSet<usuario> _usuario;
        public IObjectSet<usuario> usuario
        {
            get
            {
                if (_usuario == null)
                {
                    _usuario = CreateObjectSet<usuario>();
                }
                return _usuario;
            }
        }

        IObjectSet<movimentacao> _movimentacao;
        public IObjectSet<movimentacao> movimentacao
        {
            get
            {
                if (_movimentacao == null)
                {
                    _movimentacao = CreateObjectSet<movimentacao>();
                }
                return _movimentacao;
            }
        }

        IObjectSet<gestor> _gestor;
        public IObjectSet<gestor> gestor
        {
            get
            {
                if (_gestor == null)
                {
                    _gestor = CreateObjectSet<gestor>();
                }
                return _gestor;
            }
        }

        public bool SaveAll()
        {
            return SaveChanges() > 0;
        }

        #region Adicionar ao context

        public void AddToCentroCusto(centro_custo centro_custo)
        {
            AddObject("centro_custo", centro_custo);
        }

        public void AddToDependente(dependente dependente)
        {
            AddObject("dependente", dependente);
        }

        public void AddToDepartamento(departamento departamento)
        {
            AddObject("departamento", departamento);
        }

        public void AddToEmpresa(empresa empresa)
        {
            AddObject("empresa", empresa);
        }

        public void AddToGestor(gestor gestor)
        {
            AddObject("gesto", gestor);
        }

        public void AddToFuncionario(funcionario funcionario)
        {
            AddObject("funcionario", funcionario);
        }

        public void AddToMovimentacao(movimentacao movimentacao)
        {
            AddObject("movimentacao", movimentacao);
        }

        public void AddToFerias(ferias ferias)
        {
            AddObject("ferias", ferias);
        }

        public void AddToMunicipio(municipio municipio)
        {
            AddObject("municipio", municipio);
        }

        public void AddToCargo(cargo cargo)
        {
            AddObject("cargo", cargo);
        }

        public void AddToUsuario(usuario usuario)
        {
            AddObject("usuario", usuario);
        }

        public void AddToSetor(setor setor)
        {
            AddObject("setor", setor);
        }
        #endregion

        /// <summary>
        /// Retorna os departamentos da empresa atual.
        /// </summary>
        /// <returns></returns>
        public IList<departamento> GetDepartamentosByEmpresa()
        {
            return departamento.Where(d => d.empresa_id == GlobalVar.EmpresaAtual.empresa_id).ToList();
        }

        /// <summary>
        /// Retorna os funcionários da empresa atual.
        /// </summary>
        /// <returns></returns>
        public IList<funcionario> GetFuncionarioByEmpresa()
        {
            return funcionario.Where(f => f.empresa_id == GlobalVar.EmpresaAtual.empresa_id).ToList();
        }

        /// <summary>
        /// Retorna as movimentações do funcionário.
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns></returns>
        public IList<movimentacao> GetMovimentacaoByFuncionario(funcionario funcionario)
        {
            return movimentacao.Where(m => m.funcionario_id == funcionario.funcionario_id).ToList();
        }

        /// <summary>
        /// Retorna as férias do funcionário.
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns></returns>
        public IList<ferias> GetFeriasByFuncionario(funcionario funcionario)
        {
            return ferias.Where(f => f.funcionario_id == funcionario.funcionario_id).ToList();
        }

    }
}
