select 
	tipo as 'HOTDOG',
	sum (vendas) as 'Quantidade vendida',
	month(data) as 'Mês'
	from hotdog
group by tipo,data
order by sum (vendas) desc