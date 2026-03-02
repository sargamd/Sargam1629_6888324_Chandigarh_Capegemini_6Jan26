use Sargamdemodb
create table salespeople(snum int,sname varchar(50),city varchar(30),comm int)
insert into salespeople values(1001,'Peel','London',12)
insert into salespeople values(1002,'Serres','San Jose',13)
insert into salespeople values(1004,'Motika','London',11)
insert into salespeople values(1007,'Rafkin','Barcelona',15)
insert into salespeople values(1003,'Axelrod','New York',1)

create table cust(cnum int,cname varchar(50),city varchar(30),rating int,snum int)
insert into cust values(2001,'Hoffman','London',100,1001)
insert into cust values(2002,'Giovanne','Rome',200,1003)
insert into cust values(2003,'Liu','San Jose',300,1002)
insert into cust values(2004,'Grass','Brelin',100,1002)
insert into cust values(2006,'Clemens','London',300,1007)
insert into cust values(2007,'Pereira','Rome',100,1004)

create table orders(onum int,amt float,odate date,cnum int,snum int)
insert into orders values(3001,18.69,'03-OCT-94',2008,1007)
insert into orders values(3003,767.19,'03-OCT-94',2001,1001)
insert into orders values(3002,1900.10,'03-OCT-94',2007,1004)
insert into orders values(3005,5160.45,'03-OCT-94',2003,1002)
insert into orders values(3006,1098.16,'04-OCT-94',2008,1007)
insert into orders values(3009,1713.23,'04-OCT-94',2002,1003)
insert into orders values(3007,75.75,'05-OCT-94',2004,1002)
insert into orders values(3008,4723.00,'05-OCT-94',2006,1001)
insert into orders values(3010,1309.95,'06-OCT-94',2004,1002)
insert into orders values(3011,9891.88,'06-OCT-94',2006,1001)

--1
select*from salespeople
--2
select distinct snum from orders
--3
select sname,comm from salespeople where city='London'
--4
select cname from cust where rating=100
--5
select onum,amt,odate from orders
--6
select cname from cust where city='San Jose'and rating>200
--7
select cname from cust where city='San Jose'or rating>200
--8
select * from orders where amt>1000
--9
select sname,city from salespeople where city='London'and comm>0.10
--10 doubt
select cname from cust where city='Rome' and rating<=100
--11
select sname from salespeople where city='Barcelona' or city='London'
-12
select sname from salespeople where comm>10 and comm<12
--13
select cname from cust where city is null
--14
select onum from orders where odate='03-OCT-1994' or odate='04-OCT-1994'
--15
select * from orders



