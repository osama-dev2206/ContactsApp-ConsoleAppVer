Select * From Contacts;

Alter Table Contacts
Add
Constraint UQ_Contacts_Email Unique(Email)
,Constraint UQ_FUllName Unique(FirstName,LastName),
Constraint UQ_Phone Unique(Phone);

