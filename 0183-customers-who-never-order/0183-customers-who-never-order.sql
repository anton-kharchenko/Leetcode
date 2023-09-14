Select cust.name as Customers
From Customers cust
Where not exists (select 1 from orders ord Where ord.customerId = cust.id)
