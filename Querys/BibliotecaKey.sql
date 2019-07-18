select 
	Bl.Nome as 'Biblioteca',
	count(lv.id) as 'Quantidade de Livros',
	Us.NOME as 'User Name'
	from Biblioteca bl
	inner join LIVROS lv on bl.id = lv.Cd_Biblioteca
	inner join Usuario us on lv.UsuInc = us.Id
	group by bl.NOME, us.NOME