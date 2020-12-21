/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO Filiere(FiliereName) VALUES ('GENIE INFO');
INSERT INTO Filiere(FiliereName) VALUES ('GENIE INDUS');
INSERT INTO Filiere(FiliereName) VALUES ('GENIE RESEAUX');
INSERT INTO Filiere(FiliereName) VALUES ('GENIE LOGICIEL');

INSERT INTO Etudiant(ID_Filiere,LastName,FirstName,CNE,CNI,DOB,gender,tele,adresse,age) VALUES (1,'BOUJAAFAR', 'Lamiae', 'L147047144','I630032','22/05/2000','F',0653701101,'HayZaitouna SAFI',20);
INSERT INTO Etudiant(ID_Filiere,LastName,FirstName,CNE,CNI,DOB,gender,tele,adresse,age) VALUES (2,'BERRADA', 'Widad', 'L58987456','I789654','28/08/1999','F',065375854,'Hay BENADDI SAFI',21);
INSERT INTO Etudiant(ID_Filiere,LastName,FirstName,CNE,CNI,DOB,gender,tele,adresse,age) VALUES (1,'RAHIM', 'Ahmed', 'R478756987','K8598741','22/10/1999','F',0653701101,'Hay SAADA SAFI',21);
INSERT INTO Etudiant(ID_Filiere,LastName,FirstName,CNE,CNI,DOB,gender,tele,adresse,age) VALUES (3,'HARAK', 'Chiamae', 'KL589741','H589874','02/02/1997','F',0653701487,'Hay MIFTAH KHAIR SAFI',23);
INSERT INTO Etudiant(ID_Filiere,LastName,FirstName,CNE,CNI,DOB,gender,tele,adresse,age) VALUES (3,'MOUTAR', 'Ibtihal', 'Q47896523','K452136','14/02/1998','F',0653701101,'Hay OUADBACHA SAFI',22);
 