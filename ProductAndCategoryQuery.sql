use Nomenclature

select p.Name, c.Name from Product as p
left join ProductCategory as pc 
on p.Id = pc.ProductId
left join Category as c
on pc.CategoryId = c.Id