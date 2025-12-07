--Sequence
--Create Sequence Object 
Create SEQUENCE MySequence
START WITH 1
INCREMENT BY 1
MinValue 1
MaxValue 5
CYCLE; --default

create TABLE person1
(ID int,
FullName nvarchar(100) NOT NULL);

create TABLE person2
(ID int,
FullName nvarchar(100) NOT NULL);

-- Insert Some Data 
INSERT into person1
VALUES (NEXT VALUE FOR MySequence, 'ali')

INSERT into person2
VALUES (NEXT VALUE FOR MySequence, 'omar')

select * from person1
select * from person2

---------------------------------------------------
create database snaptest
on
(
 name='AdventureWorks2012_Data',  --mdf file name
 filename='e:\file1.ss'
)
as snapshot of adventureworks2012


use AdventureWorks2012
	select * from HumanResources.Employee

use snaptest
	select * from HumanResources.Employee
-------------------------------------------
--8.	Create snapshot of adventureworks_db and test it
CREATE DATABASE SnapTest2
ON
(
    NAME = 'AdventureWorks2012_Data',   -- Logical name of the source data file
    FILENAME = 'C:\snapshots\AdvWorksSnapshot.ss'            -- New file path for snapshot
)
AS SNAPSHOT OF AdventureWorks2012;
GO

--testing the snapshot : 
use AdventureWorks2012

delete from AdventureWorks2012.Production.ProductReview
where productreviewid = 1


select * from AdventureWorks2012.Production.ProductReview
select * from SnapTest2.Production.ProductReview
