USE [SisCad]
go

-- Drop Referencing Constraint SQL

ALTER TABLE dbo.setor DROP CONSTRAINT fk_centro_custo_to_setor
go
ALTER TABLE dbo.setor DROP CONSTRAINT fk_departamento_to_setor
go
ALTER TABLE dbo.funcionario DROP CONSTRAINT fk_empresa_to_funcionario
go
ALTER TABLE dbo.funcionario DROP CONSTRAINT fk_setor_to_funcionario
go

-- Drop Constraint, Rename and Create Table SQL

EXEC sp_rename 'dbo.centro_custo.pk_centro_custo','pk_centro__07082012002240001','INDEX'
go
EXEC sp_rename 'dbo.centro_custo','centro_cus_07082012002240000',OBJECT
go
CREATE TABLE dbo.centro_custo
(
    centro_custo_id int           IDENTITY,
    codigo          int           NOT NULL,
    descricao       varchar(100)  NOT NULL
)
ON [PRIMARY]
go
EXEC sp_rename 'dbo.departamento.pk_departamento','pk_departa_07082012002241001','INDEX'
go
EXEC sp_rename 'dbo.departamento','departamen_07082012002241000',OBJECT
go
CREATE TABLE dbo.departamento
(
    departamento_id int           IDENTITY,
    codigo          int           NOT NULL,
    descricao       varchar(100)  NOT NULL,
    empresa_id      int           NOT NULL
)
ON [PRIMARY]
go
EXEC sp_rename 'dbo.empresa.pk_empresa','pk_empresa_07082012002242001','INDEX'
go
EXEC sp_rename 'dbo.fk_municipio_to_empresa','fk_municip_07082012002242002'
go
EXEC sp_rename 'dbo.empresa','empresa_07082012002242000',OBJECT
go
CREATE TABLE dbo.empresa
(
    empresa_id   int           IDENTITY,
    caminho_logo varchar(256)  NULL,
    razao_social varchar(150)  NOT NULL,
    cnpj         char(14)      NOT NULL,
    endereco     varchar(50)   NULL,
    numero       char(5)       NULL,
    bairro       varchar(30)   NULL,
    complemento  varchar(20)   NULL,
    cep          char(8)       NULL,
    municipio_id int           NOT NULL,
    gestor_id    int           NOT NULL
)
ON [PRIMARY]
go
EXEC sp_rename 'dbo.setor.pk_setor','pk_setor_07082012002243001','INDEX'
go
EXEC sp_rename 'dbo.setor','setor_07082012002243000',OBJECT
go
CREATE TABLE dbo.setor
(
    setor_id        int           IDENTITY,
    codigo          int           NOT NULL,
    descricao       varchar(100)  NOT NULL,
    departamento_id int           NOT NULL,
    centro_custo_id int           NOT NULL
)
ON [PRIMARY]
go
CREATE TABLE dbo.gestor
(
    nome          varchar(100)  NOT NULL,
    gestor_id     int           IDENTITY,
    cpf           char(11)      NULL,
    nascimento    datetime      NOT NULL,
    endereco      varchar(30)   NULL,
    numero        char(5)       NULL,
    complemento   char(20)      NULL,
    bairro        varchar(20)   NULL,
    inicio_gestao datetime      NULL,
    fim_gestao    datetime      NULL,
    CONSTRAINT PK12
    PRIMARY KEY NONCLUSTERED (gestor_id)
)
go

-- Insert Data SQL

SET IDENTITY_INSERT dbo.centro_custo ON
go
INSERT INTO dbo.centro_custo(
                             centro_custo_id,
                             codigo,
                             descricao
                            )
                      SELECT 
                             centro_custo_id,
                             0,
                             descricao
                        FROM dbo.centro_cus_07082012002240000 
go
SET IDENTITY_INSERT dbo.centro_custo OFF
go
SET IDENTITY_INSERT dbo.departamento ON
go
INSERT INTO dbo.departamento(
                             departamento_id,
                             codigo,
                             descricao,
                             empresa_id
                            )
                      SELECT 
                             departamento_id,
                             0,
                             descricao,
                             0
                        FROM dbo.departamen_07082012002241000 
go
SET IDENTITY_INSERT dbo.departamento OFF
go
SET IDENTITY_INSERT dbo.empresa ON
go
INSERT INTO dbo.empresa(
                        empresa_id,
                        caminho_logo,
                        razao_social,
                        cnpj,
                        endereco,
                        numero,
                        bairro,
                        complemento,
                        cep,
                        municipio_id,
                        gestor_id
                       )
                 SELECT 
                        empresa_id,
                        caminho_logo,
                        razao_social,
                        cnpj,
                        endereco,
                        numero,
                        bairro,
                        complemento,
                        cep,
                        municipio_id,
                        0
                   FROM dbo.empresa_07082012002242000 
go
SET IDENTITY_INSERT dbo.empresa OFF
go
SET IDENTITY_INSERT dbo.setor ON
go
INSERT INTO dbo.setor(
                      setor_id,
                      codigo,
                      descricao,
                      departamento_id,
                      centro_custo_id
                     )
               SELECT 
                      setor_id,
                      0,
                      descricao,
                      departamento_id,
                      centro_custo_id
                 FROM dbo.setor_07082012002243000 
go
SET IDENTITY_INSERT dbo.setor OFF
go

-- Add Constraint SQL

ALTER TABLE dbo.centro_custo ADD CONSTRAINT pk_centro_custo
PRIMARY KEY NONCLUSTERED (centro_custo_id)
go
ALTER TABLE dbo.departamento ADD CONSTRAINT pk_departamento
PRIMARY KEY NONCLUSTERED (departamento_id)
go
ALTER TABLE dbo.empresa ADD CONSTRAINT pk_empresa
PRIMARY KEY NONCLUSTERED (empresa_id)
go
ALTER TABLE dbo.setor ADD CONSTRAINT pk_setor
PRIMARY KEY NONCLUSTERED (setor_id)
go

-- Add Referencing Foreign Keys SQL

ALTER TABLE dbo.setor ADD CONSTRAINT fk_centro_custo_to_setor
FOREIGN KEY (centro_custo_id)
REFERENCES dbo.centro_custo (centro_custo_id)
go
ALTER TABLE dbo.setor ADD CONSTRAINT fk_departamento_to_setor
FOREIGN KEY (departamento_id)
REFERENCES dbo.departamento (departamento_id)
go
ALTER TABLE dbo.funcionario ADD CONSTRAINT fk_empresa_to_funcionario
FOREIGN KEY (empresa_id)
REFERENCES dbo.empresa (empresa_id)
go
ALTER TABLE dbo.funcionario ADD CONSTRAINT fk_setor_to_funcionario
FOREIGN KEY (setor_id)
REFERENCES dbo.setor (setor_id)
go
ALTER TABLE dbo.departamento ADD FOREIGN KEY (empresa_id)
REFERENCES dbo.empresa (empresa_id)
go
ALTER TABLE dbo.empresa ADD CONSTRAINT fk_municipio_to_empresa
FOREIGN KEY (municipio_id)
REFERENCES dbo.municipio (municipio_id)
go
ALTER TABLE dbo.empresa ADD CONSTRAINT fk_gestor_to_empresa
FOREIGN KEY (gestor_id)
REFERENCES dbo.gestor (gestor_id)
go
