CREATE TABLE [dbo].[LIVROS]
(
	[ID] INT PRIMARY KEY IDENTITY(1,1) not null,
	[Nome] VARCHAR(100) not null,
	[Autor] varchar(50) not null,
	[Alocado] bit not null,
	[UsuInc] int not null,
	[UsuAlt] int not null,
	[DatInc] datetime not null,
	[DatAlt] datetime not null, 
    [Cd_Biblioteca] INT NOT NULL, 
	PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LIVROS_UsuarioInc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuario]([ID]), 
    CONSTRAINT [FK_LIVROS_UsuarioAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuario]([ID]), 
    CONSTRAINT [FK_LIVROS_Cd_Biblioteca] FOREIGN KEY ([Cd_Biblioteca]) REFERENCES [Biblioteca]([ID]) 
)