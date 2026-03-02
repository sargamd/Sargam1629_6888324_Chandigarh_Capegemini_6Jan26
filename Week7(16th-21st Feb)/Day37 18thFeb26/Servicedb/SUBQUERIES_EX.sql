SELECT agent_name, agent_code, phone_no
FROM agents
WHERE agent_code = 
(SELECT agent_code 
FROM agents
WHERE agent_name = 'Alex');

SELECT ord_num,ord_amount,ord_date,cust_code, agent_code
FROM orders
WHERE ord_amount>
(SELECT AVG(ord_amount)
FROM orders
WHERE ord_date='20-APR-08');

SELECT AVG(ord_amount)
FROM orders
WHERE ord_date='20-APR-08';


--retrieves 'ord_amount, number of agent_codes and agent_code' from the table orders with following conditions:
-- agent_code of orders table must come distinctly.
-- an average of ord_amount of each group of agent_code in orders table must be equal to the average ord_amount of orders table.
-- agent_code of orders table must be 'A008'.

SELECT AVG(ord_amount),COUNT(agent_code),agent_code
FROM orders 
GROUP BY agent_code
HAVING AVG(ord_amount)=
(SELECT AVG(ord_amount) 
FROM orders
WHERE agent_code='A008');


--To get 'ord_num', 'ord_amount', 'ord_date', 'cust_code' and 'agent_code' from the table 'orders' with following conditions :
--Sample table : agents
--Sample table : orders
--in the outer query : 
--'agent_code' of 'orders' table must be in the list within IN operator in inner query :
--in inner query : 
--'working_area' of 'agents' table must be 'Bangalore',


SELECT ord_num,ord_amount,ord_date,
cust_code, agent_code
FROM orders
WHERE agent_code IN(
SELECT agent_code FROM agents
WHERE working_area='Bangalore');

--To get 'ord_num', 'ord_amount', 'ord_date', 'cust_code' and 'agent_code' from the table 'orders' with following conditions :
--in outer query : 
--'agent_code' of 'orders' table must be other than the list within IN operator.
--in inner query : 
--'working_area' of 'agents' table must be 'Mumbai'
SELECT ord_num,ord_amount,ord_date,
cust_code, agent_code
FROM orders
WHERE agent_code NOT IN(
SELECT agent_code FROM agents
WHERE working_area='Bangalore');

--To get 'agent_code', 'agent_name', 'working_area', 'commission' from 'agents' table with following conditions -
--in outer query : 
--'agent_code' should be any 'agent_code' from 'customer' table
--in inner query : 
--) 'cust_country' in the 'customer' table must be 'UK',

SELECT agent_code,agent_name,working_area,commission
FROM  agents
WHERE agent_code=ANY(
SELECT agent_code FROM customer
WHERE cust_country='UK');

--retrieves the order amount with the lowest price, group by agent code(ERROR)
select ord_num, agent_code, ord_date, ord_amount
from orders
where(agent_code,ord_amount) IN
(SELECT agent_code, MIN(ord_amount)
FROM orders
GROUP BY agent_code) 


--To get 'ord_num', 'ord_amount', 'ord_date', 'cust_code' and 'agent_code' from the table 'orders' with following conditions -
--in outer query :
--the 'agent_code' of 'orders' table must be the same 'agent_code' of 'orders' table with following conditions - 
 --'agent_code' of 'orders' table should come distinctly with following
--inner query : 
--;the 'cust_code' of 'orders' table must be 'C00005'
SELECT ord_num,ord_amount,ord_date,
cust_code, agent_code
FROM orders
WHERE agent_code=(
SELECT DISTINCT agent_code
FROM orders WHERE cust_code='C00005');






