CREATE TABLE [dbo].[Livro]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Registro] int not null,
	[Titulo] varchar(1200) not null,
	[Isbn] varchar(15) not null,
	[Genero] int not null,
	[Editora] int not null,
	[Sinopse] NVARCHAR(MAX) null,
	[Observaçoes] varchar(1000) null,
	[Ativo] bit not null,
	[UsuInc] int not null,
	[UsuAlt] int not null,
	[DatInc] datetime not null,
	[DatAlt] datetime not null, 
    CONSTRAINT [FK_Livro_To_Genero] FOREIGN KEY ([Genero]) REFERENCES [Generos]([Id]), 
    CONSTRAINT [FK_Livro_To_Editora] FOREIGN KEY ([Editora]) REFERENCES [Editoras]([Id]),
	CONSTRAINT [FK_Livro_To_UsuarioInc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]), 
    CONSTRAINT [FK_Livro_To_UsuarioAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id])

)
