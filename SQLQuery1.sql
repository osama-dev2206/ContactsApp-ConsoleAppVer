EXEC sp_changedbowner 'sa';

Select * from Contacts;
Select * from Countries; 


select Contacts.FirstName+' ' + Contacts.LastName As FullName ,
Contacts.Phone , Countries.CountryName 
From Contacts
Inner Join Countries  ON Contacts.CountryID = Countries.CountryID ;



Select * From Contacts 
where Contacts.CountryID=1 and FirstName='jane';

select * From Contacts -- Starts with a
where FirstName like 'J%';

 -- Ends with a
select * From Contacts
where FirstName like '%J';

 -- Contains a
select * From Contacts
where FirstName like '%J%';





-- DML 
Insert Into Contacts(FirstName ,LastName , Email , Phone , Address ,CountryID)
values
('Jane','Jack','jAaa@g.com' , '1231332','123 main st',1);

Insert Into Contacts(FirstName ,LastName , Email , Phone , Address ,CountryID)
values ('Jane','Magi','wkc@j.com' , '1231332','123 main st',1);

Insert Into Contacts(FirstName ,LastName , Email , Phone , Address ,CountryID)
values ('Jane','Mekai','qq@jk.com' , '1231332','123 main st',1);

Insert Into Contacts(FirstName ,LastName , Email , Phone , Address ,CountryID)
values ('Ganj','Mekai','qsfs@jk.com' , '14321332','123 main st',2);



-------------------------------------------------------------------------------------

Select distinct FirstName From Contacts ; -- multiple rows 

Select FirstName From Contacts where ContactID=1 ; -- single row

Select * From Contacts ; -- multiple rows 

Select * From Contacts where ContactID=1 ;

-- DML
Insert Into Contacts(FirstName ,LastName , Email , Phone , Address ,CountryID)
values('Ahmed','Mekai','dah@jk.com' , '178332','121 main st',3);
Select SCOPE_IDENTITY() ; -- returns the last identity value inserted 
-- into an identity column in the same scope


Delete from Contacts where ContactID=11;


--- add constraints to the Contacts table
alter Table Contacts
ADD Constraint UQ_Email Unique(Email) ;

alter Table Contacts
ADD Constraint UQ_Phone Unique(Phone) ;

alter Table Contacts
ADD Constraint UQ_FullName Unique(FirstName , LastName) ;


---------

select * From Contacts
where LOWER (Contacts.FirstName) ='jane' ; -- case insensitive search


select * From Contacts
where Upper (Contacts.FirstName) ='JANE' ; -- case insensitive search

-- Dml : Update Record 
Update  Contacts
Set FirstName = 'John' , Contacts.LastName = 'Doe' , Contacts.Email = 'email@x.com' , 
Contacts.Phone = '1234567890' , Contacts.Address = '456 Elm St' ,
Contacts.CountryID = 2
where Contacts.ContactID = 1;

Select * From Contacts where ContactID = 2;

-- dml Delete Record
Delete Contacts 
Where Contacts.ContactID = 
(select ContactID from Contacts where Contacts.ContactID =8 ); 

Select value from string_split('1,2,3', ',');


Select * 
From Contacts 
Where Contacts.ContactID in 
(Select Value From string_split('1,2,3,5',',') ) ;


