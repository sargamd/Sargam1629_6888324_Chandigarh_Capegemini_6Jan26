
/* ** Insert values in table called LMS_MEMBERS ** */

Insert into LMS_MEMBERS
Values('LM001', 'AMIT', 'CHENNAI','12-FEB-2012', '11-FEB-2013','Temporary');

Insert into LMS_MEMBERS
Values('LM002', 'ABDHUL', 'DELHI','10-APRIL-2012', '09-APRIL-2013','Temporary');

Insert into LMS_MEMBERS
Values('LM003', 'GAYAN', 'CHENNAI','12-MAY-2013', '14-MAY-2013', 'Permanent');

Insert into LMS_MEMBERS
Values('LM004', 'RADHA', 'CHENNAI','22-APRIL-2012', '21-APRIL-2013', 'Temporary');

Insert into LMS_MEMBERS
Values('LM005', 'GURU', 'BANGALORE','30-MARCH-2012', '29-MARCH-2013','Temporary');

Insert into LMS_MEMBERS
Values('LM006', 'MOHAN', 'CHENNAI','12-APRIL-2012','12-APRIL-2013','Temporary');

SELECT * FROM LMS_MEMBERS
--UPDATE LMS_MEMBERS SET DATE_REGISTER='12-APRIL-2012',DATE_EXPIRE='12-APRIL-2013' WHERE MEMBER_ID='LM006'





/* ** Insert values in table called LMS_SUPPLIERS_DETAILS ** */


Insert into  LMS_SUPPLIERS_DETAILS 
Values ('S01','SINGAPORE SHOPPEE', 'CHENNAI', 9894123555,'sing@gmail.com');

Insert into  LMS_SUPPLIERS_DETAILS 
Values ('S02','JK Stores', 'MUMBAI', 9940123450 ,'jks@yahoo.com');

Insert into  LMS_SUPPLIERS_DETAILS 
Values ('S03','ROSE BOOK STORE', 'TRIVANDRUM', 9444411222,'rose@gmail.com');

Insert into  LMS_SUPPLIERS_DETAILS 
Values ('S04','KAVARI STORE', 'DELHI', 8630001452,'kavi@redif.com');

Insert into  LMS_SUPPLIERS_DETAILS 
Values ('S05','EINSTEN BOOK GALLARY', 'US', 9542000001,'eingal@aol.com');

Insert into  LMS_SUPPLIERS_DETAILS 
Values ('S06','AKBAR STORE', 'MUMBAI',7855623100 ,'akbakst@aol.com');





/* ** Insert values in table called LMS_FINE_DETAILS ** */


Insert into LMS_FINE_DETAILS Values('R1', 20);

insert into LMS_FINE_DETAILS Values('R2', 50);

Insert into LMS_FINE_DETAILS Values('R3', 75);

Insert into LMS_FINE_DETAILS Values('R4', 100);

Insert into LMS_FINE_DETAILS Values('R5', 150);

Insert into LMS_FINE_DETAILS Values('R6', 200);

      
SELECT * FROM LMS_BOOK_DETAILS
DELETE FROM LMS_BOOK_DETAILS WHERE BOOK_CODE='BL000001'

/* ** Insert values in table called LMS_BOOK_DETAILS ** */


Insert into LMS_BOOK_DETAILS
Values('BL000001', 'Java How To Do Program', 'JAVA', 'Paul J. Deitel', 'Prentice Hall', '10-DEC-1999', 6, 600.00, 'A1','10-MAY-2011', 'S01');

Insert into LMS_BOOK_DETAILS
Values('BL000002', 'Java: The Complete Reference ', 'JAVA', 'Herbert Schildt',  'Tata Mcgraw Hill ','10-OCT-2011', 5, 750.00, 'A1','10-MAY-2011', 'S03');

Insert into LMS_BOOK_DETAILS 
Values('BL000003', 'Java How To Do Program', 'JAVA', 'Paul J. Deitel', 'Prentice Hall', '10-DEC-1999', 6, 600.00, 'A1','12-MAY-2012', 'S01');

Insert into LMS_BOOK_DETAILS
Values('BL000004', 'Java: The Complete Reference ', 'JAVA', 'Herbert Schildt', 'Tata Mcgraw Hill ','10-OCT-2011', 5, 750.00, 'A1','12-MAY-2012', 'S01');

Insert into LMS_BOOK_DETAILS 
Values('BL000005', 'Java How To Do Program', 'JAVA', 'Paul J. Deitel',  'Prentice Hall', '10-DEC-1999', 6, 600.00, 'A1','12-MAY-2012', 'S01');

Insert into LMS_BOOK_DETAILS
Values('BL000006', 'Java: The Complete Reference ', 'JAVA', 'Herbert Schildt', 'Tata Mcgraw Hill ','10-OCT-2011', 5, 750.00, 'A1','12-MAY-2012', 'S03');

Insert into LMS_BOOK_DETAILS 
Values('BL000007', 'Let Us C', 'C', 'Yashavant Kanetkar ', 'BPB Publications', '11-DEC-2010',  9, 500.00 , 'A3','03-JAN-2010', 'S03');

Insert into LMS_BOOK_DETAILS 
Values('BL000008', 'Let Us C', 'C', 'Yashavant Kanetkar ','BPB Publications', '11-DEC-2010',  9, 500.00 , 'A3','03-JAN-2010', 'S04');

       

/* ** Insert values in table called LMS_BOOK_ISSUE ** */


Insert into LMS_BOOK_ISSUE 
Values (001, 'LM001', 'BL000001', '01-MAY-2012', '16-MAY-2012', '16-MAY-2012','N', 'R1');

Insert into LMS_BOOK_ISSUE 
Values (002, 'LM002', 'BL000002', '20-APRIL-2012', '06-MAY-2012','04-MAY-2012', 'N', 'R2');

Insert into LMS_BOOK_ISSUE
Values (003, 'LM003', 'BL000007', '01-APRIL-2012', '16-APRIL-2012', '20-APRIL-2012','Y','R1');

Insert into LMS_BOOK_ISSUE 
Values (004, 'LM004', 'BL000005', '01-APRIL-2012','16-APRIL-2012','20-APRIL-2012', 'Y', 'R1');

Insert into LMS_BOOK_ISSUE 
Values (005, 'LM005', 'BL000008', '30-MAR-2012', '15-APRIL-2012','20-APRIL-2012' ,'N', 'R2');
--SELECT * FROM LMS_BOOK_ISSUE





--question1--
--khiuhhk
kjjkjk
--theata style
select e.empid,e.ename,d.did,d.dname
from emptb e ,depttb d
where e.did=d.did
order by e.ename
--anis style
select e.empid,e.ename,d.did,d.dname
from emptb e join deptb d
on e.did=d.did
join table3
on d.did=t3.table3
join table4
on t4.pk=t3.pk

where e.ename='k%'
order by e.ename
