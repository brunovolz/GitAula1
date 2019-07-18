select 
	tipo as 'HOTDOG',
	sum (vendas) as 'Quantidade vendida',
	month(data) as 'Mês'
	from hotdog
group by tipo,data
order by sum (vendas) desc
----------------------------------------------- 
Selecionar perido para informar, no caso, mes 1 ao 3.

where month(data) between 1 and 3
