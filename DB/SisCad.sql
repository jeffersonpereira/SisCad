/*
 * ER/Studio 8.0 SQL Code Generation
 * Company :      Microsoft
 * Project :      SisCad.dm1
 * Author :       Microsoft
 *
 * Date Created : Friday, April 27, 2012 14:24:08
 * Target DBMS : Microsoft SQL Server 2008
 */

USE SisCad
go
/* 
 * TABLE: cargo 
 */

CREATE TABLE cargo(
    cargo_id     int             IDENTITY(1,1),
    descricao    varchar(100)    NOT NULL,
    cbo          char(8)         NULL,
    CONSTRAINT pk_cargo PRIMARY KEY NONCLUSTERED (cargo_id)
)
go



IF OBJECT_ID('cargo') IS NOT NULL
    PRINT '<<< CREATED TABLE cargo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE cargo >>>'
go

/* 
 * TABLE: centro_custo 
 */

CREATE TABLE centro_custo(
    centro_custo_id    int             IDENTITY(1,1),
    descricao          varchar(100)    NOT NULL,
    CONSTRAINT pk_centro_custo PRIMARY KEY NONCLUSTERED (centro_custo_id)
)
go



IF OBJECT_ID('centro_custo') IS NOT NULL
    PRINT '<<< CREATED TABLE centro_custo >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE centro_custo >>>'
go

/* 
 * TABLE: departamento 
 */

CREATE TABLE departamento(
    departamento_id    int             IDENTITY(1,1),
    descricao          varchar(100)    NOT NULL,
    CONSTRAINT pk_departamento PRIMARY KEY NONCLUSTERED (departamento_id)
)
go



IF OBJECT_ID('departamento') IS NOT NULL
    PRINT '<<< CREATED TABLE departamento >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE departamento >>>'
go

/* 
 * TABLE: dependente 
 */

CREATE TABLE dependente(
    dependente_id      int             IDENTITY(1,1),
    nome               varchar(100)    NOT NULL,
    data_nascimento    datetime        NULL,
    parentesco         int             NOT NULL,
    funcionario_id     int             NOT NULL,
    CONSTRAINT pk_dependente PRIMARY KEY NONCLUSTERED (dependente_id)
)
go



IF OBJECT_ID('dependente') IS NOT NULL
    PRINT '<<< CREATED TABLE dependente >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE dependente >>>'
go

/* 
 * TABLE: empresa 
 */

CREATE TABLE empresa(
    empresa_id      int             IDENTITY(1,1),
    caminho_logo    varchar(256)    NULL,
    razao_social    varchar(150)    NOT NULL,
    cnpj            char(14)        NOT NULL,
    endereco        varchar(50)     NULL,
    numero          char(5)         NULL,
    bairro          varchar(30)     NULL,
    complemento     varchar(20)     NULL,
    cep             char(8)         NULL,
    municipio_id    int             NOT NULL,
    CONSTRAINT pk_empresa PRIMARY KEY NONCLUSTERED (empresa_id)
)
go



IF OBJECT_ID('empresa') IS NOT NULL
    PRINT '<<< CREATED TABLE empresa >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE empresa >>>'
go

/* 
 * TABLE: ferias 
 */

CREATE TABLE ferias(
    ferias_id           int         IDENTITY(1,1),
    inicio_aquisicao    datetime    NOT NULL,
    fim_aquisicao       datetime    NOT NULL,
    abono_pecuniario    bit         NOT NULL,
    inicio_gozo         datetime    NOT NULL,
    fim_gozo            datetime    NOT NULL,
    funcionario_id      int         NOT NULL,
    CONSTRAINT pk_ferias PRIMARY KEY NONCLUSTERED (ferias_id)
)
go



IF OBJECT_ID('ferias') IS NOT NULL
    PRINT '<<< CREATED TABLE ferias >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE ferias >>>'
go

/* 
 * TABLE: funcionario 
 */

CREATE TABLE funcionario(
    funcionario_id               int              IDENTITY(1,1),
    matricula                    int              NOT NULL,
    nome                         varchar(100)     NOT NULL,
    data_nascimento              datetime         NOT NULL,
    sexo                         char(1)          NOT NULL,
    endereco                     varchar(50)      NULL,
    numero                       char(5)          NULL,
    bairro                       varchar(30)      NULL,
    cep                          char(8)          NULL,
    municipio_id                 int              NOT NULL,
    municipio_id_naturalidade    int              NOT NULL,
    telefone_residencial         char(10)         NULL,
    telefone_celular             char(10)         NULL,
    telefone_recado              char(10)         NULL,
    estado_civil                 int              NOT NULL,
    grau_instrucao               int              NOT NULL,
    cor                          int              NOT NULL,
    rg                           char(20)         NULL,
    data_emissao_rg              datetime         NULL,
    orgao_emissor_rg             char(6)          NULL,
    cpf                          char(11)         NULL,
    pis                          char(11)         NULL,
    ctps                         char(10)         NULL,
    serie                        char(5)          NULL,
    data_expedicao_ctps          datetime         NULL,
    data_expedicao_cnh           datetime         NULL,
    titulo_eleitor               char(10)         NULL,
    zona                         char(4)          NULL,
    secao                        char(4)          NULL,
    cnh                          char(10)         NULL,
    categoria_cnh                char(1)          NULL,
    data_admissao                datetime         NOT NULL,
    salario_inicial              decimal(9, 2)    NOT NULL,
    salario_atual                decimal(9, 2)    NOT NULL,
    setor_id                     int              NOT NULL,
    cargo_id                     int              NOT NULL,
    cargo_contratacao_id         int              NOT NULL,
    caminho_foto                 varchar(256)     NULL,
    ativo                        bit              NOT NULL,
    empresa_id                   int              NOT NULL,
    mae                          varchar(100)     NULL,
    pai                          varchar(100)     NULL,
    CONSTRAINT pk_funcionario PRIMARY KEY NONCLUSTERED (funcionario_id)
)
go



IF OBJECT_ID('funcionario') IS NOT NULL
    PRINT '<<< CREATED TABLE funcionario >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE funcionario >>>'
go

/* 
 * TABLE: movimentacao 
 */

CREATE TABLE movimentacao(
    movimentacao_id      int             IDENTITY(1,1),
    descricao            varchar(200)    NOT NULL,
    data_saida           datetime        NOT NULL,
    data_retorno         datetime        NULL,
    funcionario_id       int             NOT NULL,
    tipo_movimentacao    int             NOT NULL,
    CONSTRAINT pk_movimentacao PRIMARY KEY NONCLUSTERED (movimentacao_id)
)
go



IF OBJECT_ID('movimentacao') IS NOT NULL
    PRINT '<<< CREATED TABLE movimentacao >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE movimentacao >>>'
go

/* 
 * TABLE: municipio 
 */

CREATE TABLE municipio(
    municipio_id    int             IDENTITY(1,1),
    nome            varchar(100)    NOT NULL,
    uf              char(2)         NOT NULL,
    CONSTRAINT pk_municipio PRIMARY KEY NONCLUSTERED (municipio_id)
)
go



IF OBJECT_ID('municipio') IS NOT NULL
    PRINT '<<< CREATED TABLE municipio >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE municipio >>>'
go

/* 
 * TABLE: setor 
 */

CREATE TABLE setor(
    setor_id           int             IDENTITY(1,1),
    descricao          varchar(100)    NOT NULL,
    departamento_id    int             NOT NULL,
    centro_custo_id    int             NOT NULL,
    CONSTRAINT pk_setor PRIMARY KEY NONCLUSTERED (setor_id)
)
go



IF OBJECT_ID('setor') IS NOT NULL
    PRINT '<<< CREATED TABLE setor >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE setor >>>'
go

/* 
 * TABLE: usuario 
 */

CREATE TABLE usuario(
    usuario_id    int             IDENTITY(1,1),
    nome          varchar(100)    NOT NULL,
    login         varchar(50)     NOT NULL,
    senha         varchar(256)    NOT NULL,
    CONSTRAINT pk_usuario PRIMARY KEY NONCLUSTERED (usuario_id)
)
go



IF OBJECT_ID('usuario') IS NOT NULL
    PRINT '<<< CREATED TABLE usuario >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE usuario >>>'
go

/* 
 * TABLE: dependente 
 */

ALTER TABLE dependente ADD CONSTRAINT fk_funcionario_to_dependente 
    FOREIGN KEY (funcionario_id)
    REFERENCES funcionario(funcionario_id)
go


/* 
 * TABLE: empresa 
 */

ALTER TABLE empresa ADD CONSTRAINT fk_municipio_to_empresa 
    FOREIGN KEY (municipio_id)
    REFERENCES municipio(municipio_id)
go


/* 
 * TABLE: ferias 
 */

ALTER TABLE ferias ADD CONSTRAINT fk_funcionario_to_ferias 
    FOREIGN KEY (funcionario_id)
    REFERENCES funcionario(funcionario_id)
go


/* 
 * TABLE: funcionario 
 */

ALTER TABLE funcionario ADD CONSTRAINT fk_cargo_atual_to_funcionario 
    FOREIGN KEY (cargo_id)
    REFERENCES cargo(cargo_id)
go

ALTER TABLE funcionario ADD CONSTRAINT fk_cargo_contratado_to_funcionario 
    FOREIGN KEY (cargo_contratacao_id)
    REFERENCES cargo(cargo_id)
go

ALTER TABLE funcionario ADD CONSTRAINT fk_empresa_to_funcionario 
    FOREIGN KEY (empresa_id)
    REFERENCES empresa(empresa_id)
go

ALTER TABLE funcionario ADD CONSTRAINT fk_municipio_naturalidade_to_funcionario 
    FOREIGN KEY (municipio_id_naturalidade)
    REFERENCES municipio(municipio_id)
go

ALTER TABLE funcionario ADD CONSTRAINT fk_municipio_to_funcionario 
    FOREIGN KEY (municipio_id)
    REFERENCES municipio(municipio_id)
go

ALTER TABLE funcionario ADD CONSTRAINT fk_setor_to_funcionario 
    FOREIGN KEY (setor_id)
    REFERENCES setor(setor_id)
go


/* 
 * TABLE: movimentacao 
 */

ALTER TABLE movimentacao ADD CONSTRAINT fk_funcionario_to_movimentacao 
    FOREIGN KEY (funcionario_id)
    REFERENCES funcionario(funcionario_id)
go


/* 
 * TABLE: setor 
 */

ALTER TABLE setor ADD CONSTRAINT fk_centro_custo_to_setor 
    FOREIGN KEY (centro_custo_id)
    REFERENCES centro_custo(centro_custo_id)
go

ALTER TABLE setor ADD CONSTRAINT fk_departamento_to_setor 
    FOREIGN KEY (departamento_id)
    REFERENCES departamento(departamento_id)
go


