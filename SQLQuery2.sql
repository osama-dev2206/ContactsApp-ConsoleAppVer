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
,Constraint UQ_FUllName Unique(FirstName,LastName),
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