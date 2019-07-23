CREATE TABLE [dbo].[Locaçao]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[Livro] INt not null,
	[Usuario] INT NOT NULL,
	[Tipo] INT NOT NULL,
	[Devoluçao] datetime not null,
	[Ativo] bit not null,
	[UsuInc] int not null,
	[UsuAlt] int not null,
	[DatInc] datetime not null default getdate(),
	[DatAlt] datetime not null default getdate(),
    CONSTRAINT [FK_Locaçao_Livros] FOREIGN KEY ([Livro]) REFERENCES [Livros]([Id]),
    CONSTRAINT [FK_Locaçao_UsuarioAloc] FOREIGN KEY ([Usuario]) REFERENCES [Usuarios]([Id]),
    CONSTRAINT [FK_Locaçao_UsuInc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
    CONSTRAINT [FK_Locaçao_UsuAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id])
)
