Select Contacts.FirstName ,Contacts.LastName ,Contacts.Email ,
Contacts.Phone ,Contacts.Address 
,Contacts.DateOfBirth
, Countries.CountryName
From Contacts
Inner Join Countries
On Contacts.CountryID = Countries.CountryID;

Alter Table Contacts
Add
Constraint UQ_Contacts_Email Unique(Email)
,
Constraint UQ_Phone Unique(Phone);

Insert Into Contacts(FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath)
values('John', 'Doe', 'Email', '123-456-7890', '123 Main St', '1980-01-01', 1, 'path/to/image.jpg');

Select SCOPE_IDENTITY();


Update Contacts 
set Email= '' , FirstName = '' , LastName = '' , Phone = '' , Address = '' , DateOfBirth = NULL , CountryID = NULL , ImagePath = ''
where ContactID = ContactID;


select x='T'
from Contacts 
where Contacts.ContactID =1 ;

--Find Country By Name.
Select Countries.CountryID 
From Countries
Where Lower (Countries.CountryName) = Lower('united states');

--Find Country By ID.
Select Countries.CountryName 
from Countries 
Where Countries.CountryID = 1; 

select R = 'T' 
From Countries
where LOWER(Countries.CountryName)= Lower('united states');



Select Countries.CountryName 
from Countries
where Countries.CountryID= 1;


Select R='T'
from Countries 
Where Countries.CountryID = 1; 

Insert Into Countries (CountryName)
values ('united states')

-- if the result is true then the country already exists 
Select R='T'
from Countries
where Lower(CountryName) = lower('united states ')




Insert Into Countries (CountryName,Code,PhoneCode)
values ('united states','Code' , 'pC')
Select SCOPE_IDENTITY();

select * from Countries;
select * From Contacts;

alter Table Countries 
Add 
Constraint UQ_CountryName 
Unique(CountryName) ;

Update Countries
Set CountryName = 'UK'
where CountryID = 6; 

Delete Countries 
Where Countries.CountryID = 9;

Select * From Countries 
order by CountryID ASC; 

-- into Countries --

--1- Code nvarchar(3) allow null

--2- PhoneCode nvarchar(3) allow null
alter table Countries 
Add 
Code nvarchar(3) null ,
PhoneCode nvarchar(3) null 
;

select * from Countries;

alter table Countries
add 
Constraint UQ_PhoneCode Unique(Code) ;

UPDATE Countries SET Code = 'US', PhoneCode = '+1'  WHERE CountryID = 1;
UPDATE Countries SET Code = 'GB', PhoneCode = '+44' WHERE CountryID = 2;
UPDATE Countries SET Code = 'CA', PhoneCode = '+1'  WHERE CountryID = 3;
UPDATE Countries SET Code = 'AU', PhoneCode = '+61' WHERE CountryID = 4;
UPDATE Countries SET Code = 'DE', PhoneCode = '+49' WHERE CountryID = 5;
UPDATE Countries SET Code = 'AE', PhoneCode = '+971' WHERE CountryID = 6;

delete  Countries
where Countries.CountryID = 6;