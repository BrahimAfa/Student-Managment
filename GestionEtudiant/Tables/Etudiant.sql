CREATE TABLE Etudiant (
    ID_Etudiant int NOT NULL PRIMARY KEY IDENTITY,
    ID_Filiere int NOT NULL,
    LastName varchar(50) NOT NULL,
    FirstName varchar(50) NOT NULL,
    CNE varchar(15) UNIQUE NOT NULL,
	CNI varchar(15) UNIQUE NOT NULL,
	DOB date,
	gender varchar(20),
	tele varchar(20),
	adresse varchar(250),
    age int, 
    CONSTRAINT [FK_Etudiant_Filiere] FOREIGN KEY (ID_Filiere) REFERENCES Filiere (ID_Filiere) 
);
