select
	Aluno,
	Idade,
	iif(ativo = 1, 'Ativo', 'Inativo') as 'Status'
from AulaCsharp
where Id in
(select Id from AulaCsharp where ativo = 1)
order by Id desc;