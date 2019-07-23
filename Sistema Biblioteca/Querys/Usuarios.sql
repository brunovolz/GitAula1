CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Nome] varchar(100) not null,
	[Login] varchar(50) not null,
	[Senha] varchar(50) not null,
	[E-mail] varchar(100) not null,
	[Ativo] bit not null,
	[UsuInc] int not null,
	[UsuAlt] int not null,
	[DatInc] datetime not null default GETDATE(),
	[DatAlt] datetime not null default GETDATE()
	)
