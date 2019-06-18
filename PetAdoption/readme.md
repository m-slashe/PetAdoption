Pet
	Nome
	Data de Nascimento
	Sexo
	História
	Raça
	Especie
	Porte
	Abrigo

Raça
	Nome
	
Especie
	Nome
	
Abrigo
	Nome

Porte
	Nome

Usuario
	Nome
	Senha
	
CREATE TABLE [dbo].[Usuario]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Nome] NVARCHAR(50) NULL,
	[Email] NVARCHAR(50) NULL,
	[Senha] NVARCHAR(50) NULL
)

CREATE TABLE [dbo].[Raca]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Nome] NVARCHAR(50) NULL
)

CREATE TABLE [dbo].[Especie]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Nome] NVARCHAR(50) NULL
)

CREATE TABLE [dbo].[Abrigo]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Nome] NVARCHAR(50) NULL
)

CREATE TABLE [dbo].[Porte]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Nome] NVARCHAR(50) NULL
)

CREATE TABLE [dbo].[Pet]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Nome] NVARCHAR(50) NULL,
	[DataDeNascimento] DATE NULL,
	[Sexo] NVARCHAR(50) NULL,
	[Historia] NVARCHAR(MAX) NULL,
	[IdRaca] INT NULL,
	[IdEspecie] INT NULL,
	[IdPorte] INT NULL,
	[IdAbrigo] INT NULL,
	FOREIGN KEY (IdRaca) REFERENCES [Raca](Id),
	FOREIGN KEY (IdEspecie) REFERENCES [Especie](Id),
	FOREIGN KEY (IdPorte) REFERENCES [Porte](Id),
	FOREIGN KEY (IdAbrigo) REFERENCES [Abrigo](Id),
)